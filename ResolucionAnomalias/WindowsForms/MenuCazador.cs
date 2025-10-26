using API.Clients;
using WindowsForms.FormsPedidoAgregacion;
using WindowsForms.FormsTipoAnomalia;
using WindowsForms.FormsUsuario;
using WindowsForms.FormsZona;

namespace WindowsForms
{
    public partial class MenuCazador : Form
    {
        public MenuCazador()
        {
            InitializeComponent();
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

        private void ButtonCRUDTipoAnomalia_Click(object sender, EventArgs e)
        {
            TipoAnomaliaLista tipoLista = new TipoAnomaliaLista();
            tipoLista.ShowDialog();
        }

        private void ButtonCRUDUsuario_Click(object sender, EventArgs e)
        {
            UsuarioLista usuarioLista = new UsuarioLista();
            usuarioLista.ShowDialog();
        }

        private void pedidoAgregacionButton_Click(object sender, EventArgs e)
        {
            PedidoAgregacionLista pedidoAgregacionLista = new PedidoAgregacionLista();
            pedidoAgregacionLista.ShowDialog();
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

        private void realizarPedidoAgregacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PedidoAgregacionLista pedidoAgregacionLista = new PedidoAgregacionLista();
            pedidoAgregacionLista.ShowDialog();
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
    }
}