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
            ListaPedidoResolucion pedidoLista = new ListaPedidoResolucion();
            pedidoLista.ShowDialog();
        }

        private void realizarPedidoAgregacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PedidoAgregacionLista pedidoAgregacionLista = new PedidoAgregacionLista();
            pedidoAgregacionLista.ShowDialog();
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
            CambiarContrasenaUsuario cambiarContrasenaUsuario = new CambiarContrasenaUsuario();
            cambiarContrasenaUsuario.ShowDialog();
        }

        private void buttonTomarPedido_Click(object sender, EventArgs e)
        {
            ListaPedidoResolucion pedidoResolucion = new ListaPedidoResolucion();
            pedidoResolucion.ShowDialog();
        }
    }
}