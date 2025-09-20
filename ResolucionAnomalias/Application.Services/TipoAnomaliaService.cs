using Data;
using Domain.Model;
using DTOs;

namespace Application.Services
{
    public class TipoAnomaliaService
    {

        public TipoAnomaliaDTO Get(int cod_anom)
        {
            var tipoRepository = new TipoAnomaliaRepository();
            TipoAnomalia tipo = tipoRepository.GetById(cod_anom);
            if (tipo == null)
            {
                return null;
            }
            else
            {
                return new TipoAnomaliaDTO
                {
                    Cod_anom = tipo.Cod_anom,
                    Nombre_anom = tipo.Nombre_anom,
                    Dif_anom = tipo.Dif_anom
                };

            }
        }

        public IEnumerable<TipoAnomalia> GetAll()
        {
            TipoAnomaliaRepository tipoRepository = new TipoAnomaliaRepository();
            IEnumerable<TipoAnomalia> tipos = tipoRepository.GetAll();
            return tipos;
        }
        public TipoAnomaliaDTO Add(TipoAnomaliaDTO tipo)
        {
            TipoAnomaliaRepository tipoRepository = new TipoAnomaliaRepository();

            if(tipoRepository.NombreExists(tipo.Nombre_anom))
            {
                throw new ArgumentException($"Ya existe un tipo de anomalía con el código {tipo.Cod_anom}.");
            }

            TipoAnomalia ntipo = new TipoAnomalia(tipo.Cod_anom, tipo.Nombre_anom, tipo.Dif_anom);
            tipoRepository.Add(ntipo);

            return tipo;
        }
        public bool Delete(int cod_anom)
        {
            TipoAnomaliaRepository tipoRepository = new TipoAnomaliaRepository();
            return tipoRepository.Delete(cod_anom);
        }

        public bool Update(TipoAnomaliaDTO tipo)
        {
            TipoAnomaliaRepository tipoRepository = new TipoAnomaliaRepository();

            if(tipoRepository.NombreExists(tipo.Nombre_anom, tipo.Cod_anom))
            {
                throw new ArgumentException($"Ya existe un tipo de anomalía con el código {tipo.Cod_anom}.");
            }
            TipoAnomalia tipoToUpdate = new TipoAnomalia(tipo.Cod_anom, tipo.Nombre_anom, tipo.Dif_anom);
            return tipoRepository.Update(tipoToUpdate);
        }
    }
}
