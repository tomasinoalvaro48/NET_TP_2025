using Domain.Model;
using Microsoft.EntityFrameworkCore;


namespace Data
{
    public class PedidoResolucionRepository
    {
        private TPIContext CreateContext()
        {
            return new TPIContext();
        }

        public async Task AddAsync(PedidoResolucion pedido)
        {
            using var context = CreateContext();
            await context.AddAsync(pedido);
            await context.SaveChangesAsync();
        }

        public async Task<bool> DeleteAsync(int id)
        {
            using var context = CreateContext();
            var pedido = await context.PedidosResolucion.FindAsync(id);
            if (pedido != null)
            {
                context.PedidosResolucion.Remove(pedido);
                await context.SaveChangesAsync();
                return true;
            }
            return false;
        }


        public async Task<IEnumerable<PedidoResolucion>> GetAllAsync()
        {
            using var context = CreateContext();
            return await context.PedidosResolucion
                .Include(p => p.AnomaliaPedidos)
                    .ThenInclude(a => a.TipoAnomalia)
                .Include(p => p.Denunciante)
                .Include(p => p.Zona)
                .Include(p => p.Cazador)
                .ToListAsync();
        }


        public async Task<PedidoResolucion?> GetAsync(int id)
        {
            using var context = CreateContext();
            return await context.PedidosResolucion
                .Include(p => p.AnomaliaPedidos)
                    .ThenInclude(a => a.TipoAnomalia)
                .Include(p => p.Denunciante)
                .Include(p => p.Zona)
                .Include(p => p.Cazador)
                .FirstOrDefaultAsync(p => p.Id == id);
        }


        public async Task<bool> UpdateAsync(PedidoResolucion pedido)
        {
            using var context = CreateContext();

            var existingPedido = await context.PedidosResolucion
                .Include(p => p.AnomaliaPedidos)
                .Include(p => p.Denunciante)
                .Include(p => p.Zona)
                .Include(p => p.Cazador)
                .FirstOrDefaultAsync(p => p.Id == pedido.Id);

            if (existingPedido == null)
                return false;


            existingPedido.setEstado(pedido.Estado);
            existingPedido.setComentario(pedido.Comentario);

         
            existingPedido.SetCazadorId(pedido.CazadorId.Value);

            await context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> FinalizarPedidoAsync(PedidoResolucion pedido)
        {
            using var context = CreateContext();

            var existingPedido = await context.PedidosResolucion
                .Include(p => p.AnomaliaPedidos)
                .Include(p => p.Denunciante)
                .Include(p => p.Zona)
                .Include(p => p.Cazador)
                .FirstOrDefaultAsync(p => p.Id == pedido.Id);

            if (existingPedido == null)
                return false;
            existingPedido.setEstado(pedido.Estado);
            await context.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<PedidoResolucion>> GetAllDenunciante(int id)
        {
            using var context = CreateContext();
            return await context.PedidosResolucion
                .Include(p => p.AnomaliaPedidos)
                    .ThenInclude(a => a.TipoAnomalia)
                .Include(p => p.Denunciante)
                .Include(p => p.Zona)
                .Include(p => p.Cazador)
                .Where(p => p.DenuncianteId == id)
                .ToListAsync();
        }
    }
}
