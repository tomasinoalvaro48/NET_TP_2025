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

        public void Add(Usuario usuario)
        {
            using var context = CreateContext();
            context.Usuarios.Add(usuario);
            context.SaveChanges();
        }

        public bool Delete(int id)
        {
            using var context = CreateContext();
            var usuario = context.Usuarios.Find(id);
            if (usuario != null)
            {
                context.Usuarios.Remove(usuario);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public Usuario? Get(int id)
        {
            using var context = CreateContext();
            return context.Usuarios
                .Include(c => c.Zona)
                .ThenInclude(z => z.Localidad)
                .FirstOrDefault(c => c.Cod_usu == id);
        }

        public IEnumerable<Usuario> GetAll()
        {
            using var context = CreateContext();
            return context.Usuarios
                .Include(c => c.Zona)
                .ThenInclude(z => z.Localidad)
                .ToList();
        }

        public bool Update(Usuario usuario)
        {
            using var context = CreateContext();
            var existingUsuario = context.Usuarios.Find(usuario.Cod_usu);
            if (existingUsuario != null)
            {
                existingUsuario.SetNombre_usu(usuario.Nombre_usu);
                existingUsuario.SetEmail_usu(usuario.Email_usu);
                existingUsuario.SetPassw_usu(usuario.Passw_usu);
                existingUsuario.SetTipo_usu(usuario.Tipo_usu);
                existingUsuario.SetZonaId(usuario.ZonaId);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool EmailExists(string email, int? excludeId = null)
        {
            using var context = CreateContext();
            var query = context.Usuarios.Where(c => c.Email_usu.ToLower() == email.ToLower());
            if (excludeId.HasValue)
            {
                query = query.Where(c => c.Cod_usu != excludeId.Value);
            }
            return query.Any();
        }

        public Usuario? GetByEmail(string email)
        {
            using var context = CreateContext();
            return context.Usuarios.FirstOrDefault(c => c.Email_usu.ToLower() == email.ToLower());
        }


        public IEnumerable<Usuario> GetByCriteria(UsuarioCriteria criteria)
        {
            using var context = CreateContext();
            var searchText = criteria.Texto.ToLower();
            
            return context.Usuarios
                .Include(c => c.Zona)
                .ThenInclude(z => z.Localidad)
                .Where(u => u.Nombre_usu.ToLower().Contains(searchText) || 
                            u.Email_usu.ToLower().Contains(searchText))
                .ToList();
        }
    }
}