using System.Text.RegularExpressions;
using DTOs;
using API.Clients.EntitiesClients;
using API.Clients;
using System.Windows.Forms;

namespace WindowsForms.FormsPedidoAgregacion
{
    public enum FormMode
    {
        Add,
        Update
    }

    public partial class PedidoAgregacionDetalle : Form
    {
        private PedidoAgregacionDTO pedidoAgregacion;
        private FormMode mode;

        public PedidoAgregacionDTO PedidoAgregacion
        {
            get { return pedidoAgregacion; }
            set
            {
                pedidoAgregacion = value;
                this.SetPedidoAgregacion();
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
                SerFormMode(value);
            }
        }

        public PedidoAgregacionDetalle()
        {
            InitializeComponent();
            Mode = FormMode.Add;

            ValidarPermisos();
        }

        private async void aceptarButton_Click(object sender, EventArgs e)
        {
            if (this.ValidatePedidoAgregacion())
            {
                try
                {
                    this.PedidoAgregacion.Descripcion_pedido_agreg = descripcionTextBox.Text;
                    this.PedidoAgregacion.Dificultad_pedido_agreg = int.Parse(dificultadComboBox.SelectedItem.ToString());

                    if (this.Mode == FormMode.Update)
                    {
                        await PedidoAgregacionApiClient.UpdateAsync(this.PedidoAgregacion);
                    }
                    else
                    {
                        // Asignar el cazador logueado al crear
                        var currentUser = await AuthServiceProvider.Instance.GetCurrentUserAsync();
                        if (currentUser == null)
                        {
                            MessageBox.Show("Sesión inválida. Inicie sesión nuevamente.", "Sesión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        this.PedidoAgregacion.CazadorId = currentUser.Cod_usu;
                        this.PedidoAgregacion.Estado_pedido_agreg = "Pendiente";

                        await PedidoAgregacionApiClient.AddAsync(this.PedidoAgregacion);
                    }

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetPedidoAgregacion()
        {
            this.idTextBox.Text = this.PedidoAgregacion.Id_pedido_agreg.ToString();
            this.descripcionTextBox.Text = this.PedidoAgregacion.Descripcion_pedido_agreg;
            this.dificultadComboBox.SelectedItem = this.PedidoAgregacion.Dificultad_pedido_agreg.ToString();
            this.estadoTextBox.Text = this.PedidoAgregacion.Estado_pedido_agreg;
        }

        private void SerFormMode(FormMode value)
        {
            mode = value;
            if (mode == FormMode.Add)
            {
                idLabel.Visible = false;
                idTextBox.Visible = false;
                descripcionLabel.Visible = true;
                descripcionTextBox.Visible = true;
                dificultadLabel.Visible = true;
                dificultadComboBox.Visible = true;
                estadoLabel.Visible = false;
                estadoTextBox.Visible = false;
            }
            if (mode == FormMode.Update)
            {
                idLabel.Visible = true;
                idTextBox.Visible = true;
                descripcionLabel.Visible = true;
                descripcionTextBox.Visible = true;
                dificultadLabel.Visible = true;
                dificultadComboBox.Visible = true;
                estadoLabel.Visible = true;
                estadoTextBox.Visible = true;
            }

        }

        private bool ValidatePedidoAgregacion()
        {
            bool valid = true;
            errorProvider.SetError(descripcionTextBox, string.Empty);
            errorProvider.SetError(dificultadComboBox, string.Empty);

            if (this.descripcionTextBox.Text == string.Empty)
            {
                valid = false;
                errorProvider.SetError(descripcionTextBox, "La descripcíón es requerida");
            }

            if (dificultadComboBox.SelectedItem == null)
            {
                valid = false;
                errorProvider.SetError(dificultadComboBox, "La dificultad es requerida");
            }

            return valid;
        }

        private async void ValidarPermisos()
        {
            var user = await AuthServiceProvider.Instance.GetCurrentUserAsync();

            if (user.Tipo_usu != "Operador" && user.Tipo_usu != "Cazador")
            {
                MessageBox.Show("No tenés permisos para editar pedidos de agregación", "Acceso denegado");
                this.Close();
                return;
            }
        }
    }
}