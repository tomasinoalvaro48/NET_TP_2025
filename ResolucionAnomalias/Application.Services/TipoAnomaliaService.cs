using Data;
using Domain.Model;
using DTOs;

namespace Application.Services
{
    public class TipoAnomaliaService
    {
        public async Task<TipoAnomaliaDTO> GetAsync(int cod_anom)
        {
            var tipoRepository = new TipoAnomaliaRepository();
            TipoAnomalia tipo = await tipoRepository.GetAsync(cod_anom);
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

        public async Task<IEnumerable<TipoAnomalia>> GetAllAsync()
        {
            TipoAnomaliaRepository tipoRepository = new TipoAnomaliaRepository();
            IEnumerable<TipoAnomalia> tipos = await tipoRepository.GetAllAsync();
            return tipos;
        }

        public async Task<TipoAnomaliaDTO> AddAsync(TipoAnomaliaDTO tipo)
        {
            TipoAnomaliaRepository tipoRepository = new TipoAnomaliaRepository();

            if (await tipoRepository.NombreExistsAsync(tipo.Nombre_anom))
            {
                throw new ArgumentException($"Ya existe un tipo de anomalía con el código {tipo.Cod_anom}.");
            }

            TipoAnomalia ntipo = new TipoAnomalia(tipo.Cod_anom, tipo.Nombre_anom, tipo.Dif_anom);
            await tipoRepository.AddAsync(ntipo);

            return tipo;
        }

        public async Task<bool> DeleteAsync(int cod_anom)
        {
            TipoAnomaliaRepository tipoRepository = new TipoAnomaliaRepository();
            return await tipoRepository.DeleteAsync(cod_anom);
        }

        public async Task<bool> UpdateAsync(TipoAnomaliaDTO tipo)
        {
            TipoAnomaliaRepository tipoRepository = new TipoAnomaliaRepository();

            if (await tipoRepository.NombreExistsAsync(tipo.Nombre_anom, tipo.Cod_anom))
            {
                throw new ArgumentException($"Ya existe un tipo de anomalía con el código {tipo.Cod_anom}.");
            }
            TipoAnomalia tipoToUpdate = new TipoAnomalia(tipo.Cod_anom, tipo.Nombre_anom, tipo.Dif_anom);
            return await tipoRepository.UpdateAsync(tipoToUpdate);
        }
    }
}