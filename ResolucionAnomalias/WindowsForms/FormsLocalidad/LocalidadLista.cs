using DTOs;
using API.Clients;

namespace WindowsForms
{
    public partial class LocalidadLista : Form
    {
        public LocalidadLista()
        {
            InitializeComponent();
        }

        private void Localidades_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private LocalidadDTO SelectedItem()
        {
            LocalidadDTO localidad;

            localidad = (LocalidadDTO)dataGridViewLocalidades.SelectedRows[0].DataBoundItem;

            return localidad;
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            LocalidadDetalle localidadDetalle = new LocalidadDetalle();

            LocalidadDTO localidadNueva = new LocalidadDTO();

            localidadDetalle.Mode = FormMode.Add;
            localidadDetalle.Localidad = localidadNueva;

            localidadDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void modificarButton_Click(object sender, EventArgs e)
        {
            try
            {
                LocalidadDetalle localidadDetalle = new LocalidadDetalle();

                int id = this.SelectedItem().ID;

                LocalidadDTO localidad = await LocalidadApiClient.GetAsync(id);

                localidadDetalle.Mode = FormMode.Update;
                localidadDetalle.Localidad = localidad;

                localidadDetalle.ShowDialog();

                this.GetAllAndLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar localidad para modificar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void eliminarButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = this.SelectedItem().ID;

                var result = MessageBox.Show($"¿Está seguro que desea eliminar la localidad con ID {id}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    await LocalidadApiClient.DeleteAsync(id);
                    this.GetAllAndLoad();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar la localidad: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void GetAllAndLoad()
        {
            try
            {
                this.dataGridViewLocalidades.DataSource = null;
                this.dataGridViewLocalidades.DataSource = await LocalidadApiClient.GetAllAsync();

                if (this.dataGridViewLocalidades.Rows.Count > 0)
                {
                    this.dataGridViewLocalidades.Rows[0].Selected = true;
                    this.buttonEliminarListLoc.Enabled = true;
                    this.buttonModificarListLoc.Enabled = true;
                }
                else
                {
                    this.buttonEliminarListLoc.Enabled = false;
                    this.buttonModificarListLoc.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la lista de localidades: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.buttonEliminarListLoc.Enabled = false;
                this.buttonModificarListLoc.Enabled = false;
            }
        }

        private void dataGridViewLocalidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}