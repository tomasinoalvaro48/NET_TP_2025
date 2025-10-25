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

        private void CloseProgram_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}