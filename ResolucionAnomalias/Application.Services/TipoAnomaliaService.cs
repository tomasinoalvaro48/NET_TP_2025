using Data;
using Domain.Model;

namespace Application.Services
{
    internal class TipoAnomaliaService
    {

        public int GetNextCod_Tipo()
        {
            int nextCod_tipo;
            if (TipoAnomaliaInMemory.TiposAnomalia.Count > 0)
            {
                nextCod_tipo = TipoAnomaliaInMemory.TiposAnomalia.Max(x => x.Cod_anom) + 1;
            }
            else
            {
                nextCod_tipo = 1;
            }
            return nextCod_tipo;
        }
        public TipoAnomalia Get(int cod_anom)
        {
            return TipoAnomaliaInMemory.TiposAnomalia.Find(x => x.Cod_anom == cod_anom);
        }

        public IEnumerable<TipoAnomalia> GetAll()
        {
            return TipoAnomaliaInMemory.TiposAnomalia.ToList();
        }
        public void Add(TipoAnomalia tipoAnomalia)
        {
            tipoAnomalia.SetCod_anom(GetNextCod_Tipo());
            TipoAnomaliaInMemory.TiposAnomalia.Add(tipoAnomalia);
        }
        public bool Delete(int cod_anom)
        {
            TipoAnomalia? tipoToDelete = TipoAnomaliaInMemory.TiposAnomalia.Find(x => x.Cod_anom == cod_anom);
            if (tipoToDelete != null)
            {
                TipoAnomaliaInMemory.TiposAnomalia.Remove(tipoToDelete);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Update(TipoAnomalia tipo)
        {
            TipoAnomalia? tipoToUpdate = TipoAnomaliaInMemory.TiposAnomalia.Find(x => x.Cod_anom == tipo.Cod_anom);
            if (tipoToUpdate != null)
            {
                tipoToUpdate.SetNombre_anom(tipo.Nombre_anom);
                tipoToUpdate.SetDif_anom(tipo.Dif_anom);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
