using Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class UsuarioRepository
    {
        private TPIContext CreateContext()
        {
            return new TPIContext();
        }

        public async Task AddAsync(Usuario usuario)
        {
            using var context = CreateContext();
            await context.Usuarios.AddAsync(usuario);
            await context.SaveChangesAsync();
        }

        public async Task<bool> DeleteAsync(int id)
        {
            using var context = CreateContext();
            var usuario = await context.Usuarios.FindAsync(id);
            if (usuario != null)
            {
                context.Usuarios.Remove(usuario);
                await context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<Usuario?> GetAsync(int id)
        {
            using var context = CreateContext();
            return await context.Usuarios
                .Include(c => c.Zona)
                .ThenInclude(z => z.Localidad)
                .FirstOrDefaultAsync(c => c.Cod_usu == id);
        }

        public async Task<IEnumerable<Usuario>> GetAllAsync()
        {
            using var context = CreateContext();
            return await context.Usuarios
                .Include(c => c.Zona)
                .ThenInclude(z => z.Localidad)
                .ToListAsync();
        }

        public async Task<bool> UpdateAsync(Usuario usuario)
        {
            using var context = CreateContext();
            var existingUsuario = await context.Usuarios.FindAsync(usuario.Cod_usu);
            if (existingUsuario != null)
            {
                context.Entry(existingUsuario).CurrentValues.SetValues(usuario);
                await context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<bool> EmailExistsAsync(string email, int? excludeId = null)
        {
            using var context = CreateContext();
            var query = context.Usuarios.Where(c => c.Email_usu.ToLower() == email.ToLower());
            if (excludeId.HasValue)
            {
                query = query.Where(c => c.Cod_usu != excludeId.Value);
            }
            return await query.AnyAsync();
        }

        public async Task<Usuario?> GetByEmailAsync(string email)
        {
            using var context = CreateContext();
            return await context.Usuarios.FirstOrDefaultAsync(c => c.Email_usu.ToLower() == email.ToLower());
        }

        public async Task<IEnumerable<Usuario>> GetByCriteriaAsync(UsuarioCriteria criteria)
        {
            using var context = CreateContext();
            var searchText = criteria.Texto.ToLower();
            
            return await context.Usuarios
                .Include(c => c.Zona)
                .ThenInclude(z => z.Localidad)
                .Where(u => u.Nombre_usu.ToLower().Contains(searchText) || 
                            u.Email_usu.ToLower().Contains(searchText))
                .ToListAsync();
        }
    }
}