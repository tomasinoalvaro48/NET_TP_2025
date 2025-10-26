using DTOs;
using API.Clients;
using System.IdentityModel.Tokens.Jwt;
using API.Auth.WindowsForms;
using API.Clients.EntitiesClients;

namespace API.Auth.Blazor.Server
{
    public class BlazorServerAuthService : IAuthService
    {
        private static SessionData? _currentSession;

        public event Action<bool>? AuthenticationStateChanged;

        public BlazorServerAuthService()
        {
        }

        private class SessionData
        {
            public string? Token { get; set; }
            public string? Username { get; set; }
            public DateTime Expiration { get; set; }
        }

        public Task<bool> IsAuthenticatedAsync()
        {
            try
            {
                if (_currentSession != null)
                {
                    return Task.FromResult(!string.IsNullOrEmpty(_currentSession.Token) && DateTime.UtcNow < _currentSession.Expiration);
                }
                return Task.FromResult(false);
            }
            catch
            {
                return Task.FromResult(false);
            }
        }

        public Task<string?> GetTokenAsync()
        {
            try
            {
                return Task.FromResult(_currentSession?.Token);
            }
            catch
            {
                return Task.FromResult<string?>(null);
            }
        }

        public Task<string?> GetUsernameAsync()
        {
            try
            {
                return Task.FromResult(_currentSession?.Username);
            }
            catch
            {
                return Task.FromResult<string?>(null);
            }
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
                _currentSession = new SessionData
                {
                    Token = response.Token,
                    Username = response.Email,
                    Expiration = response.ExpiresAt
                };

                AuthenticationStateChanged?.Invoke(true);
                return true;
            }

            return false;
        }

        public Task LogoutAsync()
        {
            _currentSession = null;
            AuthenticationStateChanged?.Invoke(false);
            return Task.CompletedTask;
        }

        public async Task CheckTokenExpirationAsync()
        {
            if (!await IsAuthenticatedAsync())
            {
                await LogoutAsync();
            }
        }

        public Task<bool> HasPermissionAsync(string permission)
        {
            try
            {
                var token = _currentSession?.Token;
                if (string.IsNullOrEmpty(token))
                    return Task.FromResult(false);

                var handler = new JwtSecurityTokenHandler();
                var jsonToken = handler.ReadJwtToken(token);

                var permissionClaims = jsonToken.Claims
                    .Where(c => c.Type == "permission")
                    .Select(c => c.Value);

                return Task.FromResult(permissionClaims.Contains(permission));
            }
            catch
            {
                return Task.FromResult(false);
            }
        }

        private UsuarioDTO? _cachedUser;

        public async Task<UsuarioDTO?> GetCurrentUserAsync()
        {
            if (_cachedUser != null)
                return _cachedUser;

            var username = await GetUsernameAsync();

            if (string.IsNullOrEmpty(username))
                return null;

            var usuarios = await UsuarioApiClient.GetAllAsync();
            _cachedUser = usuarios.FirstOrDefault(u =>
                u.Email_usu.Equals(username, StringComparison.OrdinalIgnoreCase));

            return _cachedUser;
        }

        public void ClearSession()
        {
            _currentSession = null;
            _cachedUser = null;
        }
    }
}