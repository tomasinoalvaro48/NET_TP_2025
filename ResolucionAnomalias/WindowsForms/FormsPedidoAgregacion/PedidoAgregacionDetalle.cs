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
                    this.PedidoAgregacion.Dificultad_pedido_agreg = int.Parse(dificultadTextBox.Text);
                    this.PedidoAgregacion.Estado_pedido_agreg = estadoTextBox.Text;

                    if (this.Mode == FormMode.Update)
                    {
                        await PedidoAgregacionApiClient.UpdateAsync(this.PedidoAgregacion);
                    }
                    else
                    {
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
            this.dificultadTextBox.Text = this.PedidoAgregacion.Dificultad_pedido_agreg.ToString();
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
                dificultadTextBox.Visible = true;
                estadoLabel.Visible = true;
                estadoTextBox.Visible = true;
            }
            if (mode == FormMode.Update)
            {
                idLabel.Visible = true;
                idTextBox.Visible = true;
                descripcionLabel.Visible = true;
                descripcionTextBox.Visible = true;
                dificultadLabel.Visible = true;
                dificultadTextBox.Visible = true;
                estadoLabel.Visible = true;
                estadoTextBox.Visible = true;
            }

        }

        private bool ValidatePedidoAgregacion()
        {
            bool valid = true;
            errorProvider.SetError(descripcionTextBox, string.Empty);
            errorProvider.SetError(dificultadTextBox, string.Empty);
            errorProvider.SetError(estadoTextBox, string.Empty);

            if (this.descripcionTextBox.Text == string.Empty)
            {
                valid = false;
                errorProvider.SetError(descripcionTextBox, "La descripcíón es requerida");
            }

            if (this.dificultadTextBox.Text == string.Empty)
            {
                valid = false;
                errorProvider.SetError(dificultadTextBox, "La dificultad es requerida");
            }
            else if (!Regex.IsMatch(dificultadTextBox.Text, @"^\d+$"))
            {
                valid = false;
                errorProvider.SetError(dificultadTextBox, "La dificultad no puede tener letras ni espacios");
            }

            if (this.estadoTextBox.Text == string.Empty)
            {
                valid = false;
                errorProvider.SetError(estadoTextBox, "El estado es requerido");
            }
            else if (!Regex.IsMatch(estadoTextBox.Text, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$"))
            {
                valid = false;
                errorProvider.SetError(estadoTextBox, "El estado no puede tener números");
            }

            return valid;
        }

        private async void ValidarPermisos()
        {
            var user = await AuthServiceProvider.Instance.GetCurrentUserAsync();

            if (user.Tipo_usu != "Operador" && user.Tipo_usu != "Cazador")
            {
                MessageBox.Show("No tenés permisos para editar pedidos de aregacion", "Acceso denegado");
                this.Close();
            }
        }
    }
}