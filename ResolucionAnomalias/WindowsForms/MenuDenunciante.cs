using API.Clients;
using WindowsForms.FormsPedidoResolucion;
using WindowsForms.FormsTipoAnomalia;
using WindowsForms.FormsUsuario;
using WindowsForms.FormsZona;

namespace WindowsForms
{
    public partial class MenuDenunciante : Form
    {
        private bool CierreManual = true;
        public MenuDenunciante()
        {
            InitializeComponent();
            // this.FormClosing += MenuDenunciante_FormClosing;
        }

        private async void logoutButton_Click(object sender, EventArgs e)
        {
            await AuthServiceProvider.Instance.LogoutAsync();
            AuthServiceProvider.Instance.ClearSession();

            this.Hide();

            var login = new LoginForm();

            CierreManual = false;
            this.Close();
            login.ShowDialog();
        }

        private void realizarPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaPedidoResolucion pedidoLista = new ListaPedidoResolucion();
            pedidoLista.ShowDialog();
        }

        private async void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await AuthServiceProvider.Instance.LogoutAsync();
            AuthServiceProvider.Instance.ClearSession();

            this.Hide();

            var login = new LoginForm();
            login.ShowDialog();

            CierreManual = false;
            this.Close();
        }

        private async void MenuDenunciante_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Si el usuario cerró con la X
            if (CierreManual && e.CloseReason == CloseReason.UserClosing)
            {
                // Initializes the variables to pass to the MessageBox.Show method.
                string message = "¿Cerrar sesión y salir de la aplicación?";
                string caption = "¿Desea cerrar sesión y salir de la aplicación?";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, caption, buttons);
                if (result == DialogResult.Yes)
                {
                    await AuthServiceProvider.Instance.LogoutAsync();
                    AuthServiceProvider.Instance.ClearSession();

                    Application.Exit();
                }
            }
        }
    }
}