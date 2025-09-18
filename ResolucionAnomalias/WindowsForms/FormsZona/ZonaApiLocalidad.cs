using System.Net.Http.Headers;
using System.Net.Http.Json;
using DTOs;

namespace WindowsForms.FormsZona
{
    public class ZonaApiLocalidad
    {
        private static HttpClient client = new HttpClient();

        static ZonaApiLocalidad()
        {
            client.BaseAddress = new Uri("http://localhost:5183/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static async Task<ZonaDTO> GetAsync(int id)
        {
            ZonaDTO zona = null;
            HttpResponseMessage response = await client.GetAsync("zonas/" + id);
            if (response.IsSuccessStatusCode)
            {
                zona = await response.Content.ReadAsAsync<ZonaDTO>();
            }
            return zona;
        }

        public static async Task<IEnumerable<ZonaDTO>> GetAllAsync()
        {
            IEnumerable<ZonaDTO> zonas = null;
            HttpResponseMessage response = await client.GetAsync("zonas");
            if (response.IsSuccessStatusCode)
            {
                zonas = await response.Content.ReadAsAsync<IEnumerable<ZonaDTO>>();
            }
            return zonas;
        }

        public async static Task AddAsync(ZonaDTO zona)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("zonas", zona);
            response.EnsureSuccessStatusCode();

        }

        public static async Task DeleteAsync(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync("zonas/" + id);
            response.EnsureSuccessStatusCode();
        }

        public static async Task UpdateAsync(ZonaDTO zona)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync("zonas", zona);
            response.EnsureSuccessStatusCode();
        }
    }
}
