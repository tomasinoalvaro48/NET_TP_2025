using Data;
using Domain.Model;
using DTOs;

namespace Application.Services
{
    public class ZonaService
    {
        public ZonaDTO Add(ZonaDTO dto)
        {
            var zonaRepository = new ZonaRepository();
            //FALTA VALIDAR QUE PARA ESA LOCALIDAD NO SE PUEDA AGREGAR DOS ZONAS IGUALES
        
            Zona zona = new Zona(0, dto.Nombre, dto.LocalidadId);

            zonaRepository.Add(zona);
            
            dto.Id = zona.Id;

            return dto;

        }

        public bool Delete(int id)
        {
            var zonaRepository = new ZonaRepository();
            return zonaRepository.Delete(id);
        }


        public ZonaDTO Get(int id) 
        {
            var zonaRepository = new ZonaRepository();
            Zona? zona = zonaRepository.Get(id);

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

        public IEnumerable<ZonaDTO> GetAll() 
        {
            var zonaRepository = new ZonaRepository();
            var zonas = zonaRepository.GetAll();

            return zonas.Select(zona => new ZonaDTO
            {
                Id = zona.Id,
                Nombre = zona.Nombre,
                LocalidadId = zona.LocalidadId,
                LocalidadCodigo = zona.Localidad?.Codigo.ToString(),
                LocalidadNombre = zona.Localidad?.Nombre
            }).ToList();
        }


        public bool Update(ZonaDTO dto)
        {
            var zonaRepository = new ZonaRepository();

            //FALTA VALIDAR QUE PARA ESA LOCALIDAD NO SE PUEDA AGREGAR DOS ZONAS IGUALES

            Zona zona = new Zona(dto.Id, dto.Nombre, dto.LocalidadId);

            return zonaRepository.Update(zona);

        }


    }
}
