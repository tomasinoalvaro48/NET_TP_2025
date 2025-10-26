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

        public async Task<IEnumerable<TipoAnomaliaDTO>> GetAllAsync()
        {
            TipoAnomaliaRepository tipoRepository = new TipoAnomaliaRepository();
            var tipos = await tipoRepository.GetAllAsync();

            return tipos.Select(l => new TipoAnomaliaDTO
            {
                Cod_anom = l.Cod_anom,
                Nombre_anom = l.Nombre_anom,
                Dif_anom = l.Dif_anom,
            }).ToList();
        }

        public async Task<TipoAnomaliaDTO> AddAsync(TipoAnomaliaDTO tipo)
        {
            TipoAnomaliaRepository tipoRepository = new TipoAnomaliaRepository();

            if (await tipoRepository.NombreExistsAsync(tipo.Nombre_anom))
            {
                throw new ArgumentException($"Ya existe un tipo de anomalía con el código {tipo.Cod_anom}.");
            }

            TipoAnomalia ntipo = new TipoAnomalia(tipo.Nombre_anom, tipo.Dif_anom);
            await tipoRepository.AddAsync(ntipo);

            tipo.Cod_anom = ntipo.Cod_anom;

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

            TipoAnomalia tipoToUpdate = await tipoRepository.GetAsync(tipo.Cod_anom);

            if (tipoToUpdate == null)
                return false;

            tipoToUpdate.SetNombre_anom(tipo.Nombre_anom);
            tipoToUpdate.SetDif_anom(tipo.Dif_anom);

            return await tipoRepository.UpdateAsync(tipoToUpdate);
        }
    }
}