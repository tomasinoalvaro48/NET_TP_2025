using Data;
using Domain.Model;
using DTOs;

namespace Application.Services
{
    public class LocalidadService
    {
        public async Task<LocalidadDTO> AddAsync(LocalidadDTO dto)
        {
            var localidadRepository = new LocalidadRepository();

            if (await localidadRepository.CodigoExistsAsync(dto.Codigo))
            {
                throw new ArgumentException($"Ya existe una localidad con el código {dto.Codigo}.");
            }

            Localidad localidad = new Localidad(dto.Codigo, dto.Nombre);
            await localidadRepository.AddAsync(localidad);

            dto.ID = localidad.ID;

            return dto;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var localidadRepository = new LocalidadRepository();
            return await localidadRepository.DeleteAsync(id);
        }

        public async Task<LocalidadDTO> GetAsync(int id)
        {
            var localidadRepository = new LocalidadRepository();
            Localidad? localidad = await localidadRepository.GetAsync(id);
            if (localidad == null)
            {
                return null;
            }
            else
            {
                return new LocalidadDTO
                {
                    ID = localidad.ID,
                    Codigo = localidad.Codigo,
                    Nombre = localidad.Nombre
                };
            }
        }

        public async Task<IEnumerable<LocalidadDTO>> GetAllAsync()
        {
            var localidadRepository = new LocalidadRepository();
            var localidades = await localidadRepository.GetAllAsync();

            return localidades.Select(l => new LocalidadDTO
            {
                ID= l.ID,
                Nombre = l.Nombre,
                Codigo = l.Codigo,
            }).ToList();
        }

        public async Task<bool> UpdateAsync(LocalidadDTO dto)
        {
            var localidadRepository = new LocalidadRepository();

            if (await localidadRepository.CodigoExistsAsync(dto.Codigo,dto.ID))
            {
                throw new ArgumentException($"Ya existe otro cliente con el Codigo '{dto.Codigo}' .");
            }

            Localidad localidadToUpdate = await localidadRepository.GetAsync(dto.ID);

            if (localidadToUpdate == null)
                return false;

            localidadToUpdate.SetCodigo(dto.Codigo);
            localidadToUpdate.SetNombre(dto.Nombre);

            return await localidadRepository.UpdateAsync(localidadToUpdate);
        }
    }
}