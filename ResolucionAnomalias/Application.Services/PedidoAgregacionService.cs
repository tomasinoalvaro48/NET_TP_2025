using Data;
using Domain.Model;
using DTOs;

namespace Application.Services
{
    public class PedidoAgregacionService
    {
        public async Task<PedidoAgregacionDTO> AddAsync(PedidoAgregacionDTO dto)
        {
            var pedidoAgregacionRepository = new PedidoAgregacionRepository();

            var estado = "Pendiente";
            PedidoAgregacion pedidoAgregacion = new PedidoAgregacion(dto.Descripcion_pedido_agreg, dto.Dificultad_pedido_agreg, estado);
            await pedidoAgregacionRepository.AddAsync(pedidoAgregacion);

            dto.Id_pedido_agreg = pedidoAgregacion.Id_pedido_agreg;
            dto.Estado_pedido_agreg = pedidoAgregacion.Estado_pedido_agreg;

            return dto;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var pedidoAgregacionRepository = new PedidoAgregacionRepository();
            return await pedidoAgregacionRepository.DeleteAsync(id);
        }

        public async Task<PedidoAgregacionDTO> GetAsync(int id)
        {
            var pedidoAgregacionRepository = new PedidoAgregacionRepository();
            PedidoAgregacion? pedidoAgregacion = await pedidoAgregacionRepository.GetAsync(id);
            if (pedidoAgregacion == null)
            {
                return null;
            }
            else
            {
                return new PedidoAgregacionDTO
                {
                    Id_pedido_agreg = pedidoAgregacion.Id_pedido_agreg,
                    Descripcion_pedido_agreg = pedidoAgregacion.Descripcion_pedido_agreg,
                    Dificultad_pedido_agreg = pedidoAgregacion.Dificultad_pedido_agreg,
                    Estado_pedido_agreg = pedidoAgregacion.Estado_pedido_agreg
                };
            }
        }

        public async Task<IEnumerable<PedidoAgregacionDTO>> GetAllAsync()
        {
            var pedidoAgregacionRepository = new PedidoAgregacionRepository();
            var pedidosAgregacion = await pedidoAgregacionRepository.GetAllAsync();

            return pedidosAgregacion.Select(pedidoAgregacion => new PedidoAgregacionDTO
            {
                Id_pedido_agreg = pedidoAgregacion.Id_pedido_agreg,
                Descripcion_pedido_agreg = pedidoAgregacion.Descripcion_pedido_agreg,
                Dificultad_pedido_agreg = pedidoAgregacion.Dificultad_pedido_agreg,
                Estado_pedido_agreg = pedidoAgregacion.Estado_pedido_agreg,
            }).ToList();
        }

        public async Task<bool> UpdateAsync(PedidoAgregacionDTO dto)
        {
            var pedidoAgregacionRespository = new PedidoAgregacionRepository();
            var pedidoToUpdate = await pedidoAgregacionRespository.GetAsync(dto.Id_pedido_agreg);
            
            if (pedidoToUpdate == null)
                return false;

            pedidoToUpdate.SetDescripcion(dto.Descripcion_pedido_agreg);
            pedidoToUpdate.SetDificultad(dto.Dificultad_pedido_agreg);
            pedidoToUpdate.SetEstado(dto.Estado_pedido_agreg);

            return await pedidoAgregacionRespository.UpdateAsync(pedidoToUpdate);
        }
    }
}