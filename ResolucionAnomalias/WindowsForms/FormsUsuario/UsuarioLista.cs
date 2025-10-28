using DTOs;
using API.Clients.EntitiesClients;
using API.Clients;

namespace WindowsForms.FormsUsuario
{
    public partial class UsuarioLista : Form
    {
        public UsuarioLista()
        {
            InitializeComponent();
            ConfigurarColumas();
        }

        private async void UsuarioLista_Load(object sender, EventArgs e)
        {
            await ValidarPermisosAsync();
            await GetAllAndLoad();
        }

        private void ConfigurarColumas()
        {
            this.usuariosDataGridView.AutoGenerateColumns = false;

            this.usuariosDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Cod_usu",
                HeaderText = "Id",
                DataPropertyName = "Cod_usu",
                Width = 150
            });

            this.usuariosDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Nombre_usu",
                HeaderText = "Nombre",
                DataPropertyName = "Nombre_usu",
                Width = 150
            });

            this.usuariosDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Email_usu",
                HeaderText = "Email",
                DataPropertyName = "Email_usu",
                Width = 150
            });

            this.usuariosDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Tipo_usu",
                HeaderText = "Tipo",
                DataPropertyName = "Tipo_usu",
                Width = 150
            });

            this.usuariosDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "LocalidadCodigo",
                HeaderText = "Codigo Localidad",
                DataPropertyName = "LocalidadCodigo",
                Width = 180
            });

            this.usuariosDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "LocalidadNombre",
                HeaderText = "Nombre Localidad",
                DataPropertyName = "LocalidadNombre",
                Width = 180
            });

            this.usuariosDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ZonaNombre",
                HeaderText = "Nombre Zona",
                DataPropertyName = "ZonaNombre",
                Width = 180
            });
        }

        private async Task GetAllAndLoad()
        {
            try
            {
                this.usuariosDataGridView.DataSource = null;
                this.usuariosDataGridView.DataSource = await UsuarioApiClient.GetAllAsync();

                if (this.usuariosDataGridView.Rows.Count > 0)
                    this.usuariosDataGridView.Rows[0].Selected = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar lista de usuarios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task ValidarPermisosAsync()
        {
            var user = await AuthServiceProvider.Instance.GetCurrentUserAsync();

            if (user.Tipo_usu != "Operador")
            {
                MessageBox.Show("No tenés permisos para acceder a Usuarios", "Acceso denegado");
                this.Close();
            }
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            string texto = this.buscarTextBox.Text.Trim();
            _ = GetByCriteriaAndLoad(texto); // Ignorar el warning del async void
        }

        private async Task GetByCriteriaAndLoad(string texto = "")
        {
            this.usuariosDataGridView.DataSource = null;

            IEnumerable<UsuarioDTO> usuarios;
            if (string.IsNullOrWhiteSpace(texto))
            {
                usuarios = await UsuarioApiClient.GetAllAsync();
            }
            else
            {
                usuarios = await UsuarioApiClient.GetByCriteriaAsync(texto);
            }

            this.usuariosDataGridView.DataSource = usuarios;

            if (this.usuariosDataGridView.Rows.Count > 0)
                this.usuariosDataGridView.Rows[0].Selected = true;
        }
    }
}