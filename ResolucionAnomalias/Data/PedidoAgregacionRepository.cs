using Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class PedidoAgregacionRepository
    {
        private TPIContext CreateContext()
        {
            return new TPIContext();
        }

        public async Task<IEnumerable<PedidoAgregacion>> GetAllAsync()
        {
            using var context = CreateContext();
            return await context.PedidosAgregacion
                .Include(p => p.Cazador)
                .Include(p => p.TipoAnomalia)
                .OrderBy(p => p.Id_pedido_agreg)
                .ToListAsync();
        }

        public async Task AddAsync(PedidoAgregacion pedidoAgregacion)
        {
            using var context = CreateContext();
            await context.PedidosAgregacion.AddAsync(pedidoAgregacion);
            await context.SaveChangesAsync();
        }

        public async Task<bool> DeleteAsync(int id)
        {
            using var context = CreateContext();
            var pedidoAgregacion = await context.PedidosAgregacion.FindAsync(id);
            if (pedidoAgregacion != null)
            {
                context.PedidosAgregacion.Remove(pedidoAgregacion);
                await context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<PedidoAgregacion?> GetAsync(int id)
        {
            using var context = CreateContext();
            return await context.PedidosAgregacion
                .Include(p => p.Cazador)
                .Include(p => p.TipoAnomalia)
                .FirstOrDefaultAsync(c => c.Id_pedido_agreg == id);
        }

        public async Task<bool> UpdateAsync(PedidoAgregacion pedidoAgregacion)
        {
            using var context = CreateContext();
            var existingPedidoAgregacion = await context.PedidosAgregacion.FindAsync(pedidoAgregacion.Id_pedido_agreg);
            if (existingPedidoAgregacion != null)
            {
                existingPedidoAgregacion.SetDescripcion(pedidoAgregacion.Descripcion_pedido_agreg);
                existingPedidoAgregacion.SetDificultad(pedidoAgregacion.Dificultad_pedido_agreg);
                existingPedidoAgregacion.SetEstado(pedidoAgregacion.Estado_pedido_agreg);
                existingPedidoAgregacion.SetTipoAnomalia(pedidoAgregacion.TipoAnomaliaId);
                await context.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}