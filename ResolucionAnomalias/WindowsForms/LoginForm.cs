using API.Clients;

namespace WindowsForms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private async void loginButton_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                try
                {
                    loginButton.Enabled = false;
                    loginButton.Text = "Iniciando sesión...";

                    var authService = AuthServiceProvider.Instance;
                    bool success = await authService.LoginAsync(usuarioTextBox.Text, contraseniaTextBox.Text);

                    if (success)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos.", "Error de autenticación",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        contraseniaTextBox.Clear();
                        contraseniaTextBox.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al iniciar sesión: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    loginButton.Enabled = true;
                    loginButton.Text = "Iniciar Sesión";
                }
            }

        }
        private bool ValidateInput()
        {
            errorProvider.SetError(usuarioTextBox, string.Empty);
            errorProvider.SetError(contraseniaTextBox, string.Empty);

            bool isValid = true;

            if (string.IsNullOrWhiteSpace(usuarioTextBox.Text))
            {
                errorProvider.SetError(usuarioTextBox, "El nombre de usuario es requerido");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(contraseniaTextBox.Text))
            {
                errorProvider.SetError(contraseniaTextBox, "La contraseña es requerida");
                isValid = false;
            }

            return isValid;
        }

        private void signinButton_Click(object sender, EventArgs e)
        { 
            SigninForm signinForm = new SigninForm();
            this.Hide();
            signinForm.ShowDialog();
            this.Show();
        }
    }
}
