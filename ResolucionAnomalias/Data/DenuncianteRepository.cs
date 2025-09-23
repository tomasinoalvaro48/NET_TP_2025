using Domain.Model;

namespace Data
{
    public class DenuncianteRepository
    {
        private TPIContext CreateContext()
        {
            return new TPIContext();
        }

        public void Add(Denunciante denunciante)
        {
            using var context = CreateContext();
            context.Denunciantes.Add(denunciante);
            context.SaveChanges();
        }

        public bool Delete(int id)
        {
            using var context = CreateContext();
            var denunciante = context.Denunciantes.Find(id);
            if (denunciante != null)
            {
                context.Denunciantes.Remove(denunciante);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public Denunciante? Get(int id)
        {
            using var context = CreateContext();
            return context.Denunciantes.FirstOrDefault(c => c.Cod_den == id);
        }

        public IEnumerable<Denunciante> GetAll()
        {
            using var context = CreateContext();
            return context.Denunciantes.ToList();
        }

        public bool Update(Denunciante denunciante)
        {
            using var context = CreateContext();
            var existingDenunciante = context.Denunciantes.Find(denunciante.Cod_den);
            if (existingDenunciante != null)
            {
                existingDenunciante.SetNombre_den(denunciante.Nombre_den);
                existingDenunciante.SetTelefono(denunciante.Telefono);
                existingDenunciante.SetDireccion_den(denunciante.Direccion_den);
                context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}