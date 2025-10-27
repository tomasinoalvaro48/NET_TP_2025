using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using API.Clients;
using API.Clients.EntitiesClients;
using Domain.Model;
using DTOs;

namespace WindowsForms.FormsPedidoResolucion
{
    public partial class DetallePedidoResolucion : Form
    {
        private PedidoResolucionDTO pedido;
        private FormMode mode;
        private List<AnomaliaPedidoDTO> anomaliasLocales;

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
            get
            {
                return mode;
            }
            set
            {
                SetFormMode(value);
            }
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

            await LoadZonas();
            this.Mode = mode;
            this.Pedido = pedido;

        }

        private async Task LoadZonas()
        {
            var zonas = await ZonaApiClient.GetAllAsync();
            var zonasConLocalidad = zonas.Select(z=> new
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
            this.comboBoxZonas.SelectedIndex = this.Pedido.ZonaId;
            this.textBoxDescripcion.Text = this.Pedido.Descripcion;
            this.textBoxComentario.Text = this.Pedido.Comentario;
            this.textBoxDificultad.Text = this.Pedido.Dificultad.ToString();
            this.textBoxCazador.Text = this.Pedido.CazadorNombre;
            this.textBoxDenunciante.Text = this.Pedido.DenuncianteNombre;


            anomaliasLocales = this.Pedido.Anomalias.Select(ap =>
                new AnomaliaPedidoDTO
                {
                    PedidoResolucionId = ap.PedidoResolucionId,
                    TipoAnomaliaId = ap.TipoAnomaliaId,
                    TipoAnomaliaDescripcion = ap.TipoAnomaliaDescripcion,
                    TipoAnomaliaDificultad = ap.TipoAnomaliaDificultad
                }
            ).ToList();

            

            RefreshAnomaliasGrid();
        }
        private void RefreshAnomaliasGrid()
        {
            dataGridViewAnomalias.DataSource = null;
            dataGridViewAnomalias.DataSource = anomaliasLocales;

            bool hasAnomalias = anomaliasLocales != null && anomaliasLocales.Count > 0;
            buttonEliminar.Enabled = hasAnomalias;

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
                anomaliasLocales.Add(detalleAnomalia.Anomalia);
                RefreshAnomaliasGrid();
            }


        }
        
        private void ConfigurarColumnas()
        {
            this.dataGridViewAnomalias.AutoGenerateColumns = false;
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
            if (dataGridViewAnomalias.SelectedRows.Count > 0) { 
                AnomaliaPedidoDTO selectedAnomalia = (AnomaliaPedidoDTO)dataGridViewAnomalias.SelectedRows[0].DataBoundItem;

                var result = MessageBox.Show($"¿Está seguro que desea eliminar la anomalia?","Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes) { 
                    anomaliasLocales.RemoveAll(i=>i.TipoAnomaliaId == selectedAnomalia.TipoAnomaliaId);
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
            if(this.ValidatePedido())
            {
                this.Pedido.ZonaId = (int)comboBoxZonas.SelectedValue;
                this.Pedido.Anomalias = anomaliasLocales.ToList();
                this.Pedido.Fecha = DateTime.ParseExact(textBoxFecha.Text,"dd/MM/yyyy", null);
                if(this.Mode == FormMode.Update)
                {
                    await PedidoResolucionApiClient.UpdateAsync(this.Pedido);
                }
                else
                {
                    //await PedidoAgregacionApiClient.AddAsync(this.Pedido);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();

            }
        }

        private void SetFormMode(FormMode value)
        {
            this.mode = value;

            if(mode == FormMode.Add)
            {
                textBoxId.Visible = false;
                textBoxFecha.Visible = false;
                labelFecha.Visible = false;
                labelId.Visible = false;
                textBoxCazador.Visible = false;
                labelCazador.Visible = false;
                textBoxComentario.Visible = false;
                labelComentario.Visible = false;


            }

            if(mode == FormMode.Update)
            {
                textBoxId.Visible = true;
                textBoxFecha.Visible = true;
                labelFecha.Visible = true;
                labelId.Visible = true;
                textBoxComentario.Visible = true;
                textBoxDescripcion.ReadOnly = true;
                labelComentario.Visible = true;


            }
        }
        private bool ValidatePedido()
        {
            bool isValid = true;

            errorProvider.SetError(comboBoxZonas, string.Empty);
            errorProvider.SetError(dataGridViewAnomalias, string.Empty);
            errorProvider.SetError(textBoxDescripcion, string.Empty);
            errorProvider.SetError(textBoxDireccion, string.Empty);

            if (comboBoxZonas.SelectedIndex == null)
            {
                errorProvider.SetError(comboBoxZonas, "Debe seleccionar una zona.");
                isValid = false;
            }

            if(anomaliasLocales.Count == 0)
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



            return isValid;
        }
    }
}
