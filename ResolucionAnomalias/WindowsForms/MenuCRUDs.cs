using DTOs;
using WindowsForms.FormsTipoAnomalia;
using WindowsForms.FormsZona;


namespace WindowsForms
{
    public partial class MenuCRUDs : Form
    {
        public MenuCRUDs()
        {
            InitializeComponent();
        }

        private void ButtonCRUDDenunciante_Click(object sender, EventArgs e)
        {
            DenunciantesLista denuncianteLista = new DenunciantesLista();
            //denuncianteLista.Activate();
            denuncianteLista.ShowDialog();
        }

        private void ButtonCRUDLocalidad_Click(object sender, EventArgs e)
        {
            LocalidadLista localidadLista = new LocalidadLista();
            //localidadLista.Activate();
            localidadLista.ShowDialog();
        }

        private void CloseProgram_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonCRUDTipoAnomalia_Click(object sender, EventArgs e)
        {
            TipoAnomaliaLista tipoLista = new TipoAnomaliaLista();
            //localidadLista.Activate();
            tipoLista.ShowDialog();
        }

        private void btnCrudZona_Click(object sender, EventArgs e)
        {
            ZonaLista zonaLista = new ZonaLista();
            zonaLista.ShowDialog();
        }
    }
}
