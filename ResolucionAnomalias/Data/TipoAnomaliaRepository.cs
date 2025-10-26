using Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class TipoAnomaliaRepository
    {
        private TPIContext CreateContext()
        {
            return new TPIContext();
        }

        public async Task<IEnumerable<TipoAnomalia>> GetAllAsync()
        {
            using var context = CreateContext();
            return await context.TipoAnomalias.OrderBy(t => t.Cod_anom).ToListAsync();
        }

        public async Task AddAsync(TipoAnomalia tipoAnomalia)
        {
            using var context = CreateContext();
            await context.TipoAnomalias.AddAsync(tipoAnomalia);
            await context.SaveChangesAsync();
        }

        public async Task<bool> DeleteAsync(int cod_anom)
        {
            using var context = CreateContext();
            var tipoAnomalia = await context.TipoAnomalias.FindAsync(cod_anom);
            if (tipoAnomalia != null)
            {
                context.TipoAnomalias.Remove(tipoAnomalia);
                await context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<TipoAnomalia> GetAsync(int cod_anom)
        {
            using var context = CreateContext();
            return await context.TipoAnomalias.FirstOrDefaultAsync(t => t.Cod_anom == cod_anom);
        }

        public async Task<bool> UpdateAsync(TipoAnomalia tipo)
        {
            using var context = CreateContext();
            var existingTipoAnomalia = await context.TipoAnomalias.FindAsync(tipo.Cod_anom);
            if (existingTipoAnomalia != null)
            {
                existingTipoAnomalia.SetNombre_anom(tipo.Nombre_anom);
                existingTipoAnomalia.SetDif_anom(tipo.Dif_anom);
                await context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<bool> NombreExistsAsync(string nombre, int? excludeId = null)
        {
            using var context = CreateContext();
            var query = context.TipoAnomalias.Where(c => c.Nombre_anom == nombre);
            if (excludeId.HasValue)
            {
                query = query.Where(c => c.Cod_anom != excludeId.Value);
            }
            return await query.AnyAsync();
        }
    }
}