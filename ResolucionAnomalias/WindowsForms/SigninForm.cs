using API.Clients.EntitiesClients;
using DTOs;
using System.Text.RegularExpressions;

namespace WindowsForms
{
    public partial class SigninForm : Form
    {
        public UsuarioDTO Usuario { get; set; }
        public SigninForm()
        {
            InitializeComponent();
            Usuario = new UsuarioDTO();
            LoadLocalidades();
        }
        private async void LoadLocalidades()
        {
            try
            {
                zonaComboBox.Enabled = false;
                var localidades = await LocalidadApiClient.GetAllAsync();
                localidadComboBox.DataSource = localidades.ToList();
                localidadComboBox.DisplayMember = "Nombre";
                localidadComboBox.ValueMember = "ID";
                localidadComboBox.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar localidades: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateUsuario()
        {
            bool isValid = true;
            errorProvider.SetError(nombreTextBox, string.Empty);
            errorProvider.SetError(emailTextBox, string.Empty);
            errorProvider.SetError(contraseniaTextBox, string.Empty);
            errorProvider.SetError(localidadComboBox, string.Empty);
            errorProvider.SetError(zonaComboBox, string.Empty);

            if (this.nombreTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(nombreTextBox, "El nombre es requerido");
            }
            else if (!Regex.IsMatch(nombreTextBox.Text, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$"))
            {
                isValid = false;
                errorProvider.SetError(nombreTextBox, "El nombre no puede tener números");
            }

            if (this.emailTextBox.Text == string.Empty || !Regex.IsMatch(emailTextBox.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                isValid = false;
                errorProvider.SetError(emailTextBox, "Debe ingresar un email válido");
            }

            if (this.contraseniaTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(contraseniaTextBox, "La contraseña es requerida");
            }
            else if (contraseniaTextBox.Text.Length < 6)
            {
                isValid = false;
                errorProvider.SetError(contraseniaTextBox, "La contraseña debe tener mínimo 6 caracteres");
            }

            if (localidadComboBox.SelectedValue == null)
            {
                isValid = false;
                errorProvider.SetError(localidadComboBox, "Debe seleccionar una localidad");
            }

            if (zonaComboBox.SelectedValue == null)
            {
                isValid = false;
                errorProvider.SetError(zonaComboBox, "Debe seleccionar una zona");
            }

            return isValid;
        }
        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void registrarseButon_Click(object sender, EventArgs e)
        {
            if (this.ValidateUsuario())
            {
                try
                {
                    this.Usuario.Nombre_usu = nombreTextBox.Text;
                    this.Usuario.Email_usu = emailTextBox.Text;
                    this.Usuario.Passw_usu = contraseniaTextBox.Text;
                    this.Usuario.Tipo_usu = "Cazador";
                    this.Usuario.LocalidadId = (int)localidadComboBox.SelectedValue;
                    this.Usuario.ZonaId = (int)zonaComboBox.SelectedValue;

                    await UsuarioApiClient.AddAsync(this.Usuario);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void localidadSeleccionada(object sender, EventArgs e)
        {
            try { 
                if (localidadComboBox.SelectedValue == null || localidadComboBox.SelectedIndex == -1)
                    return; // No hay selección válida todavía

                // A veces SelectedValue devuelve DataRowView
                if (localidadComboBox.SelectedValue is int localidadId)
                {
                    var zonas = await ZonaApiClient.GetByLocalidadAsync(localidadId);
                    zonaComboBox.DataSource = zonas.ToList();
                    zonaComboBox.DisplayMember = "Nombre";
                    zonaComboBox.ValueMember = "ID";
                    zonaComboBox.SelectedIndex = -1;
                    zonaComboBox.Enabled = true;
                }
            } catch (Exception ex) {
            MessageBox.Show($"Error al cargar zonas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
