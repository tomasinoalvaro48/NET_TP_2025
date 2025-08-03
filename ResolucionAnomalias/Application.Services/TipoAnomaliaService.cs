using Data;
using Domain.Model;
using DTOs;

namespace Application.Services
{
    public class TipoAnomaliaService
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
        public TipoAnomaliaDTO Get(int cod_anom)
        {
            TipoAnomalia? tipo = TipoAnomaliaInMemory.TiposAnomalia.Find(x => x.Cod_anom == cod_anom);

            if (tipo == null)
                return null;

            return new TipoAnomaliaDTO
            {
                Cod_anom = tipo.Cod_anom,
                Nombre_anom = tipo.Nombre_anom,
                Dif_anom = tipo.Dif_anom
            };
        }

        public IEnumerable<TipoAnomaliaDTO> GetAll()
        {
            return TipoAnomaliaInMemory.TiposAnomalia.Select(tipo => new TipoAnomaliaDTO
            {
                Cod_anom = tipo.Cod_anom,
                Nombre_anom = tipo.Nombre_anom,
                Dif_anom = tipo.Dif_anom
            }).ToList();
        }
        public TipoAnomaliaDTO Add(TipoAnomaliaDTO dto)
        {
            var cod_tipo = GetNextCod_Tipo();
            TipoAnomalia tipo = new TipoAnomalia(cod_tipo, dto.Nombre_anom, dto.Dif_anom);
            TipoAnomaliaInMemory.TiposAnomalia.Add(tipo);
            dto.Cod_anom = tipo.Cod_anom;
            return dto;
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

        public bool Update(TipoAnomaliaDTO tipo)
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
