using Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class LocalidadRepository
    {
        private TPIContext CreateContext()
        {
            return new TPIContext();
        }

        public async Task<IEnumerable<Localidad>> GetAllAsync()
        {
            using var context = CreateContext();
            return await context.Localidades.OrderBy(p=>p.Codigo).ToListAsync();
        }

        public async Task AddAsync(Localidad localidad)
        {
            using var context = CreateContext();
            await context.Localidades.AddAsync(localidad);
            await context.SaveChangesAsync();
        }

        public async Task<bool> DeleteAsync(int id)
        {
            using var context = CreateContext();
            var localidad = await context.Localidades.FindAsync(id);
            if (localidad != null)
            {
                context.Localidades.Remove(localidad);
                await context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<Localidad?> GetAsync(int id)
        {
            using var context = CreateContext();
            return await context.Localidades.FirstOrDefaultAsync(c=> c.ID == id);
        }

        public async Task<bool> UpdateAsync(Localidad localidad)
        {
            using var context = CreateContext();
            var existingLocalidad = await context.Localidades.FindAsync(localidad.ID);
            if (existingLocalidad != null)
            {
                existingLocalidad.SetCodigo(localidad.Codigo);
                existingLocalidad.SetNombre(localidad.Nombre);
                await context.SaveChangesAsync();
                return true ;
            }
            return false;   
        }

        public async Task<bool> CodigoExistsAsync(int codigo, int? excludeId = null)
        {
            using var context = CreateContext();
            var query = context.Localidades.Where(c=>c.Codigo == codigo);
            if (excludeId.HasValue)
            {
                query = query.Where(c=> c.ID != excludeId.Value);
            }
            return await query.AnyAsync();
        }
    }
}