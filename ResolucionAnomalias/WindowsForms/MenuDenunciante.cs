using API.Clients;
using WindowsForms.FormsTipoAnomalia;
using WindowsForms.FormsUsuario;
using WindowsForms.FormsZona;

namespace WindowsForms
{
    public partial class MenuDenunciante : Form
    {
        public MenuDenunciante()
        {
            InitializeComponent();
        }

        private void ButtonCRUDTipoAnomalia_Click(object sender, EventArgs e)
        {
            TipoAnomaliaLista tipoLista = new TipoAnomaliaLista();
            tipoLista.ShowDialog();
        }

        private void ButtonCRUDLocalidad_Click(object sender, EventArgs e)
        {
            LocalidadLista localidadLista = new LocalidadLista();
            localidadLista.ShowDialog();
        }

        private void btnCrudZona_Click(object sender, EventArgs e)
        {
            ZonaLista zonaLista = new ZonaLista();
            zonaLista.ShowDialog();
        }

        private void ButtonCRUDUsuario_Click(object sender, EventArgs e)
        {
            UsuarioLista usuarioLista = new UsuarioLista();
            usuarioLista.ShowDialog();
        }

        private async void logoutButton_Click(object sender, EventArgs e)
        {
            await AuthServiceProvider.Instance.LogoutAsync();
            AuthServiceProvider.Instance.ClearSession();

            this.Hide();

            var login = new LoginForm();
            login.ShowDialog();

            this.Close();
        }

        private async void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await AuthServiceProvider.Instance.LogoutAsync();
            AuthServiceProvider.Instance.ClearSession();

            this.Hide();

            var login = new LoginForm();
            login.ShowDialog();

            this.Close();
        }

        private void realizarPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}