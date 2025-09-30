﻿using API.Auth.WindowsForms;
using Data;
using Domain.Model;
using DTOs;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Application.Services
{
    public class AuthService
    {
        private readonly UsuarioRepository usuarioRepository;
        private readonly IConfiguration configuration;

        public AuthService(IConfiguration configuration)
        {
            usuarioRepository = new UsuarioRepository();
            this.configuration = configuration;
        }

        public async Task<LoginResponse?> LoginAsync(LoginRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.Email) || string.IsNullOrWhiteSpace(request.Password))
                return null;

            var usuario = usuarioRepository.GetByEmail(request.Email);

            if (usuario == null || usuario.Passw_usu != request.Password)
                return null;

            var token = GenerateJwtToken(usuario);
            var expiresAt = DateTime.UtcNow.AddMinutes(GetExpirationMinutes());

            return new LoginResponse
            {
                Token = token,
                ExpiresAt = expiresAt,
                Email = usuario.Email_usu
            };
        }

        private string GenerateJwtToken(Usuario usuario)
        {
            var jwtSettings = configuration.GetSection("JwtSettings");
            var secretKey = jwtSettings["SecretKey"];
            var issuer = jwtSettings["Issuer"];
            var audience = jwtSettings["Audience"];

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey!));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, usuario.Cod_usu.ToString()),
                new Claim(ClaimTypes.Name, usuario.Nombre_usu),
                new Claim(ClaimTypes.Email, usuario.Email_usu),
                new Claim("jti", Guid.NewGuid().ToString())
            };

            var token = new JwtSecurityToken(
                issuer: issuer,
                audience: audience,
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(GetExpirationMinutes()),
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public bool ValidateToken(string token)
        {
            try
            {
                var jwtSettings = configuration.GetSection("JwtSettings");
                var secretKey = jwtSettings["SecretKey"];
                var issuer = jwtSettings["Issuer"];
                var audience = jwtSettings["Audience"];

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey!));

                var tokenHandler = new JwtSecurityTokenHandler();
                var validationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidIssuer = issuer,
                    ValidateAudience = true,
                    ValidAudience = audience,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = key,
                    ClockSkew = TimeSpan.Zero
                };

                tokenHandler.ValidateToken(token, validationParameters, out SecurityToken validatedToken);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public int? GetUserIdFromToken(string token)
        {
            try
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var jsonToken = tokenHandler.ReadJwtToken(token);

                var userIdClaim = jsonToken.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier);
                if (userIdClaim != null && int.TryParse(userIdClaim.Value, out int userId))
                {
                    return userId;
                }
                return null;
            }
            catch
            {
                return null;
            }
        }

        private int GetExpirationMinutes()
        {
            var jwtSettings = configuration.GetSection("JwtSettings");
            if (int.TryParse(jwtSettings["ExpirationMinutes"], out int minutes))
                return minutes;
            return 60; // Default 60 minutes
        }
    }
}