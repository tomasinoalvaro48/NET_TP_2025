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
                        this.Hide();
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

        private void signinCazadorButton_Click(object sender, EventArgs e)
        {
            SigninCazadorForm signinCazadorForm = new SigninCazadorForm();
            this.Hide();
            signinCazadorForm.ShowDialog();
            this.Show();
        }

        private void signinDenuncianteButton_Click(object sender, EventArgs e)
        {
            SigninDenuncianteForm signinDenuncianteForm = new SigninDenuncianteForm();
            this.Hide();
            signinDenuncianteForm.ShowDialog();
            this.Show();
        }

        private void CloseProgram_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CruzCloseProgram_Click(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
