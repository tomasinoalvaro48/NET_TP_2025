using API.Clients;
using API.Auth.WindowsForms;

namespace WindowsForms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            
            // Iniciar la aplicación con el loop de autenticación
            Task.Run(async () => await MainAsync()).GetAwaiter().GetResult();
        }

        static async Task MainAsync()
        {
            // Registrar AuthService en singleton
            var authService = new WindowsFormsAuthService();
            AuthServiceProvider.Register(authService);

            // Loop principal de autenticación
            while (true)
            {
                if (!await authService.IsAuthenticatedAsync())
                {
                    var loginForm = new LoginForm();
                    if (loginForm.ShowDialog() != DialogResult.OK)
                    {
                        // Usuario canceló login, cerrar aplicación
                        return;
                    }
                }
                var user = await authService.GetCurrentUserAsync();
                try
                {
                    if (user.Tipo_usu == "Operador")
                        Application.Run(new MenuOperador());
                    else if (user.Tipo_usu == "Cazador")
                        Application.Run(new MenuCazador());
                    else if (user.Tipo_usu == "Denunciante")
                        Application.Run(new MenuDenunciante());
                }
                catch (UnauthorizedAccessException ex)
                {
                    // Sesión expirada, mostrar mensaje y volver al login
                    MessageBox.Show(ex.Message, "Sesión Expirada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    // El loop continuará y volverá a mostrar login
                }
            }
        }
    }
}