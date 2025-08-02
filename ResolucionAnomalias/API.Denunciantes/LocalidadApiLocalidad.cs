
using System.Collections;
using System.Net.Http.Headers;
using System.Security.AccessControl;
using DTOs;

namespace API.Denunciantes
{
    internal class LocalidadApiLocalidad
    {
        private static HttpClient httpClient = new HttpClient();
        static LocalidadApiLocalidad()
        {
            httpClient.BaseAddress = new Uri("http://localhost:5183/");
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }



        public static async Task<LocalidadDTO> GetAsync(int cod_loc)
        {
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync("localidades/" + cod_loc);
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<LocalidadDTO>();
                }
                else
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al obtener la loclidad con Código {cod_loc}. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al obtener la localidad con Código {cod_loc}: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al obtener la localidad con Código {cod_loc}: {ex.Message}", ex);
            }

        }


        public static async Task<IEnumerable<LocalidadDTO>> GetAllAsync()
        {
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync("localidades");
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
                HttpResponseMessage response = await httpClient.PostAsJsonAsync("localidades", dto);
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
                HttpResponseMessage response = await httpClient.PutAsJsonAsync("localidades", dto);
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
        
        public static async Task DeleteAsync(int cod_loc)
        {
            try
            {
                HttpResponseMessage response = await httpClient.DeleteAsync("localidades/" + cod_loc);
                if (!response.IsSuccessStatusCode)
                {

                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al eliminar la localidad con Código {cod_loc}. Status: {response.StatusCode}, Detalle: {errorContent}");

                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexiónal eliminar la localidad con Código {cod_loc}: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al eliminar la localidad con Código {cod_loc}: {ex.Message}", ex);
            }
        }

        
    
    
    
    }
}
