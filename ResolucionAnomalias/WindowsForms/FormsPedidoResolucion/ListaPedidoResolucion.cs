using API.Clients.EntitiesClients;
using DTOs;
using API.Clients; 
namespace WindowsForms.FormsPedidoResolucion
{
    public partial class ListaPedidoResolucion : Form
    {
        public ListaPedidoResolucion()
        {
            InitializeComponent();
            ConfigurarColumnas();
        }

        private void DataGridViewPedidos_SelectionChanged(object sender, EventArgs e)
        {
            bool hasSelection = dataGridViewPedidos.SelectedRows.Count > 0;
            if (hasSelection)
            {
                var pedido = this.SelectedItem();
                if (pedido.Estado == "finalizado")
                {
                    if (buttonEliminar.Visible) buttonEliminar.Enabled = false;
                    if (buttonModificar.Visible)
                    {
                        buttonModificar.Enabled = false;
                        buttonModificar.Text = "Tomar Pedido";
                    }
                    if (buttonFinalizarPedido.Visible) buttonFinalizarPedido.Enabled = false;
                }
                else if (pedido.Estado == "aceptado")
                {
                    if (buttonEliminar.Visible) buttonEliminar.Enabled = false;
                    if (buttonModificar.Visible)
                    {
                        buttonModificar.Enabled = true;
                        buttonModificar.Text = "Modificar Comentario";
                    }
                    if (buttonFinalizarPedido.Visible) buttonFinalizarPedido.Enabled = true;
                }
                else
                {
                    if (buttonEliminar.Visible) buttonEliminar.Enabled = true;
                    if (buttonFinalizarPedido.Visible) buttonFinalizarPedido.Enabled = false;
                    if (buttonModificar.Visible)
                    {
                        buttonModificar.Enabled = true;
                        buttonModificar.Text = "Tomar Pedido";
                    }
                }
            }
        }

