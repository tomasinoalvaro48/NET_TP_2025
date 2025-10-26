using Data;
using Domain.Model;
using DTOs;

namespace Application.Services
{
    public class ZonaService
    {
        public async Task<ZonaDTO> AddAsync(ZonaDTO dto)
        {
            var zonaRepository = new ZonaRepository();
            Zona zona = new Zona(dto.Nombre, dto.LocalidadId);
            if (await zonaRepository.NombreExistsAsync(dto.LocalidadId, dto.Nombre))
            {
                throw new ArgumentException($"Ya existe una Zona con el Nombre: '{dto.Nombre}' para esa Localidad.");
            }
            await zonaRepository.AddAsync(zona);
            dto.Id = zona.Id;
            return dto;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var zonaRepository = new ZonaRepository();
            return await zonaRepository.DeleteAsync(id);
        }

        public async Task<ZonaDTO> GetAsync(int id) 
        {
            var zonaRepository = new ZonaRepository();
            Zona? zona = await zonaRepository.GetAsync(id);

            if (zona == null)
            {
                return null;
            }
            else
            {
                return new ZonaDTO
                {
                    Id = zona.Id,
                    Nombre = zona.Nombre,
                    LocalidadId = zona.LocalidadId,
                };
            }
        }

        public async Task<IEnumerable<ZonaDTO>> GetAllAsync() 
        {
            var zonaRepository = new ZonaRepository();
            var zonas = await zonaRepository.GetAllAsync();

            return zonas.Select(zona => new ZonaDTO
            {
                Id = zona.Id,
                Nombre = zona.Nombre,
                LocalidadId = zona.LocalidadId,
                LocalidadCodigo = zona.Localidad?.Codigo.ToString(),
                LocalidadNombre = zona.Localidad?.Nombre
            }).ToList();
        }

        public async Task<bool> UpdateAsync(ZonaDTO dto)
        {
            var zonaRepository = new ZonaRepository();

            if (await zonaRepository.NombreExistsAsync(dto.LocalidadId, dto.Nombre))
            {
                throw new ArgumentException($"Ya existe una Zona con el Nombre: '{dto.Nombre}' para esa Localidad.");
            }

            var zona = await zonaRepository.GetAsync(dto.Id);
            
            if (zona == null)
                return false;

            zona.SetNombre(dto.Nombre);
            zona.SetLocalidadId(dto.LocalidadId);

            return await zonaRepository.UpdateAsync(zona);
        }

        public async Task<IEnumerable<ZonaDTO>> GetByLocalidadAsync(int id_loc)
        {
            var zonaRepository = new ZonaRepository();
            var zonas = await zonaRepository.GetByLocalidadAsync(id_loc);
            return zonas.Select(zona => new ZonaDTO
            {
                Id = zona.Id,
                Nombre = zona.Nombre,
                LocalidadId = zona.LocalidadId,
                LocalidadCodigo = zona.Localidad?.Codigo.ToString(),
                LocalidadNombre = zona.Localidad?.Nombre
            }).ToList();
        }
    }
}