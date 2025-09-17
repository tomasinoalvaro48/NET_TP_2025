using Domain.Model;

namespace Data
{
    public class LocalidadRepository
    {
        private TPIContext CreateContext()
        {
            return new TPIContext();
        }

        public IEnumerable<Localidad> GetAll()
        {
            using var context = CreateContext();
            
            return context.Localidades.OrderBy(p=>p.Codigo).ToList();
        }

        public void Add(Localidad localidad)
        {
            using var context = CreateContext();
            context.Localidades.Add(localidad);
            context.SaveChanges();
        }

        public bool Delete(int id)
        {
            using var context = CreateContext();
            var localidad = context.Localidades.Find(id);
            if (localidad != null)
            {
                context.Localidades.Remove(localidad);
                context.SaveChanges();
                return true;
            }
            return false;
        }


        public Localidad? GetById(int id)
        {
            using var context = CreateContext();
            return context.Localidades.FirstOrDefault(c=> c.ID == id);
        }

        public bool Update(Localidad localidad)
        {
            using var context = CreateContext();
            var existingLocalidad = context.Localidades.Find(localidad.ID);
            if (existingLocalidad != null)
            {
                existingLocalidad.SetCodigo(localidad.Codigo);
                existingLocalidad.SetNombre(localidad.Nombre);
                context.SaveChanges();
                return true ;
            }
            return false;   
        }

        public bool CodigoExists(int codigo, int? excludeId = null)
        {
            using var context = CreateContext();
            var query = context.Localidades.Where(c=>c.Codigo == codigo);
            if(excludeId.HasValue)
            {
                query = query.Where(c=> c.ID != excludeId.Value);
            }
            return query.Any();
        }


    }
}
