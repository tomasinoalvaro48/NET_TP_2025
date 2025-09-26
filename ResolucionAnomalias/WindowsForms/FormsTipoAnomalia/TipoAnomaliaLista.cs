using DTOs;
using API.Clients.EntitiesClients;

namespace WindowsForms.FormsTipoAnomalia
{
    public partial class TipoAnomaliaLista : Form
    {
        public TipoAnomaliaLista()
        {
            InitializeComponent();
        }

        private async void GetAllAndLoad()
        {
            try
            {
                this.dataGridViewTiposAnomalia.DataSource = null;
                this.dataGridViewTiposAnomalia.DataSource = await TipoAnomaliaApiClient.GetAllAsync();

                if (this.dataGridViewTiposAnomalia.Rows.Count > 0)
                {
                    this.dataGridViewTiposAnomalia.Refresh();
                    this.buttonEliminarListTipo.Enabled = true;
                    this.buttonModificarListTipo.Enabled = true;
                }
                else
                {
                    this.buttonEliminarListTipo.Enabled = false;
                    this.buttonModificarListTipo.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la lista de tipos de anomalia: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.buttonEliminarListTipo.Enabled = false;
                this.buttonModificarListTipo.Enabled = false;
            }
        }

        private void TipoAnomalia_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private TipoAnomaliaDTO SelectedItem()
        {
            TipoAnomaliaDTO tipo;

            tipo = (TipoAnomaliaDTO)dataGridViewTiposAnomalia.SelectedRows[0].DataBoundItem;

            return tipo;
        }

        private async void buttonEliminarListTipo_Click(object sender, EventArgs e)
        {
            try
            {
                int id = this.SelectedItem().Cod_anom;

                var result = MessageBox.Show($"¿Está seguro que desea eliminar el Tipo de Anomalia con código: {id}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    await TipoAnomaliaApiClient.DeleteAsync(id);
                    this.GetAllAndLoad();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el Tipo de Anomalia: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAgregarListTipoAnomalia_Click(object sender, EventArgs e)
        {
            try
            {
                TipoAnomaliaDetalle tipoDetalle = new TipoAnomaliaDetalle();

                TipoAnomaliaDTO tipoNuevo = new TipoAnomaliaDTO();

                tipoDetalle.Mode = FormMode.Add;
                tipoDetalle.Tipo = tipoNuevo;

                tipoDetalle.ShowDialog();

                this.GetAllAndLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar tipo de anomalia: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void buttonModificarListTipo_Click(object sender, EventArgs e)
        {
            try
            {
                TipoAnomaliaDetalle tipoDetalle = new TipoAnomaliaDetalle();

                int id = this.SelectedItem().Cod_anom;

                TipoAnomaliaDTO tipo = await TipoAnomaliaApiClient.GetAsync(id);

                tipoDetalle.Mode = FormMode.Update;
                tipoDetalle.Tipo = tipo;

                tipoDetalle.ShowDialog();

                this.GetAllAndLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar tipo de anomalia para modificar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}