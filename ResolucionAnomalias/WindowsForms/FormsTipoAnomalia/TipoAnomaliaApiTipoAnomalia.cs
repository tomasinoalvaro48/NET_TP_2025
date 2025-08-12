using DTOs;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace WindowsForms.FormsTipoAnomalia
{
    public class TipoAnomaliaApiTipoAnomalia
    {
        private static HttpClient httpClient = new HttpClient();
        static TipoAnomaliaApiTipoAnomalia()
        {
            httpClient.BaseAddress = new Uri("http://localhost:5183/");
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }


        public static async Task<TipoAnomaliaDTO> GetAsync(int cod_tipo)
        {
            TipoAnomaliaDTO tipo = null;
            HttpResponseMessage response = await httpClient.GetAsync("tipoanomalia/" + cod_tipo);
            var json = await response.Content.ReadAsStringAsync();
            Console.WriteLine(json); // Verifica el contenido recibido
            if (response.IsSuccessStatusCode)
            {
                tipo = await response.Content.ReadFromJsonAsync<TipoAnomaliaDTO>();
            }
            return tipo;
        }

        public static async Task<IEnumerable<TipoAnomaliaDTO>> GetAllAsync()
        {
            IEnumerable<TipoAnomaliaDTO> tipos = null;
            HttpResponseMessage response = await httpClient.GetAsync("tipoanomalia");
            if (response.IsSuccessStatusCode)
            {
                tipos = await response.Content.ReadFromJsonAsync<IEnumerable<TipoAnomaliaDTO>>();
            }
            return tipos;
        }

        public async static Task AddAsync(TipoAnomaliaDTO tipo)
        {
            HttpResponseMessage response = await httpClient.PostAsJsonAsync("tipoanomalia", tipo);
            response.EnsureSuccessStatusCode();
        }

        public static async Task DeleteAsync(int cod_tipo)
        {
            HttpResponseMessage response = await httpClient.DeleteAsync("tipoanomalia/" + cod_tipo);
            response.EnsureSuccessStatusCode();
        }

        public static async Task UpdateAsync(TipoAnomaliaDTO tipo)
        {
            HttpResponseMessage response = await httpClient.PutAsJsonAsync("tipoanomalia", tipo);
            response.EnsureSuccessStatusCode();
        }
    }
}