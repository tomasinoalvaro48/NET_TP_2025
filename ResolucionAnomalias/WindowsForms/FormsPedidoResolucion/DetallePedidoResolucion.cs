using System.Data;
using API.Clients;
using API.Clients.EntitiesClients;
using DTOs;

namespace WindowsForms.FormsPedidoResolucion
{
    public partial class DetallePedidoResolucion : Form
    {
        private PedidoResolucionDTO pedido;
        private FormMode mode;
        private List<AnomaliaPedidoDTO> anomaliasLocales;
        private UsuarioDTO? _currentUser; 

        public PedidoResolucionDTO Pedido
        {
            get { return pedido; }
            set
            {
                pedido = value;
                this.SetPedidoResolucion();
            }
        }

        public FormMode Mode
        {
            get { return mode; }
            set { SetFormMode(value); }
        }

        public DetallePedidoResolucion()
        {
            InitializeComponent();
        }

        public DetallePedidoResolucion(FormMode mode, PedidoResolucionDTO pedido) : this()
        {
            Init(mode, pedido);
        }

        private async void Init(FormMode mode, PedidoResolucionDTO pedido)
        {
            ConfigurarColumnas();
            anomaliasLocales = new List<AnomaliaPedidoDTO>();

            _currentUser = await AuthServiceProvider.Instance.GetCurrentUserAsync();
            if (_currentUser == null)
            {
                MessageBox.Show("No se pudo obtener el usuario actual. Inicie sesión nuevamente.", "Sesión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
                return;
            }

            await LoadZonas();

            this.Pedido = pedido;

            this.Mode = mode;

            if (this.Mode == FormMode.Add && _currentUser.Tipo_usu == "Denunciante")
            {
                this.Pedido.DenuncianteId = _currentUser.Cod_usu;
                this.Pedido.DenuncianteNombre = _currentUser.Nombre_usu;
                this.textBoxDenunciante.Text = _currentUser.Nombre_usu;
            }

            if (this.Mode == FormMode.Update && _currentUser.Tipo_usu == "Cazador")
            {
                textBoxCazador.Text = _currentUser.Nombre_usu;
            }

            ApplyPermissions();
        }

        private bool IsCazador => _currentUser?.Tipo_usu == "Cazador";
        private bool IsDenunciante => _currentUser?.Tipo_usu == "Denunciante";

        private void ApplyPermissions()
        {
            bool canEditCamposBasicos = true;
            bool canEditAnomalias = true;
            string aceptarText = "Realizar Pedido";

            if (IsCazador && this.Mode == FormMode.Update)
            {
                canEditCamposBasicos = false;
                canEditAnomalias = false;
                aceptarText = "Aceptar pedido";

                // Null-safe al leer el nombre del cazador
                textBoxCazador.Text = this.Pedido?.CazadorNombre ?? _currentUser?.Nombre_usu ?? string.Empty;
            }

            comboBoxZonas.Enabled = canEditCamposBasicos;
            textBoxDireccion.ReadOnly = !canEditCamposBasicos;
            textBoxDescripcion.ReadOnly = !canEditCamposBasicos;

            dataGridViewAnomalias.Enabled = canEditAnomalias;
            buttonAgregar.Enabled = canEditAnomalias;
            buttonEliminar.Enabled = canEditAnomalias && (anomaliasLocales?.Count > 0);

            textBoxComentario.ReadOnly = false;

            buttonAceptar.Text = aceptarText;
        }

        private async Task LoadZonas()
        {
            var zonas = await ZonaApiClient.GetAllAsync();
            var zonasConLocalidad = zonas.Select(z => new
            {
                Id = z.Id,
                ZonaConLocalidad = $"{z.LocalidadNombre} {z.Nombre}"
            }).ToList();

            comboBoxZonas.DataSource = zonasConLocalidad;
            comboBoxZonas.DisplayMember = "ZonaConLocalidad";
            comboBoxZonas.ValueMember = "Id";
            comboBoxZonas.SelectedIndex = -1;
        }

        private void SetPedidoResolucion()
        {
            this.textBoxId.Text = this.Pedido.Id.ToString();

            if (this.Mode == FormMode.Add)
            {
                this.Pedido.Fecha = DateTime.Now;
            }

            this.textBoxFecha.Text = this.Pedido.Fecha.ToString("dd/MM/yyyy");
            if (this.Pedido.ZonaId > 0)
                this.comboBoxZonas.SelectedValue = this.Pedido.ZonaId;

            // Completar Dirección en la UI (faltaba)
            this.textBoxDireccion.Text = this.Pedido.Direccion;

            this.textBoxDescripcion.Text = this.Pedido.Descripcion;
            this.textBoxComentario.Text = this.Pedido.Comentario;
            this.textBoxDificultad.Text = this.Pedido.Dificultad.ToString();
            this.textBoxCazador.Text = this.Pedido.CazadorNombre;
            this.textBoxDenunciante.Text = this.Pedido.DenuncianteNombre;

            anomaliasLocales = this.Pedido.Anomalias.Select(ap => new AnomaliaPedidoDTO
            {
                PedidoResolucionId = ap.PedidoResolucionId,
                TipoAnomaliaId = ap.TipoAnomaliaId,
                TipoAnomaliaDescripcion = ap.TipoAnomaliaDescripcion,
                TipoAnomaliaDificultad = ap.TipoAnomaliaDificultad
            }).ToList();

            RefreshAnomaliasGrid();
        }

        private void RefreshAnomaliasGrid()
        {
            dataGridViewAnomalias.DataSource = null;
            dataGridViewAnomalias.DataSource = anomaliasLocales;

            bool hasAnomalias = anomaliasLocales != null && anomaliasLocales.Count > 0;
            buttonEliminar.Enabled = dataGridViewAnomalias.Enabled && hasAnomalias;

            if (hasAnomalias && dataGridViewAnomalias.Rows.Count > 0)
            {
                dataGridViewAnomalias.ClearSelection();
                dataGridViewAnomalias.Rows[0].Selected = true;
            }

            UpdateDificultad();
        }

        private void UpdateDificultad()
        {
            int dificultadTotal = anomaliasLocales.Sum(a => a.TipoAnomaliaDificultad ?? 0);
            textBoxDificultad.Text = dificultadTotal.ToString();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            AnomaliaPedidoDTO nuavaAnomalia = new AnomaliaPedidoDTO();
            DetalleAnomalia detalleAnomalia = new DetalleAnomalia(FormMode.Add, nuavaAnomalia);

            if (detalleAnomalia.ShowDialog() == DialogResult.OK)
            {
                // Verificar si la anomalía ya existe en la lista
                if (anomaliasLocales.Any(a => a.TipoAnomaliaId == detalleAnomalia.Anomalia.TipoAnomaliaId))
                {
                    MessageBox.Show("Esta anomalía ya fue agregada al pedido.", "Anomalía duplicada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                anomaliasLocales.Add(detalleAnomalia.Anomalia);
                RefreshAnomaliasGrid();
            }
        }

        private void ConfigurarColumnas()
        {
            this.dataGridViewAnomalias.AutoGenerateColumns = false;
            this.dataGridViewAnomalias.Width = 620;
            this.dataGridViewAnomalias.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NombreAnomalia",
                HeaderText = "Nombre Anomalia",
                DataPropertyName = "TipoAnomaliaDescripcion",
                Width = 300
            });

            this.dataGridViewAnomalias.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DificultadAnomalia",
                HeaderText = "Dificultad Anomalia",
                DataPropertyName = "TipoAnomaliaDificultad",
                Width = 300
            });
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewAnomalias.SelectedRows.Count > 0)
            {
                AnomaliaPedidoDTO selectedAnomalia = (AnomaliaPedidoDTO)dataGridViewAnomalias.SelectedRows[0].DataBoundItem;

                var result = MessageBox.Show("¿Está seguro que desea eliminar la anomalia?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    anomaliasLocales.RemoveAll(i => i.TipoAnomaliaId == selectedAnomalia.TipoAnomaliaId);
                    RefreshAnomaliasGrid();
                }
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private async void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (_currentUser == null)
            {
                MessageBox.Show("Sesión inválida. Debe iniciar sesión.", "Sesión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Flujo de Cazador: aceptar pedido (solo Update)
            if (IsCazador && this.Mode == FormMode.Update)
            {
                this.Pedido.CazadorId = _currentUser.Cod_usu;
                this.Pedido.CazadorNombre = _currentUser.Nombre_usu;
                this.Pedido.Estado = "aceptado"; 
                this.Pedido.Comentario = textBoxComentario.Text;

                try
                {
                    await PedidoResolucionApiClient.UpdateAsync(this.Pedido);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"No se pudo aceptar el pedido: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }

            // Flujo de Denunciante: crear/editar pedido
            if (this.ValidatePedido())
            {
                // Datos desde la UI
                this.Pedido.ZonaId = (int)comboBoxZonas.SelectedValue;
                this.Pedido.Anomalias = anomaliasLocales.ToList();
                this.Pedido.Fecha = DateTime.ParseExact(textBoxFecha.Text, "dd/MM/yyyy", null);
                this.Pedido.Descripcion = textBoxDescripcion.Text;
                this.Pedido.Direccion = textBoxDireccion.Text;
                this.Pedido.Comentario = textBoxComentario.Text;

                // Asegurar denunciante = usuario logueado
                this.Pedido.DenuncianteId = _currentUser.Cod_usu;
                this.Pedido.DenuncianteNombre = _currentUser.Nombre_usu;

                try
                {
                    if (this.Mode == FormMode.Update)
                    {
                        await PedidoResolucionApiClient.UpdateAsync(this.Pedido);
                    }
                    else
                    {
                        await PedidoResolucionApiClient.AddAsync(this.Pedido);
                    }

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"No se pudo guardar el pedido: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SetFormMode(FormMode value)
        {
            this.mode = value;

            if (mode == FormMode.Add)
            {
                textBoxId.Visible = false;
                textBoxFecha.Visible = false;
                labelFecha.Visible = false;
                labelId.Visible = false;
                textBoxCazador.Visible = false;
                labelCazador.Visible = false;
                textBoxComentario.Visible = false;
                labelComentario.Visible = false;
                textBoxDescripcion.ReadOnly = false;
                buttonAgregar.Visible = true;
                buttonEliminar.Visible = true;
            }

            if (mode == FormMode.Update)
            {
                textBoxId.Visible = true;
                textBoxFecha.Visible = true;
                labelFecha.Visible = true;
                labelId.Visible = true;
                textBoxComentario.Visible = true;
                labelComentario.Visible = true;
                textBoxDescripcion.ReadOnly = true;
                buttonAgregar.Visible = false;
                buttonEliminar.Visible = false;
            }

            // Seguro ahora que ApplyPermissions no lee Pedido sin null-check
            if (_currentUser != null)
            {
                ApplyPermissions();
            }
        }

        private bool ValidatePedido()
        {
            if (IsCazador && this.Mode == FormMode.Update)
                return true;

            bool isValid = true;

            errorProvider.SetError(comboBoxZonas, string.Empty);
            errorProvider.SetError(dataGridViewAnomalias, string.Empty);
            errorProvider.SetError(textBoxDescripcion, string.Empty);
            errorProvider.SetError(textBoxDireccion, string.Empty);

            if (comboBoxZonas.SelectedValue == null)
            {
                errorProvider.SetError(comboBoxZonas, "Debe seleccionar una zona.");
                isValid = false;
            }

            if (anomaliasLocales.Count == 0)
            {
                errorProvider.SetError(dataGridViewAnomalias, "Debe agregar al menos una anomalia.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(textBoxDescripcion.Text))
            {
                errorProvider.SetError(textBoxDescripcion, "La descripción no puede estar vacía.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(textBoxDireccion.Text))
            {
                errorProvider.SetError(textBoxDireccion, "La dirección no puede estar vacía.");
                isValid = false;
            }

            if(string.IsNullOrWhiteSpace(textBoxComentario.Text) && _currentUser.Tipo_usu == "denunciante")
            {
                errorProvider.SetError(textBoxComentario, "El comentario no puede estar vacío.");
                isValid = false;
            }

            return isValid;
        }
    }
}
