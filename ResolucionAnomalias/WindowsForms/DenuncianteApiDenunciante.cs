using DTOs;
using System.Net.Http.Headers;
using System.Net.Http.Json;

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


        public static async Task<DenuncianteDTO> GetAsync(int cod_den)
        {
            DenuncianteDTO denunciante = null;
            HttpResponseMessage response = await httpClient.GetAsync("denunciantes/" + cod_den);
            if (response.IsSuccessStatusCode)
            {
                denunciante = await response.Content.ReadAsAsync<DenuncianteDTO>();
            }
            return denunciante;
        }

        public static async Task<IEnumerable<DenuncianteDTO>> GetAllAsync()
        {
            IEnumerable<DenuncianteDTO> denunciantes = null;
            HttpResponseMessage response = await httpClient.GetAsync("denunciantes");
            if (response.IsSuccessStatusCode)
            {
                denunciantes = await response.Content.ReadAsAsync<IEnumerable<DenuncianteDTO>>();
            }
            return denunciantes;
        }

        public async static Task AddAsync(DenuncianteDTO denunciante)
        {
            HttpResponseMessage response = await httpClient.PostAsJsonAsync("denunciantes", denunciante);
            response.EnsureSuccessStatusCode();
        }

        public static async Task DeleteAsync(int cod_den)
        {
            HttpResponseMessage response = await httpClient.DeleteAsync("denunciantes/" + cod_den);
            response.EnsureSuccessStatusCode();
        }

        public static async Task UpdateAsync(DenuncianteDTO denunciante)
        {
            HttpResponseMessage response = await httpClient.PutAsJsonAsync("denunciantes", denunciante);
            response.EnsureSuccessStatusCode();
        }
    }
}