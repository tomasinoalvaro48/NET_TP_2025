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
                        var auth = AuthServiceProvider.Instance;
                        var user = await auth.GetCurrentUserAsync();

                        this.Hide();

                        if (user.Tipo_usu == "Operador")
                            new MenuOperador().ShowDialog();
                        else if (user.Tipo_usu == "Cazador")
                            new MenuCazador().ShowDialog();
                        else if (user.Tipo_usu == "Denunciante")
                            new MenuDenunciante().ShowDialog();

                        //this.DialogResult = DialogResult.OK;
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
    }
}
