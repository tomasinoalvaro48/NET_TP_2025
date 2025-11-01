using API.Clients;
using API.Clients.EntitiesClients;
using DTOs;
using System.IdentityModel.Tokens.Jwt;

namespace API.Auth.WindowsForms
{
    public class WindowsFormsAuthService : IAuthService
    {
        private static string? _currentToken;
        private static DateTime _tokenExpiration;
        private static string? _currentUsername;
        private UsuarioDTO? _cachedUser;

        public event Action<bool>? AuthenticationStateChanged;

        public async Task<bool> IsAuthenticatedAsync()
        {
            return !string.IsNullOrEmpty(_currentToken) && DateTime.UtcNow < _tokenExpiration;
        }

        public async Task<string?> GetTokenAsync()
        {
            var isAuth = await IsAuthenticatedAsync();
            return isAuth ? _currentToken : null;
        }

        public async Task<string?> GetUsernameAsync()
        {
            var isAuth = await IsAuthenticatedAsync();
            return isAuth ? _currentUsername : null;
        }

        public async Task<bool> LoginAsync(string username, string password)
        {
            var request = new LoginRequest
            {
                Email = username,
                Password = password
            };

            var authClient = new AuthApiClient();

            var response = await authClient.LoginAsync(request);

            if (response != null)
            {
                _currentToken = response.Token;
                _tokenExpiration = response.ExpiresAt;
                _currentUsername = response.Email;

                AuthenticationStateChanged?.Invoke(true);
                return true;
            }

            return false;
        }

        public Task LogoutAsync()
        {
            ClearSession();

            AuthenticationStateChanged?.Invoke(false);
            return Task.CompletedTask;
        }

        public async Task CheckTokenExpirationAsync()
        {
            if (!string.IsNullOrEmpty(_currentToken) && DateTime.UtcNow >= _tokenExpiration)
            {
                await LogoutAsync();
            }
        }

        public async Task<bool> HasPermissionAsync(string permission)
        {
            var token = await GetTokenAsync();
            if (string.IsNullOrEmpty(token))
                return false;

            try
            {
                var handler = new JwtSecurityTokenHandler();
                var jsonToken = handler.ReadJwtToken(token);

                var permissionClaims = jsonToken.Claims
                    .Where(c => c.Type == "permission")
                    .Select(c => c.Value);

                return permissionClaims.Contains(permission);
            }
            catch
            {
                return false;
            }
        }

        public async Task<UsuarioDTO?> GetCurrentUserAsync()
        {
            if (_cachedUser != null)
                return _cachedUser;

            var username = await GetUsernameAsync();

            if (string.IsNullOrEmpty(username))
                return null;

            var usuarios = await UsuarioApiClient.GetAllAsync();
            _cachedUser = usuarios.FirstOrDefault(u => u.Email_usu.Equals(username, StringComparison.OrdinalIgnoreCase));

            return _cachedUser;
        }

        public void ClearSession()
        {
            _currentToken = null;
            _currentUsername = null;
            _cachedUser = null;
            _tokenExpiration = default;
        }
    }
}