        private void DataGridViewPedidos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewPedidos.Rows)
            {
                if (row.DataBoundItem is PedidoResolucionDTO pedido)
                {
                    if (string.Equals(pedido.Estado, "finalizado", StringComparison.OrdinalIgnoreCase))
                    {
                        row.DefaultCellStyle.BackColor = Color.LightCoral;
                    }
                    else if (string.Equals(pedido.Estado, "aceptado", StringComparison.OrdinalIgnoreCase))
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.White;
                    }
                }
            }
        }

        private void ConfigurarColumnas()
        {
            this.dataGridViewPedidos.Columns.Clear();
            this.dataGridViewPedidos.Width = 1600;
            this.dataGridViewPedidos.AutoGenerateColumns = false;
            this.dataGridViewPedidos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Id",
                HeaderText = "ID Pedido",
                Width = 100
            });
            this.dataGridViewPedidos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Descripcion",
                HeaderText = "Descripción",
                Width = 300
            });
            this.dataGridViewPedidos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Fecha",
                HeaderText = "Fecha de Creación",
                Width = 150
            });
            this.dataGridViewPedidos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Estado",
                HeaderText = "Estado",
                Width = 100
            });

            this.dataGridViewPedidos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Dificultad",
                HeaderText = "Dificultad",
                Width = 100
            });
            this.dataGridViewPedidos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Direccion",
                HeaderText = "Dirección",
                Width = 100
            });
            this.dataGridViewPedidos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "DenuncianteNombre",
                HeaderText = "Denunciante",
                Width = 150
            });

            this.dataGridViewPedidos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "ZonaNombre",
                HeaderText = "Zona",
                Width = 150
            });
            this.dataGridViewPedidos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "CazadorNombre",
                HeaderText = "Cazador",
                Width = 150
            });
            this.dataGridViewPedidos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Comentario",
                HeaderText = "Comentario",
                Width = 200
            });
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
                string estado = this.SelectedItem().Estado;
                if (string.Equals(estado, "finalizado", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("No se puede modificar un pedido finalizado.", "Acción no permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

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

        private async void ListaPedidoResolucion_Load(object sender, EventArgs e)
        {
            await SetButtonsByRoleAsync();
            this.LoadPedidos();
        }

        private async Task SetButtonsByRoleAsync()
        {
            var user = await AuthServiceProvider.Instance.GetCurrentUserAsync();

            // Defaults ocultar todo
            buttonAgregar.Visible = false;
            buttonEliminar.Visible = false;
            buttonModificar.Visible = false;
            if (this.buttonFinalizarPedido != null)
            {
                buttonFinalizarPedido.Visible = false;
                buttonFinalizarPedido.Enabled = false;
            }

            if (user == null)
                return;

            if (string.Equals(user.Tipo_usu, "Denunciante", StringComparison.OrdinalIgnoreCase))
            {
                buttonAgregar.Visible = true;
                buttonAgregar.Enabled = true;
                buttonEliminar.Visible = true;
                buttonModificar.Visible = false;
                if (this.buttonFinalizarPedido != null)
                {
                    buttonFinalizarPedido.Visible = false;
                }
            }
            else if (string.Equals(user.Tipo_usu, "Cazador", StringComparison.OrdinalIgnoreCase))
            {
                buttonModificar.Visible = true;
                buttonAgregar.Visible = false;
                buttonEliminar.Visible = false;
                if (this.buttonFinalizarPedido != null)
                {
                    buttonFinalizarPedido.Visible = true;
                    buttonFinalizarPedido.Enabled = true;
                }
            }
            else
            {
                buttonAgregar.Visible = true;
                buttonEliminar.Visible = true;
                buttonModificar.Visible = true;
                if (this.buttonFinalizarPedido != null)
                {
                    // Operador/otros no pueden finalizar (según requerimiento solo cazador asignado)
                    buttonFinalizarPedido.Visible = false;
                }
            }
        }

        private async void LoadPedidos()
        {
            try
            {
                this.dataGridViewPedidos.DataSource = null;

                var user = await AuthServiceProvider.Instance.GetCurrentUserAsync();

                IEnumerable<PedidoResolucionDTO> pedidos;

                if (user != null && string.Equals(user.Tipo_usu, "Denunciante", StringComparison.OrdinalIgnoreCase))
                {
                    // Mostrar solo pedidos del denunciante actual
                    pedidos = await PedidoResolucionApiClient.GetAllByDenuncianteAsync(user.Cod_usu);
                }
                else
                {
                    pedidos = await PedidoResolucionApiClient.GetAllAsync();
                }

                this.dataGridViewPedidos.DataSource = pedidos;

                bool hasRows = this.dataGridViewPedidos.Rows.Count > 0;

                if (hasRows)
                {
                    this.dataGridViewPedidos.Rows[0].Selected = true;
                }

                if (buttonEliminar.Visible) buttonEliminar.Enabled = hasRows;
                if (buttonModificar.Visible) buttonModificar.Enabled = hasRows;
                if (buttonAgregar.Visible) buttonAgregar.Enabled = true;
                if (buttonFinalizarPedido.Visible) buttonFinalizarPedido.Enabled = hasRows;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar pedidos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (buttonEliminar.Visible) buttonEliminar.Enabled = false;
                if (buttonModificar.Visible) buttonModificar.Enabled = false;
                if (buttonFinalizarPedido.Visible) buttonFinalizarPedido.Enabled = false;
            }
        }

        private PedidoResolucionDTO SelectedItem()
        {
            PedidoResolucionDTO pedido = (PedidoResolucionDTO)dataGridViewPedidos.SelectedRows[0].DataBoundItem;
            return pedido;
        }

        private async void buttonFinalizarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                var pedido = this.SelectedItem();

                if (pedido == null)
                {
                    MessageBox.Show("Seleccione un pedido.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var user = await AuthServiceProvider.Instance.GetCurrentUserAsync();
                if (user == null || !string.Equals(user.Tipo_usu, "Cazador", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Solo un cazador asignado puede finalizar el pedido.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!pedido.CazadorId.HasValue)
                {
                    MessageBox.Show("El pedido no está asignado a ningún cazador.", "Acción no permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (pedido.CazadorId.Value != user.Cod_usu)
                {
                    MessageBox.Show("Solo el cazador asignado puede finalizar este pedido.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.Equals(pedido.Estado, "Finalizado", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("El pedido ya está finalizado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var confirmar = MessageBox.Show(
                    $"¿Desea finalizar el pedido {pedido.Id}?",
                    "Finalizar pedido",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmar != DialogResult.Yes)
                    return;

                await PedidoResolucionApiClient.FinalizarAsync(pedido.Id);

                MessageBox.Show("Pedido finalizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.LoadPedidos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al finalizar el pedido: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}