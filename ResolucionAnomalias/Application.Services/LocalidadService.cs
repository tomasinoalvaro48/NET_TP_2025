using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Domain.Model;
using DTOs;

namespace Application.Services
{
    public class LocalidadService
    {

        
        public LocalidadDTO Add(LocalidadDTO dto)
        {
            var localidadRepository = new LocalidadRepository();

            if (localidadRepository.CodigoExists(dto.Codigo))
            {
                throw new ArgumentException($"Ya existe una localidad con el código {dto.Codigo}.");
            }

            Localidad localidad = new Localidad(0, dto.Codigo, dto.Nombre);
            localidadRepository.Add(localidad);

            dto.ID = localidad.ID;

            return dto;
        }

        

        public bool delete(int id)
        {
            var localidadRepository = new LocalidadRepository();
            return localidadRepository.Delete(id);
        }

        public LocalidadDTO Get(int id)
        {
            var localidadRepository = new LocalidadRepository();
            Localidad? localidad = localidadRepository.GetById(id);
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

        public IEnumerable<LocalidadDTO> GetAll()
        {
            var localidadRepository = new LocalidadRepository();
            var localidades = localidadRepository.GetAll();

            return localidades.Select(l => new LocalidadDTO
            {
                ID= l.ID,
                Nombre = l.Nombre,
                Codigo = l.Codigo,
            }).ToList();
        }

        public bool Update(LocalidadDTO dto)
        {

            var localidadRespository = new LocalidadRepository();

            if (localidadRespository.CodigoExists(dto.Codigo,dto.ID))
            {
                throw new ArgumentException($"Ya existe otro cliente con el Codigo '{dto.Codigo}' .");
            }
            Localidad localidadToUpdate = new Localidad(dto.ID,dto.Codigo ,dto.Nombre);
            return localidadRespository.Update(localidadToUpdate);
            
        }
    }
}
