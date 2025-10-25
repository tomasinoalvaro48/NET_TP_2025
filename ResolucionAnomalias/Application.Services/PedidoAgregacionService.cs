using Data;
using Domain.Model;
using DTOs;

namespace Application.Services
{
    public class PedidoAgregacionService
    {
        public PedidoAgregacionDTO Add(PedidoAgregacionDTO dto)
        {
            var pedidoAgregacionRepository = new PedidoAgregacionRepository();

            PedidoAgregacion pedidoAgregacion = new PedidoAgregacion(0, dto.Descripcion_pedido_agreg, dto.Dificultad_pedido_agreg, dto.Estado_pedido_agreg);
            pedidoAgregacionRepository.Add(pedidoAgregacion);

            dto.Id_pedido_agreg = pedidoAgregacion.Id_pedido_agreg;

            return dto;
        }

        public bool delete(int id)
        {
            var pedidoAgregacionRepository = new PedidoAgregacionRepository();
            return pedidoAgregacionRepository.Delete(id);
        }

        public PedidoAgregacionDTO Get(int id)
        {
            var pedidoAgregacionRepository = new PedidoAgregacionRepository();
            PedidoAgregacion? pedidoAgregacion = pedidoAgregacionRepository.GetById(id);
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

        public IEnumerable<PedidoAgregacionDTO> GetAll()
        {
            var pedidoAgregacionRepository = new PedidoAgregacionRepository();
            var pedidosAgregacion = pedidoAgregacionRepository.GetAll();

            return pedidosAgregacion.Select(pedidoAgregacion => new PedidoAgregacionDTO
            {
                Id_pedido_agreg = pedidoAgregacion.Id_pedido_agreg,
                Descripcion_pedido_agreg = pedidoAgregacion.Descripcion_pedido_agreg,
                Dificultad_pedido_agreg = pedidoAgregacion.Dificultad_pedido_agreg,
                Estado_pedido_agreg = pedidoAgregacion.Estado_pedido_agreg,
            }).ToList();
        }

        public bool Update(PedidoAgregacionDTO dto)
        {
            var pedidoAgregacionRespository = new PedidoAgregacionRepository();
            PedidoAgregacion pedidoAgregacionToUpdate = new PedidoAgregacion(dto.Id_pedido_agreg, dto.Descripcion_pedido_agreg, dto.Dificultad_pedido_agreg, dto.Estado_pedido_agreg);
            return pedidoAgregacionRespository.Update(pedidoAgregacionToUpdate);
        }
    }
}