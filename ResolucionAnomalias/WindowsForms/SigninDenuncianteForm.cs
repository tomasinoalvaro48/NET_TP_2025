using API.Clients.EntitiesClients;
using DTOs;
using System.Text.RegularExpressions;

namespace WindowsForms
{
    public partial class SigninDenuncianteForm : Form
    {
        public UsuarioDTO Usuario { get; set; }
        public SigninDenuncianteForm()
        {
            InitializeComponent();
            Usuario = new UsuarioDTO();
        }

        private bool ValidateUsuario()
        {
            bool isValid = true;
            errorProvider.SetError(nombreTextBox, string.Empty);
            errorProvider.SetError(emailTextBox, string.Empty);
            errorProvider.SetError(contraseniaTextBox, string.Empty);

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
                    this.Usuario.Tipo_usu = "Denunciante";

                    await UsuarioApiClient.AddAsync(this.Usuario);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}