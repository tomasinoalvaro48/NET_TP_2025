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
            
            // Iniciar la aplicaci�n con el loop de autenticaci�n
            Task.Run(async () => await MainAsync()).GetAwaiter().GetResult();
        }

        static async Task MainAsync()
        {
            // Registrar AuthService en singleton
            var authService = new WindowsFormsAuthService();
            AuthServiceProvider.Register(authService);

            // Loop principal de autenticaci�n
            while (true)
            {
                if (!await authService.IsAuthenticatedAsync())
                {
                    var loginForm = new LoginForm();
                    if (loginForm.ShowDialog() != DialogResult.OK)
                    {
                        // Usuario cancel� login, cerrar aplicaci�n
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
                    // Sesi�n expirada, mostrar mensaje y volver al login
                    MessageBox.Show(ex.Message, "Sesi�n Expirada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    // El loop continuar� y volver� a mostrar login
                }
            }
        }
    }
}