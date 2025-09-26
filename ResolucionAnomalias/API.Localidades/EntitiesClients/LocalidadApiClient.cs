using DTOs;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace API.Clients.EntitiesClients
{
    public class LocalidadApiClient
    {
        private static HttpClient client = new HttpClient();
        static LocalidadApiClient()
        {
            client.BaseAddress = new Uri("http://localhost:5183/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static async Task<LocalidadDTO> GetAsync(int id)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("localidades/" + id);
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<LocalidadDTO>();
                }
                else
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al obtener la loclidad con Código {id}. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al obtener la localidad con Código {id}: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al obtener la localidad con Código {id}: {ex.Message}", ex);
            }

        }

        public static async Task<IEnumerable<LocalidadDTO>> GetAllAsync()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("localidades");
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<IEnumerable<LocalidadDTO>>();
                }
                else
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al obtener las loclidades . Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al obtener las localidades: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al obtener las localidades: {ex.Message}", ex);
            }
        }

        public static async Task AddAsync(LocalidadDTO dto)
        {
            try
            {
                HttpResponseMessage response = await client.PostAsJsonAsync("localidades", dto);
                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al crear la localidad. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al crear la localidad: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al crear la Localidad: {ex.Message}", ex);
            }
        }

        public static async Task UpdateAsync(LocalidadDTO dto)
        {
            try
            {
                HttpResponseMessage response = await client.PutAsJsonAsync("localidades", dto);
                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al actualizar la localidad. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al actualizar la localidad: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al actualizar la Localidad: {ex.Message}", ex);
            }

        }

        public static async Task DeleteAsync(int id)
        {
            try
            {
                HttpResponseMessage response = await client.DeleteAsync("localidades/" + id);
                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al eliminar la localidad con ID {id}. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexiónal eliminar la localidad con ID {id}: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al eliminar la localidad con ID {id}: {ex.Message}", ex);
            }
        }
    }
}