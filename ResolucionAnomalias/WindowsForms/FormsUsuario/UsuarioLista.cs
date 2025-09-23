using DTOs;
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

        private void UsuarioLista_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private UsuarioDTO SelectedItem()
        {
            UsuarioDTO usuario;
            usuario = (UsuarioDTO)usuariosDataGridView.SelectedRows[0].DataBoundItem;
            return usuario;
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

        private async void GetAllAndLoad()
        {
            try
            {
                this.usuariosDataGridView.DataSource = null;
                this.usuariosDataGridView.DataSource = await UsuarioApiClient.GetAllAsync();

                if (this.usuariosDataGridView.Rows.Count > 0)
                {
                    this.usuariosDataGridView.Rows[0].Selected = true;
                    this.eliminarButton.Enabled = true;
                    this.modificarButton.Enabled = true;
                }
                else
                {
                    this.eliminarButton.Enabled = false;
                    this.modificarButton.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar lista de usuarios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.eliminarButton.Enabled = true;
                this.modificarButton.Enabled = true;
            }
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            UsuarioDetalle usuarioDetalle = new UsuarioDetalle();

            UsuarioDTO usuarioNuevo = new UsuarioDTO();

            usuarioDetalle.Mode = FormMode.Add;
            usuarioDetalle.Usuario = usuarioNuevo;

            usuarioDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void eliminarButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = this.SelectedItem().Cod_usu;

                var result = MessageBox.Show($"¿Está seguro que desea eliminar el usuario con ID {id}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    await UsuarioApiClient.DeleteAsync(id);
                    this.GetAllAndLoad();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async void modificarButton_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioDetalle usuarioDetalle = new UsuarioDetalle();

                int id = this.SelectedItem().Cod_usu;

                UsuarioDTO usuario = await UsuarioApiClient.GetAsync(id);

                usuarioDetalle.Mode = FormMode.Update;

                usuarioDetalle.Usuario = usuario;

                usuarioDetalle.ShowDialog();

                this.GetAllAndLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar usuario para modificar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}