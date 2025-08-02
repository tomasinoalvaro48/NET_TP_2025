using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;

namespace WindowsForms
{
    public class LocalidadApiLocalidad
    {
        private static HttpClient client = new HttpClient();
        static LocalidadApiLocalidad()
        {
            client.BaseAddress = new Uri("http://localhost:5183/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }


        public static async Task<Localidad> GetAsync(int id)
        {
            Localidad localidad = null;
            HttpResponseMessage response = await client.GetAsync("localidades/" + id);
            if (response.IsSuccessStatusCode)
            {
                localidad = await response.Content.ReadAsAsync<Localidad>();
            }
            return localidad;
        }

        public static async Task<IEnumerable<Localidad>> GetAllAsync()      //En el ejemplo esta con dto el IEnumerable
        {
            IEnumerable<Localidad> localidades = null;
            HttpResponseMessage response = await client.GetAsync("localidades");
            if (response.IsSuccessStatusCode)
            {
                localidades = await response.Content.ReadAsAsync<IEnumerable<Localidad>>();
            }
            return localidades;
        }

        public async static Task AddAsync(Localidad localidad)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("localidades", localidad);
            response.EnsureSuccessStatusCode();
        }

        public static async Task DeleteAsync(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync("localidades/" + id);
            response.EnsureSuccessStatusCode();
        }

        public static async Task UpdateAsync(Localidad localidad)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync("localidades", localidad);
            response.EnsureSuccessStatusCode();
        }
    }
}

