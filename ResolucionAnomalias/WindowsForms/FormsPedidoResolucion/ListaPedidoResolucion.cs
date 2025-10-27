using API.Clients.EntitiesClients;
using DTOs;

namespace WindowsForms.FormsPedidoResolucion
{
    public partial class ListaPedidoResolucion : Form
    {
        public ListaPedidoResolucion()
        {
            InitializeComponent();

        }


        private async void buttonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                PedidoResolucionDTO pedido = this.SelectedItem();

                var result = MessageBox.Show($"¿Está seguro que desea eliminar el pedido {pedido.Id}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    await PedidoResolucionApiClient.DeleteAsync(pedido.Id);
                    this.LoadPedidos();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async void buttonModificar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = this.SelectedItem().Id;
                PedidoResolucionDTO pedido = await PedidoResolucionApiClient.GetAsync(id);
                DetallePedidoResolucion pedidoDetalle = new DetallePedidoResolucion(FormMode.Update, pedido);
                pedidoDetalle.ShowDialog();
                this.LoadPedidos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            PedidoResolucionDTO pedidoNuevo = new PedidoResolucionDTO();
            DetallePedidoResolucion pedidoDetalle = new DetallePedidoResolucion(FormMode.Add, pedidoNuevo);

            pedidoDetalle.ShowDialog();

            this.LoadPedidos();
        }

        private void ListaPedidoResolucion_Load(object sender, EventArgs e)
        {
            this.LoadPedidos();
        }

        private async void LoadPedidos()
        {
            this.dataGridViewPedidos.DataSource = null;

            IEnumerable<PedidoResolucionDTO> pedidos = await PedidoResolucionApiClient.GetAllAsync();

            this.dataGridViewPedidos.DataSource = pedidos;

            if (this.dataGridViewPedidos.Rows.Count > 0)
            {
                this.dataGridViewPedidos.Rows[0].Selected = true;
                this.buttonEliminar.Enabled = true;
                this.buttonModificar.Enabled = true;
            }
            else
            {
                this.buttonEliminar.Enabled = false;
                this.buttonModificar.Enabled = false;
            }
        }

        private PedidoResolucionDTO SelectedItem()
        {
            PedidoResolucionDTO pedido;

            pedido = (PedidoResolucionDTO)dataGridViewPedidos.SelectedRows[0].DataBoundItem;
            return pedido;
        }
    }
}