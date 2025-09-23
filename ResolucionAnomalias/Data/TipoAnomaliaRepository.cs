using Domain.Model;

namespace Data
{
    public class TipoAnomaliaRepository
    {
        private TPIContext CreateContext()
        {
            return new TPIContext();
        }

        public IEnumerable<TipoAnomalia> GetAll()
        {
            using var context = CreateContext();
            return context.TipoAnomalias.OrderBy(t => t.Cod_anom).ToList();
        }
        public void Add(TipoAnomalia tipoAnomalia)
        {
            using var context = CreateContext();
            context.TipoAnomalias.Add(tipoAnomalia);
            context.SaveChanges();
        }

        public bool Delete(int cod_anom)
        {
            using var context = CreateContext();
            var tipoAnomalia = context.TipoAnomalias.Find(cod_anom);
            if (tipoAnomalia != null)
            {
                context.TipoAnomalias.Remove(tipoAnomalia);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public TipoAnomalia GetById(int cod_anom)
        {
            using var context = CreateContext();
            return context.TipoAnomalias.FirstOrDefault(t => t.Cod_anom == cod_anom);
        }

        public bool Update(TipoAnomalia tipo)
        {
            using var context = CreateContext();
            var existingTipoAnomalia = context.TipoAnomalias.Find(tipo.Cod_anom);
            if (existingTipoAnomalia != null)
            {
                existingTipoAnomalia.SetNombre_anom(tipo.Nombre_anom);
                existingTipoAnomalia.SetDif_anom(tipo.Dif_anom);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool NombreExists(string nombre, int? excludeId = null)
        {
            using var context = CreateContext();
            var query = context.TipoAnomalias.Where(c => c.Nombre_anom == nombre);
            if (excludeId.HasValue)
            {
                query = query.Where(c => c.Cod_anom != excludeId.Value);
            }
            return query.Any();
        }
    }
}