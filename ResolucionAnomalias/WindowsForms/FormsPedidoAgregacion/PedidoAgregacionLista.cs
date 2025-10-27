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
            this.GetAllAndLoad();
        }

        private PedidoAgregacionDTO SelectedItem()
        {
            PedidoAgregacionDTO pedidoAgregacion;

            pedidoAgregacion = (PedidoAgregacionDTO)pedidosAgregacionDataGridView.SelectedRows[0].DataBoundItem;

            return pedidoAgregacion;
        }

        private void ConfigurarColumas()
        {
            this.pedidosAgregacionDataGridView.AutoGenerateColumns = false;

            this.pedidosAgregacionDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Id_pedido_agreg",
                HeaderText = "Id del pedido",
                DataPropertyName = "Id_pedido_agreg",
                Width = 150
            });

            this.pedidosAgregacionDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Descripcion_pedido_agreg",
                HeaderText = "Descripción de la anomalía",
                DataPropertyName = "Descripcion_pedido_agreg",
                Width = 150
            });


            this.pedidosAgregacionDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Dificultad_pedido_agreg",
                HeaderText = "Dificultad de la anomalía",
                DataPropertyName = "Dificultad_pedido_agreg",
                Width = 150
            });

            this.pedidosAgregacionDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Estado_pedido_agreg",
                HeaderText = "Estado del pedido",
                DataPropertyName = "Estado_pedido_agreg",
                Width = 150
            });
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            PedidoAgregacionDetalle pedidoAgregacionDetalle = new PedidoAgregacionDetalle();
            PedidoAgregacionDTO pedidoAgregacionNueva = new PedidoAgregacionDTO();

            pedidoAgregacionDetalle.Mode = FormMode.Add;
            pedidoAgregacionDetalle.PedidoAgregacion = pedidoAgregacionNueva;

            pedidoAgregacionDetalle.ShowDialog();
            this.GetAllAndLoad();
        }

        private async void modificarButton_Click(object sender, EventArgs e)
        {
            try
            {
                PedidoAgregacionDetalle pedidoAgregacionDetalle = new PedidoAgregacionDetalle();

                int id = this.SelectedItem().Id_pedido_agreg;

                PedidoAgregacionDTO pedidoAgregacion = await PedidoAgregacionApiClient.GetAsync(id);

                pedidoAgregacionDetalle.Mode = FormMode.Update;
                pedidoAgregacionDetalle.PedidoAgregacion = pedidoAgregacion;

                pedidoAgregacionDetalle.ShowDialog();

                this.GetAllAndLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar pedido de agregacion para modificar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void eliminarButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = this.SelectedItem().Id_pedido_agreg;

                var pedido = await PedidoAgregacionApiClient.GetAsync(id);

                var result = MessageBox.Show($"¿Está seguro que desea eliminar el pedido de agregacion con id {id}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    await PedidoAgregacionApiClient.DeleteAsync(id);
                    this.GetAllAndLoad();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el pedido de agregacion: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void GetAllAndLoad()
        {
            try
            {
                this.pedidosAgregacionDataGridView.DataSource = null;
                this.pedidosAgregacionDataGridView.DataSource = await PedidoAgregacionApiClient.GetAllAsync();

                if (this.pedidosAgregacionDataGridView.Rows.Count > 0)
                {
                    this.pedidosAgregacionDataGridView.Rows[0].Selected = true;
                    this.eliminarButton.Enabled = true;
                    this.modificarButton.Enabled = true;
                }
                else
                {
                    this.eliminarButton.Enabled = false;
                    this.modificarButton.Enabled = false;
                    this.buttonAceptar.Enabled = false;
                    this.buttonRechazar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la lista de pedidos de agregacion: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.eliminarButton.Enabled = false;
                this.modificarButton.Enabled = false;
            }
        }

        private async Task ValidarPermisosAsync()
        {
            var user = await AuthServiceProvider.Instance.GetCurrentUserAsync();

            if (user.Tipo_usu != "Operador" && user.Tipo_usu != "Cazador")
            {
                MessageBox.Show("No tenés permisos para acceder a pedidos de agregacion", "Acceso denegado");
                this.Close();
            }
        }

        private async void buttonAceptar_Click(object sender, EventArgs e)
        {
            var pedido = SelectedItem();

            pedido.Estado_pedido_agreg = "Aceptado";
            await PedidoAgregacionApiClient.UpdateAsync(pedido);

            TipoAnomaliaDTO tipo = new TipoAnomaliaDTO
            {
                Nombre_anom = pedido.Descripcion_pedido_agreg,
                Dif_anom = pedido.Dificultad_pedido_agreg
            };

            await TipoAnomaliaApiClient.AddAsync(tipo);

            GetAllAndLoad();
        }

        private async void buttonRechazar_Click(object sender, EventArgs e)
        {
            var pedido = SelectedItem();

            pedido.Estado_pedido_agreg = "Rechazado";
            await PedidoAgregacionApiClient.UpdateAsync(pedido);

            GetAllAndLoad();
        }

        private async Task ActualizarBotonesSegunUsuarioYPedido()
        {
            var user = await AuthServiceProvider.Instance.GetCurrentUserAsync();
            var pedido = SelectedItem();

            if (user.Tipo_usu == "Cazador")
            {
                buttonAceptar.Visible = false;
                buttonRechazar.Visible = false;
            }
            else if (user.Tipo_usu == "Operador")
            {
                buttonAceptar.Visible = true;
                buttonRechazar.Visible = true;

                if (pedido.Estado_pedido_agreg == "Pendiente")
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