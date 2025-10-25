using Domain.Model;

namespace Data
{
    public class PedidoAgregacionRepository
    {
        private TPIContext CreateContext()
        {
            return new TPIContext();
        }

        public IEnumerable<PedidoAgregacion> GetAll()
        {
            using var context = CreateContext();
            return context.PedidosAgregacion.OrderBy(p => p.Id_pedido_agreg).ToList();
        }

        public void Add(PedidoAgregacion pedidoAgregacion)
        {
            using var context = CreateContext();
            context.PedidosAgregacion.Add(pedidoAgregacion);
            context.SaveChanges();
        }

        public bool Delete(int id)
        {
            using var context = CreateContext();
            var pedidoAgregacion = context.PedidosAgregacion.Find(id);
            if (pedidoAgregacion != null)
            {
                context.PedidosAgregacion.Remove(pedidoAgregacion);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public PedidoAgregacion? GetById(int id)
        {
            using var context = CreateContext();
            return context.PedidosAgregacion.FirstOrDefault(c => c.Id_pedido_agreg == id);
        }

        public bool Update(PedidoAgregacion pedidoAgregacion)
        {
            using var context = CreateContext();
            var existingPedidoAgregacion = context.PedidosAgregacion.Find(pedidoAgregacion.Id_pedido_agreg);
            if (existingPedidoAgregacion != null)
            {
                existingPedidoAgregacion.SetDescripcion(pedidoAgregacion.Descripcion_pedido_agreg);
                existingPedidoAgregacion.SetDificultad(pedidoAgregacion.Dificultad_pedido_agreg);
                existingPedidoAgregacion.SetEstado(pedidoAgregacion.Estado_pedido_agreg);
                context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}