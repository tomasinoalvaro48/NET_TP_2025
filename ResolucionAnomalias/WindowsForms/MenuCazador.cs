using API.Clients;
using WindowsForms.FormsPedidoAgregacion;
using WindowsForms.FormsPedidoResolucion;

namespace WindowsForms
{
    public partial class MenuCazador : Form
    {
        private bool CierreManual = true;
        public MenuCazador()
        {
            InitializeComponent();
            MostrarPaginaInicio();
        }

        private void MostrarPaginaInicio()
        {
            panelContent.Controls.Clear();
            panelContent.Controls.Add(buttonVolver);
            panelContent.Controls.Add(label1);
            panelContent.Controls.Add(buttonTomarPedido);
            panelContent.Controls.Add(buttonPedidoAgregacion);
            buttonVolver.Visible = false;
        }

        private void CargarFormularioEnPanel(Form formulario)
        {
            panelContent.Controls.Clear();
            panelContent.Controls.Add(buttonVolver);
            buttonVolver.Visible = true;
            buttonVolver.BringToFront();
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            panelContent.Controls.Add(formulario);
            formulario.Show();
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            foreach (Control control in panelContent.Controls.OfType<Form>().ToList())
            {
                control.Dispose();
            }
            MostrarPaginaInicio();
        }

        private async void logoutButton_Click(object sender, EventArgs e)
        {
            await AuthServiceProvider.Instance.LogoutAsync();
            //AuthServiceProvider.Instance.ClearSession();

            CierreManual = false;
            this.Close();
        }

        private void tomarPedidoDeResoluciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pedidoLista = new ListaPedidoResolucion();
            pedidoLista.FormClosed += (s, args) => {
                MostrarPaginaInicio();
            };
            CargarFormularioEnPanel(pedidoLista);
        }

        private void realizarPedidoAgregacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pedidoAgregacionLista = new PedidoAgregacionLista();
            pedidoAgregacionLista.FormClosed += (s, args) => {
                MostrarPaginaInicio();
            };
            CargarFormularioEnPanel(pedidoAgregacionLista);
        }

        private async void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await AuthServiceProvider.Instance.LogoutAsync();
            //AuthServiceProvider.Instance.ClearSession();

            CierreManual = false;
            this.Close();
        }

        private async void MenuCazador_FormClosing(object sender, FormClosingEventArgs e)
        {
            // usuario cerró con la cruz:
            if (CierreManual && e.CloseReason == CloseReason.UserClosing)
            {
                // Cancelar el cierre temporalmente para mostrar el diálogo
                e.Cancel = true;

                string message = "¿Cerrar sesión y salir de la aplicación?";
                string caption = "¿Desea cerrar sesión y salir de la aplicación?";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, caption, buttons);
                
                if (result == DialogResult.Yes)
                {
                    CierreManual = false;
                    
                    //logout
                    await AuthServiceProvider.Instance.LogoutAsync();
                    //AuthServiceProvider.Instance.ClearSession();

                    Application.Exit();
                }
            }
        }

        private void cambiarContrasenaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cambiarContrasenaUsuario = new CambiarContrasenaUsuario();
            cambiarContrasenaUsuario.FormClosed += (s, args) => {
                MostrarPaginaInicio();
            };
            CargarFormularioEnPanel(cambiarContrasenaUsuario);
        }

        private void buttonTomarPedido_Click(object sender, EventArgs e)
        {
            var pedidoResolucion = new ListaPedidoResolucion();
            pedidoResolucion.FormClosed += (s, args) => {
                MostrarPaginaInicio();
            };
            CargarFormularioEnPanel(pedidoResolucion);
        }
    }
}