using Domain.Model;
using Data;
using DTOs;

namespace Application.Services
{
    public class PedidoResolucionService
    {
        public async Task<PedidoResolucionDTO> AddAsync(PedidoResolucionDTO dto)
        {
            var pedidoRepository = new PedidoResolucionRepository();

            var fechaPedido = DateTime.Now;
            var estadoPedido = "activo";

            var pedido = new PedidoResolucion(
                0,
                fechaPedido, 
                dto.Direccion, 
                dto.Descripcion, 
                estadoPedido,
                dto.Comentario, 
                dto.Dificultad,
                dto.ZonaId, 
                dto.DenuncianteId, 
                dto.CazadorId 
            );

            foreach (var anomalia in dto.Anomalias)
            {
                var anomaliaPedido = new AnomaliaPedido(0, anomalia.TipoAnomaliaId);
                pedido.AddAnomaliaPedido(anomaliaPedido);
            }

            await pedidoRepository.AddAsync(pedido);

            return dto;
        }


        public async Task<bool> DeleteAsync(int id)
        {
            var pedidoRepository = new PedidoResolucionRepository();
            return await pedidoRepository.DeleteAsync(id);
        }


        public async Task<PedidoResolucionDTO> GetAsync(int id)
        {
            var pedidoRepository = new PedidoResolucionRepository();
            PedidoResolucion? pedido = await pedidoRepository.GetAsync(id);

            if (pedido == null)
                return null;

            return new PedidoResolucionDTO
            {
                Id = pedido.Id,
                CazadorId = pedido.CazadorId,
                CazadorNombre = pedido.Cazador != null ? $"{pedido.Cazador.Nombre_usu}" : null,
                Fecha = pedido.Fecha,
                DenuncianteId = pedido.DenuncianteId,
                DenuncianteNombre = pedido.Denunciante != null ? $"{pedido.Denunciante.Nombre_usu}" : null,
                Descripcion = pedido.Descripcion,
                Estado = pedido.Estado,
                Comentario = pedido.Comentario,
                ZonaId = pedido.ZonaId,
                ZonaNombre = pedido.Zona != null ? pedido.Zona.Nombre : null,

                Anomalias = pedido.AnomaliaPedidos.Select(anomalia => new AnomaliaPedidoDTO
                {
                    PedidoResolucionId = anomalia.PedidoId,
                    TipoAnomaliaId = anomalia.TipoAnomaliaId,
                    TipoAnomaliaDescripcion = anomalia.TipoAnomalia?.Nombre_anom,
                    TipoAnomaliaDificultad = anomalia.TipoAnomalia?.Dif_anom
                }).ToList()
            };
        }


        public async Task<IEnumerable<PedidoResolucionDTO>> GetAllAsync()
        {
            var pedidoRepository = new PedidoResolucionRepository();
            var pedidos = await pedidoRepository.GetAllAsync();

            return pedidos.Select(pedido => new PedidoResolucionDTO
            {
                Id = pedido.Id,
                CazadorId = pedido.CazadorId,
                CazadorNombre = pedido.Cazador != null ? $"{pedido.Cazador.Nombre_usu}" : null,
                Fecha = pedido.Fecha,
                DenuncianteId = pedido.DenuncianteId,
                DenuncianteNombre = pedido.Denunciante != null ? $"{pedido.Denunciante.Nombre_usu}" : null,
                Descripcion = pedido.Descripcion,
                Estado = pedido.Estado,
                Comentario = pedido.Comentario,
                ZonaId = pedido.ZonaId,
                ZonaNombre = pedido.Zona != null ? pedido.Zona.Nombre : null,

                Anomalias = pedido.AnomaliaPedidos.Select(anomalia => new AnomaliaPedidoDTO
                {
                    PedidoResolucionId = anomalia.PedidoId,
                    TipoAnomaliaId = anomalia.TipoAnomaliaId,
                    TipoAnomaliaDescripcion = anomalia.TipoAnomalia?.Nombre_anom,
                    TipoAnomaliaDificultad = anomalia.TipoAnomalia?.Dif_anom
                }).ToList()
            }).ToList();
        }
        

        public async Task<bool> UpdateAsync(PedidoResolucionDTO dto)
        {
            var pedidoRepository = new PedidoResolucionRepository();

            var pedido = new PedidoResolucion(
                dto.Id,
                dto.Fecha,
                dto.Direccion,
                dto.Descripcion,
                dto.Estado,
                dto.Comentario,
                dto.Dificultad,
                dto.ZonaId,
                dto.DenuncianteId,
                dto.CazadorId
            );

            foreach(var anomaliaDto in dto.Anomalias)
            {
                var anomaliaPedido = new AnomaliaPedido(0, anomaliaDto.TipoAnomaliaId);
                pedido.AddAnomaliaPedido(anomaliaPedido);
            }
            return await pedidoRepository.UpdateAsync(pedido);


        }
    }
}
