using DTOs;

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
    }
}
