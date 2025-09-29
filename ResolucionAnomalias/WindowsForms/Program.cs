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
                try
                {
                    Application.Run(new MenuCRUDs());
                    break; // La aplicaci�n se cerr� normalmente
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