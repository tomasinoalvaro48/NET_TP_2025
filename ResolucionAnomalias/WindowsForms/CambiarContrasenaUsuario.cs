using API.Auth.WindowsForms;
using API.Clients.EntitiesClients;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using DTOs;

namespace WindowsForms
{
    public partial class CambiarContrasenaUsuario : Form
    {
        public CambiarContrasenaUsuario()
        {
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void buttonConfirmar_Click(object sender, EventArgs e)
        {
            if(ValidarCampos())
            {
                WindowsFormsAuthService authService = new WindowsFormsAuthService();
                string email = await authService.GetUsernameAsync(); // Obtenemos el email de la sesión
                UsuarioUpdateDTO usu = await UsuarioApiClient.GetByEmailAsync(email); // Obtenemos el usuario por email

                if(usu == null)
                {
                    MessageBox.Show("No se encontró el usuario actual.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string saltAlmacenado = usu.Salt;

                // Hashear la contraseña ingresada
                using var pbkdf2 = new Rfc2898DeriveBytes(
                    textBoxContrasenaActual.Text,
                    Convert.FromBase64String(saltAlmacenado),
                    10000,
                    HashAlgorithmName.SHA256
                );
                byte[] hashBytes = pbkdf2.GetBytes(32);
                string hashContrasenaIngresada = Convert.ToBase64String(hashBytes);

                if (hashContrasenaIngresada != usu.Passw_usu)
                {
                    MessageBox.Show("La contraseña actual es incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                UsuarioUpdateDTO usuarioUpdate = new UsuarioUpdateDTO
                {
                    Cod_usu = usu.Cod_usu,
                    Nombre_usu = usu.Nombre_usu,
                    Email_usu = usu.Email_usu,
                    Passw_usu = textBoxNuevaContrasena.Text,
                    Tipo_usu = usu.Tipo_usu,
                    ZonaId = usu.ZonaId
                };

                await UsuarioApiClient.UpdateAsync(usuarioUpdate);

                MessageBox.Show("Contraseña cambiada exitosamente. Deberá iniciar sesión nuevamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                await authService.LogoutAsync();
                authService.ClearSession();

                this.Close();

                Application.Restart();
            }
        }

        private bool ValidarCampos()
        {
            bool esValido = true;
            errorProvider.Clear();
            if (string.IsNullOrWhiteSpace(textBoxContrasenaActual.Text))
            {
                errorProvider.SetError(textBoxContrasenaActual, "La contraseña actual es obligatoria.");
                esValido = false;
            }
            if (string.IsNullOrWhiteSpace(textBoxNuevaContrasena.Text))
            {
                errorProvider.SetError(textBoxNuevaContrasena, "La nueva contraseña es obligatoria.");
                esValido = false;
            }
            else if (textBoxNuevaContrasena.Text.Length < 6)
            {
                errorProvider.SetError(textBoxNuevaContrasena, "La nueva contraseña debe tener al menos 6 caracteres.");
                esValido = false;
            }
            if (textBoxNuevaContrasena.Text != textBoxRepetirNuevaContrasena.Text)
            {
                errorProvider.SetError(textBoxRepetirNuevaContrasena, "Las contraseñas no coinciden.");
                esValido = false;
            }
            return esValido;
        }
    }
}
