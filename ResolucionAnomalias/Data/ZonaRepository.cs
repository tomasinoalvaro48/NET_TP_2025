using Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class ZonaRepository
    {
        private TPIContext CreateContext()
        {
            return new TPIContext();
        }

        public async Task AddAsync(Zona zona)
        {
            using var context = CreateContext();
            await context.Zonas.AddAsync(zona);
            await context.SaveChangesAsync();
        }

        public async Task<bool> DeleteAsync(int id)
        {
            using var context = CreateContext();
            var cliente = await context.Zonas.FindAsync(id);
            if (cliente != null)
            {
                context.Zonas.Remove(cliente);
                await context.SaveChangesAsync();
                return true;
            }
            else
            {
                return false;
            };
        }

        public async Task<Zona?> GetAsync(int id)
        {
            using var context = CreateContext();
            return await context.Zonas.Include(e => e.Localidad)
                .FirstOrDefaultAsync(e => e.Id == id);
        }

        // Buscar todas las Zonas
        public async Task<IEnumerable<Zona>> GetAllAsync()
        {
            using var context = CreateContext();
            return await context.Zonas.Include(e => e.Localidad).ToListAsync();
        }

        public async Task<bool> UpdateAsync(Zona zona)
        {
            using var context = CreateContext();
            var existingZona = await context.Zonas.FindAsync(zona.Id);
            if (existingZona != null)
            {
                existingZona.SetNombre(zona.Nombre);
                existingZona.SetLocalidadId(zona.LocalidadId);

                await context.SaveChangesAsync();
                return true;

            }
            return false;
        }

        public async Task<IEnumerable<Zona>> GetByLocalidadAsync(int id_loc)
        {
            using var context = CreateContext();
            return await context.Zonas.Include(e => e.Localidad)
                .Where(c => c.LocalidadId == id_loc)
                .ToListAsync();
        }

        public async Task<bool> NombreExistsAsync(int id_loc, string nom)
        {
            using var context = CreateContext();
            var query = context.Zonas.Where(c => c.LocalidadId == id_loc && c.Nombre.ToLower() == nom.ToLower());
            return await query.AnyAsync();
        }
    }
}