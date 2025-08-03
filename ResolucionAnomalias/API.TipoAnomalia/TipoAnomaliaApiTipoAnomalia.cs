using System.Net.Http.Headers;
using System.Net.Http.Json;
using DTOs;

namespace API.TipoAnomalia
{
    public class TipoAnomaliaApiTipoAnomalia
    {
        private static HttpClient httpClient = new HttpClient();
        static TipoAnomaliaApiTipoAnomalia()
        {
            httpClient.BaseAddress = new Uri("http://localhost:5183/");
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static async Task<TipoAnomaliaDTO> GetAsync(int cod_tipo)
        {
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync("tipoanomalia/" + cod_tipo);
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<TipoAnomaliaDTO>();
                }
                else
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al obtener tipo de anomalia con Código {cod_tipo}. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al obtener tipo de anomalia con Código {cod_tipo}: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al obtener tipo de anomalia con Código {cod_tipo}: {ex.Message}", ex);
            }
        }

        public static async Task<IEnumerable<TipoAnomaliaDTO>> GetAllAsync()
        {
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync("tipoanomalia");
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<IEnumerable<TipoAnomaliaDTO>>();
                }
                else
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al obtener lista de tipos de anomalias. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al obtener lista de tipos de anomalias: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al obtener lista de tipos de anomalias: {ex.Message}", ex);
            }
        }

        public async static Task AddAsync(TipoAnomaliaDTO tipo)
        {
            try
            {
                HttpResponseMessage response = await httpClient.PostAsJsonAsync("tipopanomalia", tipo);
                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al crear tipo de anomalia. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al crear tipo de anomalia: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al crear tipo de anomalia: {ex.Message}", ex);
            }
        }

        public static async Task DeleteAsync(int cod_tipo)
        {
            try
            {
                HttpResponseMessage response = await httpClient.DeleteAsync("denunciantes/" + cod_tipo);
                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al eliminar tipo de anomalia con Código {cod_tipo}. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al eliminar tipo de anomalia con Código {cod_tipo}: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al eliminar tipo de anomalia con Código {cod_tipo}: {ex.Message}", ex);
            }
        }

        public static async Task UpdateAsync(TipoAnomaliaDTO tipo)
        {
            try
            {
                HttpResponseMessage response = await httpClient.PutAsJsonAsync("denunciantes", tipo);
                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al actualizar tipo de anomalia con Código {tipo.Cod_anom}. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al actualizar tipo de anomalia con Código {tipo.Cod_anom}: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al actualizar tipo de anomalia con Código {tipo.Cod_anom}: {ex.Message}", ex);
            }
        }
    }
}