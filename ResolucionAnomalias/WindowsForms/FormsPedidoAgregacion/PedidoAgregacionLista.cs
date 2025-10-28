using DTOs;
using API.Clients.EntitiesClients;
using API.Clients;

namespace WindowsForms.FormsPedidoAgregacion
{
    public partial class PedidoAgregacionLista : Form
    {
        public PedidoAgregacionLista()
        {
            InitializeComponent();
            ConfigurarColumas();
        }

        private async void PedidosAgregacion_Load(object sender, EventArgs e)
        {
            await ValidarPermisosAsync();
            await GetAllAndLoad();
        }

        private PedidoAgregacionDTO SelectedItem()
        {
            return (PedidoAgregacionDTO)pedidosAgregacionDataGridView.SelectedRows[0].DataBoundItem;
        }

        private void ConfigurarColumas()
        {
            this.pedidosAgregacionDataGridView.AutoGenerateColumns = false;
            this.pedidosAgregacionDataGridView.Columns.Clear();

            this.pedidosAgregacionDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Id_pedido_agreg",
                HeaderText = "Id del pedido",
                DataPropertyName = "Id_pedido_agreg",
                Width = 120
            });

            this.pedidosAgregacionDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Descripcion_pedido_agreg",
                HeaderText = "Descripción de la anomalía",
                DataPropertyName = "Descripcion_pedido_agreg",
                Width = 250
            });

            this.pedidosAgregacionDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Dificultad_pedido_agreg",
                HeaderText = "Dificultad",
                DataPropertyName = "Dificultad_pedido_agreg",
                Width = 100
            });

            this.pedidosAgregacionDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Estado_pedido_agreg",
                HeaderText = "Estado",
                DataPropertyName = "Estado_pedido_agreg",
                Width = 120
            });

            // Nueva columna: Cazador
            this.pedidosAgregacionDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NombreCazador",
                HeaderText = "Cazador",
                DataPropertyName = "NombreCazador",
                Width = 180
            });
        }

        private async void agregarButton_Click(object sender, EventArgs e)
        {
            var user = await AuthServiceProvider.Instance.GetCurrentUserAsync();
            if (string.Equals(user?.Tipo_usu, "Operador", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("El Operador no puede agregar pedidos de agregación.", "Acceso denegado",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var pedidoAgregacionDetalle = new PedidoAgregacionDetalle();
            var pedidoAgregacionNueva = new PedidoAgregacionDTO();

            pedidoAgregacionDetalle.Mode = FormMode.Add;
            pedidoAgregacionDetalle.PedidoAgregacion = pedidoAgregacionNueva;

            pedidoAgregacionDetalle.ShowDialog();
            await GetAllAndLoad();
        }

        private async void modificarButton_Click(object sender, EventArgs e)
        {
            try
            {
                var user = await AuthServiceProvider.Instance.GetCurrentUserAsync();
                if (string.Equals(user?.Tipo_usu, "Operador", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("El Operador no puede modificar pedidos de agregación.", "Acceso denegado",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var seleccionado = SelectedItem();
                if (string.Equals(seleccionado.Estado_pedido_agreg, "Aceptado", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("No se puede modificar un pedido de agregación ya Aceptado.", "Acción no permitida",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var pedidoAgregacionDetalle = new PedidoAgregacionDetalle();

                int id = seleccionado.Id_pedido_agreg;
                var pedidoAgregacion = await PedidoAgregacionApiClient.GetAsync(id);

                pedidoAgregacionDetalle.Mode = FormMode.Update;
                pedidoAgregacionDetalle.PedidoAgregacion = pedidoAgregacion;

                pedidoAgregacionDetalle.ShowDialog();

                await GetAllAndLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar pedido de agregación para modificar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void eliminarButton_Click(object sender, EventArgs e)
        {
            try
            {
                var user = await AuthServiceProvider.Instance.GetCurrentUserAsync();
                if (string.Equals(user?.Tipo_usu, "Operador", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("El Operador no puede eliminar pedidos de agregación.", "Acceso denegado",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = this.SelectedItem().Id_pedido_agreg;
                var result = MessageBox.Show($"¿Está seguro que desea eliminar el pedido de agregación con id {id}?",
                    "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    await PedidoAgregacionApiClient.DeleteAsync(id);
                    await GetAllAndLoad();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el pedido de agregación: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task GetAllAndLoad()
        {
            try
            {
                var user = await AuthServiceProvider.Instance.GetCurrentUserAsync();

                var source = (await PedidoAgregacionApiClient.GetAllAsync())?.ToList() ?? new List<PedidoAgregacionDTO>();

                // Filtrar: si es Cazador, ver solo sus pedidos
                if (string.Equals(user?.Tipo_usu, "Cazador", StringComparison.OrdinalIgnoreCase))
                {
                    source = source.Where(p => p.CazadorId == user!.Cod_usu).ToList();
                }

                pedidosAgregacionDataGridView.DataSource = null;
                pedidosAgregacionDataGridView.DataSource = source;

                var hasRows = pedidosAgregacionDataGridView.Rows.Count > 0;
                if (hasRows)
                {
                    pedidosAgregacionDataGridView.Rows[0].Selected = true;
                }

                // Habilitar según selección/rol/estado
                await ActualizarBotonesSegunUsuarioYPedido();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la lista de pedidos de agregación: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                eliminarButton.Enabled = false;
                modificarButton.Enabled = false;
                buttonAceptar.Enabled = false;
                buttonRechazar.Enabled = false;
            }
        }

        private async Task ValidarPermisosAsync()
        {
            var user = await AuthServiceProvider.Instance.GetCurrentUserAsync();

            if (!string.Equals(user?.Tipo_usu, "Operador", StringComparison.OrdinalIgnoreCase) &&
                !string.Equals(user?.Tipo_usu, "Cazador", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("No tenés permisos para acceder a pedidos de agregación", "Acceso denegado");
                this.Close();
                return;
            }

            // Operador no puede agregar/modificar/eliminar
            if (string.Equals(user.Tipo_usu, "Operador", StringComparison.OrdinalIgnoreCase))
            {
                agregarButton.Visible = false;
                modificarButton.Visible = false;
                eliminarButton.Visible = false;
            }
            else
            {
                // Cazador: puede agregar/modificar/eliminar (con restricción de estado para modificar)
                agregarButton.Visible = true;
                modificarButton.Visible = true;
                eliminarButton.Visible = true;
            }
        }

        private async void buttonAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                var pedido = SelectedItem();

                var tipo = new TipoAnomaliaDTO
                {
                    Nombre_anom = pedido.Descripcion_pedido_agreg,
                    Dif_anom = pedido.Dificultad_pedido_agreg
                };

                var createdTipo = await TipoAnomaliaApiClient.AddAsync(tipo);

                pedido.TipoAnomaliaId = createdTipo.Cod_anom;
                pedido.NombreTipoAnomalia = createdTipo.Nombre_anom;
                pedido.Estado_pedido_agreg = "Aceptado";

                await PedidoAgregacionApiClient.UpdateAsync(pedido);

                await GetAllAndLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al aceptar el pedido de agregación: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void buttonRechazar_Click(object sender, EventArgs e)
        {
            var pedido = SelectedItem();

            pedido.Estado_pedido_agreg = "Rechazado";
            await PedidoAgregacionApiClient.UpdateAsync(pedido);

            await GetAllAndLoad();
        }

        private async Task ActualizarBotonesSegunUsuarioYPedido()
        {
            var user = await AuthServiceProvider.Instance.GetCurrentUserAsync();

            // Default
            buttonAceptar.Visible = false;
            buttonRechazar.Visible = false;

            var hasSelection = pedidosAgregacionDataGridView.SelectedRows.Count > 0;
            var pedido = hasSelection ? SelectedItem() : null;

            if (string.Equals(user?.Tipo_usu, "Cazador", StringComparison.OrdinalIgnoreCase))
            {
                // Cazador: no ve Aceptar/Rechazar
                buttonAceptar.Visible = false;
                buttonRechazar.Visible = false;

                // Habilitar Modificar solo si NO está Aceptado
                if (pedido != null)
                {
                    modificarButton.Enabled = !string.Equals(pedido.Estado_pedido_agreg, "Aceptado", StringComparison.OrdinalIgnoreCase);
                    eliminarButton.Enabled = true;
                }
                else
                {
                    modificarButton.Enabled = false;
                    eliminarButton.Enabled = false;
                }
            }
            else if (string.Equals(user?.Tipo_usu, "Operador", StringComparison.OrdinalIgnoreCase))
            {
                // Operador: no puede agregar/modificar/eliminar
                agregarButton.Enabled = false;
                modificarButton.Enabled = false;
                eliminarButton.Enabled = false;

                // Operador: puede Aceptar/Rechazar si Pendiente
                buttonAceptar.Visible = true;
                buttonRechazar.Visible = true;

                if (pedido != null && string.Equals(pedido.Estado_pedido_agreg, "Pendiente", StringComparison.OrdinalIgnoreCase))
                {
                    buttonAceptar.Enabled = true;
                    buttonRechazar.Enabled = true;
                }
                else
                {
                    buttonAceptar.Enabled = false;
                    buttonRechazar.Enabled = false;
                }
            }
        }

        private async void pedidosAgregacionDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (pedidosAgregacionDataGridView.SelectedRows.Count > 0)
                await ActualizarBotonesSegunUsuarioYPedido();
        }
    }
}