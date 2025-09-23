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

        public void Add(Zona zona)
        {
            using var context = CreateContext();
            context.Zonas.Add(zona);
            context.SaveChanges();
        }

        public bool Delete(int id)
        {
            using var context = CreateContext();
            var cliente = context.Zonas.Find(id);
            if (cliente != null)
            {
                context.Zonas.Remove(cliente);
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            };
        }

        public Zona? Get(int id)
        {
            using var context = CreateContext();
            return context.Zonas.Include(e => e.Localidad)
                .FirstOrDefault(e => e.Id == id);
        }

        public IEnumerable<Zona> GetAll()
        {
            using var context = CreateContext();
            return context.Zonas.Include(e => e.Localidad).ToList();
        }

        public bool Update(Zona zona)
        {
            using var context = CreateContext();
            var existingZona = context.Zonas.Find(zona.Id);
            if (existingZona != null)
            {
                existingZona.SetNombre(zona.Nombre);
                existingZona.SetLocalidadId(zona.LocalidadId);

                context.SaveChanges();
                return true;

            }
            return false;
        }
    }
}