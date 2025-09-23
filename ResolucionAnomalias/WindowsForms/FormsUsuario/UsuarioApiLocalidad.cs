﻿using DTOs;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace WindowsForms.FormsUsuario
{
    public class UsuarioApiLocalidad
    {
        private static HttpClient client = new HttpClient();
        static UsuarioApiLocalidad()
        {
            client.BaseAddress = new Uri("http://localhost:5183/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static async Task<UsuarioDTO> GetAsync(int id)
        {
            UsuarioDTO usuario = null;
            HttpResponseMessage response = await client.GetAsync("usuarios/" + id);
            if (response.IsSuccessStatusCode)
            {
                usuario = await response.Content.ReadAsAsync<UsuarioDTO>();
            }
            return usuario;
        }

        public static async Task<IEnumerable<UsuarioDTO>> GetAllAsync()
        {
            IEnumerable<UsuarioDTO> usuarios = null;
            HttpResponseMessage response = await client.GetAsync("usuarios");
            if (response.IsSuccessStatusCode)
            {
                usuarios = await response.Content.ReadAsAsync<IEnumerable<UsuarioDTO>>();
            }
            return usuarios;
        }

        public async static Task AddAsync(UsuarioDTO usuario)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("usuarios", usuario);
            response.EnsureSuccessStatusCode();

        }

        public static async Task DeleteAsync(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync("usuarios/" + id);
            response.EnsureSuccessStatusCode();
        }

        public static async Task UpdateAsync(UsuarioDTO usuario)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync("usuarios", usuario);
            response.EnsureSuccessStatusCode();
        }
    }
}