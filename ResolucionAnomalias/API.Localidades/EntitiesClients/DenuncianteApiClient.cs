using DTOs;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace API.Clients.EntitiesClients
{
    public class DenuncianteApiClient : BaseApiClient
    {
        public static async Task<DenuncianteDTO> GetAsync(int cod_den)
        {
            try
            {
                using var client = await CreateHttpClientAsync();
                HttpResponseMessage response = await client.GetAsync("denunciantes/" + cod_den);
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<DenuncianteDTO>();
                }
                else
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al obtener denunciante con Código {cod_den}. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al obtener denunciante con Código {cod_den}: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al obtener denunciante con Código {cod_den}: {ex.Message}", ex);
            }
        }

        public static async Task<IEnumerable<DenuncianteDTO>> GetAllAsync()
        {
            try
            {
                using var client = await CreateHttpClientAsync();
                HttpResponseMessage response = await client.GetAsync("denunciantes");
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<IEnumerable<DenuncianteDTO>>();
                }
                else
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al obtener lista de denunciantes. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al obtener lista de denunciantes: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al obtener lista de denunciantes: {ex.Message}", ex);
            }
        }

        public async static Task AddAsync(DenuncianteDTO denunciante)
        {
            try
            {
                using var client = await CreateHttpClientAsync();
                HttpResponseMessage response = await client.PostAsJsonAsync("denunciantes", denunciante);
                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al crear denunciante. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al crear denunciante: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al crear denunciante: {ex.Message}", ex);
            }
        }

        public static async Task DeleteAsync(int cod_den)
        {
            try
            {
                using var client = await CreateHttpClientAsync();
                HttpResponseMessage response = await client.DeleteAsync("denunciantes/" + cod_den);
                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al eliminar denunciante con Código {cod_den}. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al eliminar denunciante con Código {cod_den}: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al eliminar denunciante con Código {cod_den}: {ex.Message}", ex);
            }
        }

        public static async Task UpdateAsync(DenuncianteDTO denunciante)
        {
            try
            {
                using var client = await CreateHttpClientAsync();
                HttpResponseMessage response = await client.PutAsJsonAsync("denunciantes", denunciante);
                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al actualizar denunciante con Código {denunciante.Cod_den}. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al actualizar denunciante con Código {denunciante.Cod_den}: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al actualizar denunciante con Código {denunciante.Cod_den}: {ex.Message}", ex);
            }
        }
    }
}