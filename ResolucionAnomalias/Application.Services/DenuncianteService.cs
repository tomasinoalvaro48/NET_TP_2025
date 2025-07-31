using Domain.Model;
using Data;

namespace Application.Services
{
    public class DenuncianteService
    {
        public void Add(Denunciante denunciante)
        {
            denunciante.SetCod_den(GetNextCod_den());
            DenuncianteInMemory.Denunciantes.Add(denunciante);
        }

        public bool Delete(int cod_den)
        {
            Denunciante? denuncianteToDelete = DenuncianteInMemory.Denunciantes.Find(x => x.Cod_den == cod_den);
            if (denuncianteToDelete != null)
            {
                DenuncianteInMemory.Denunciantes.Remove(denuncianteToDelete);
                return true;
            }
            else
            {
                return false;
            }
        }

        public Denunciante Get(int cod_den)
        {
            return DenuncianteInMemory.Denunciantes.Find(x => x.Cod_den == cod_den);
        }

        public IEnumerable<Denunciante> GetAll()
        {
            return DenuncianteInMemory.Denunciantes.ToList();
        }

        public bool Update(Denunciante denunciante)
        {
            Denunciante? denuncianteToUpdate = DenuncianteInMemory.Denunciantes.Find(x => x.Cod_den == denunciante.Cod_den);
            if (denuncianteToUpdate != null)
            {
                denuncianteToUpdate.SetNombre_den(denunciante.Nombre_den);
                denuncianteToUpdate.SetTelefono(denunciante.Telefono);
                denuncianteToUpdate.SetDireccion_den(denunciante.Direccion_den);
                return true;
            }
            else
            {
                return false;
            }
        }

        private static int GetNextCod_den()
        {
            int nextCod_den;
            if (DenuncianteInMemory.Denunciantes.Count > 0)
            {
                nextCod_den = DenuncianteInMemory.Denunciantes.Max(x => x.Cod_den) + 1;
            }
            else
            {
                nextCod_den = 1;
            }
            return nextCod_den;
        }
    }
}