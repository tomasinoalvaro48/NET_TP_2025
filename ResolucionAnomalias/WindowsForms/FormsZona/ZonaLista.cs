using DTOs;
using WindowsForms.FormsLocalidad;

namespace WindowsForms.FormsZona
{
    public partial class ZonaLista : Form
    {
        public ZonaLista()
        {
            InitializeComponent();
            ConfigurarColumas();
        }

        private void ZonaLista_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private ZonaDTO SelectedItem()
        {
            ZonaDTO zona;
            zona = (ZonaDTO)dataGridViewZonas.SelectedRows[0].DataBoundItem;
            return zona;
        }

        private void ConfigurarColumas()
        {
            this.dataGridViewZonas.AutoGenerateColumns = false;

            this.dataGridViewZonas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Id",
                HeaderText = "Id",
                DataPropertyName = "Id",
                Width = 150
            });

            this.dataGridViewZonas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Nombre",
                HeaderText = "Nombre",
                DataPropertyName = "Nombre",
                Width = 150
            });

            
            this.dataGridViewZonas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NombreLocalidad ",
                HeaderText = "Nombre Localidad",
                DataPropertyName = "LocalidadNombre",
                Width = 180
            });

            this.dataGridViewZonas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CodigoLocalidad",
                HeaderText = "Codigo Localidad",
                DataPropertyName = "LocalidadCodigo",
                Width = 180
            });
        }

        private async void GetAllAndLoad()
        {
            try
            {
                this.dataGridViewZonas.DataSource = null;
                this.dataGridViewZonas.DataSource = await ZonaApiLocalidad.GetAllAsync();

                if (this.dataGridViewZonas.Rows.Count > 0)
                {
                    this.dataGridViewZonas.Rows[0].Selected = true;
                    this.btnEliminar.Enabled = true;
                    this.btnModificar.Enabled = true;
                }
                else
                {
                    this.btnEliminar.Enabled = false;
                    this.btnModificar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar lista de zonas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.btnEliminar.Enabled = true;
                this.btnModificar.Enabled = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ZonaDetalle zonaDetalle = new ZonaDetalle();

            ZonaDTO zonaNueva = new ZonaDTO();

            zonaDetalle.Mode = FormMode.Add;
            zonaDetalle.Zona = zonaNueva;

            zonaDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = this.SelectedItem().Id;

                var result = MessageBox.Show($"¿Está seguro que desea eliminar la zona con ID {id}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    await ZonaApiLocalidad.DeleteAsync(id);
                    this.GetAllAndLoad();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar la zona: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                ZonaDetalle zonaDetalle = new ZonaDetalle();

                int id = this.SelectedItem().Id;

                ZonaDTO zona = await ZonaApiLocalidad.GetAsync(id);

                zonaDetalle.Mode = FormMode.Update;

                zonaDetalle.Zona = zona;

                zonaDetalle.ShowDialog();

                this.GetAllAndLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar zona para modificar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}