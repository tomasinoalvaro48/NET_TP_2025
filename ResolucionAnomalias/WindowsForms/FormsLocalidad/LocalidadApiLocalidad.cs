using System.Net.Http.Headers;
using System.Net.Http.Json;
using DTOs;

namespace WindowsForms.FormsLocalidad
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


        public static async Task<LocalidadDTO> GetAsync(int id)
        {
            LocalidadDTO localidad = null;
            HttpResponseMessage response = await client.GetAsync("localidades/" + id);
            if (response.IsSuccessStatusCode)
            {
                localidad = await response.Content.ReadAsAsync<LocalidadDTO>();
            }
            return localidad;
        }

        public static async Task<IEnumerable<LocalidadDTO>> GetAllAsync()      //En el ejemplo esta con dto el IEnumerable
        {
            IEnumerable<LocalidadDTO> localidades = null;
            HttpResponseMessage response = await client.GetAsync("localidades");
            if (response.IsSuccessStatusCode)
            {
                localidades = await response.Content.ReadAsAsync<IEnumerable<LocalidadDTO>>();
            }
            return localidades;
        }

        public async static Task AddAsync(LocalidadDTO localidad)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("localidades", localidad);
            response.EnsureSuccessStatusCode();
        }

        public static async Task DeleteAsync(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync("localidades/" + id);
            response.EnsureSuccessStatusCode();
        }

        public static async Task UpdateAsync(LocalidadDTO localidad)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync("localidades", localidad);
            response.EnsureSuccessStatusCode();
        }
    }
}

