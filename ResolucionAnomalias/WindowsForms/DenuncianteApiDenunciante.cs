using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms
{
    public class DenuncianteApiDenunciante
    {
        private static HttpClient httpClient = new HttpClient();
        static DenuncianteApiDenunciante()
        {
            httpClient.BaseAddress = new Uri("http://localhost:5183/");
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }


        public static async Task<Denunciante> GetAsync(int cod_den)
        {
            Denunciante denunciante = null;
            HttpResponseMessage response = await httpClient.GetAsync("denunciantes/" + cod_den);
            if (response.IsSuccessStatusCode)
            {
                denunciante = await response.Content.ReadAsAsync<Denunciante>();
            }
            return denunciante;
        }

        public static async Task<IEnumerable<Denunciante>> GetAllAsync()
        {
            IEnumerable<Denunciante> denunciantes = null;
            HttpResponseMessage response = await httpClient.GetAsync("denunciantes");
            if (response.IsSuccessStatusCode)
            {
                denunciantes = await response.Content.ReadAsAsync<IEnumerable<Denunciante>>();
            }
            return denunciantes;
        }

        public async static Task AddAsync(Denunciante denunciante)
        {
            HttpResponseMessage response = await httpClient.PostAsJsonAsync("denunciantes", denunciante);
            response.EnsureSuccessStatusCode();
        }

        public static async Task DeleteAsync(int cod_den)
        {
            HttpResponseMessage response = await httpClient.DeleteAsync("denunciantes/" + cod_den);
            response.EnsureSuccessStatusCode();
        }

        public static async Task UpdateAsync(Denunciante denunciante)
        {
            HttpResponseMessage response = await httpClient.PutAsJsonAsync("denunciantes", denunciante);
            response.EnsureSuccessStatusCode();
        }
    }
}