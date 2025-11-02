namespace API.Clients.EntitiesClients
{
    public class ReporteApiClient : BaseApiClient
    {
        public static async Task<byte[]> ObtenerReportePedidosResolucionMesActualAsync()
        {
            try
            {
                using var client = await CreateHttpClientAsync();
                HttpResponseMessage response = await client.GetAsync("reportes/pedidos_resolucion_mes_actual");

                if (!response.IsSuccessStatusCode)
                {
                    string error = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al obtener reporte: {response.StatusCode}. Detalle: {error}");
                }

                return await response.Content.ReadAsByteArrayAsync();
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al obtener reporte: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al obtener reporte: {ex.Message}", ex);
            }
        }

        public static async Task<byte[]> ObtenerReportePedidosAgregacionCategoriasAsync()
        {
            try
            {
                using var client = await CreateHttpClientAsync();
                HttpResponseMessage response = await client.GetAsync("reportes/pedidos_agregacion_categorias");

                if (!response.IsSuccessStatusCode)
                {
                    string error = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al obtener reporte de agregación: {response.StatusCode}. Detalle: {error}");
                }

                return await response.Content.ReadAsByteArrayAsync();
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al obtener reporte de agregación: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al obtener reporte de agregación: {ex.Message}", ex);
            }
        }
    }
}