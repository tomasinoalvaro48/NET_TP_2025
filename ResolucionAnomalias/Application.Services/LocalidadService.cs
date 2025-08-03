using System;
using System.Collections.Generic;
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


        public LocalidadDTO add(LocalidadDTO dto)
        {
            //int codigo_localidad = GentNextCodigoLocalidad();
            Localidad localidad = new Localidad(dto.Codigo, dto.Nombre);
            LocalidadInMemory.Localidades.Add(localidad);
            dto.Codigo = localidad.Codigo;
            return dto;
        }
        /*
        internal int GentNextCodigoLocalidad()
        {
            int nextcodigo;
            if (LocalidadInMemory.Localidades.Count > 0)
            {
                nextcodigo = LocalidadInMemory.Localidades.Max(x => x.Codigo) + 1;
            }
            else { nextcodigo = 1; }
            return nextcodigo;
        }
        */

        public bool delete(int codigo)
        {
            Localidad? localidadToDelete = LocalidadInMemory.Localidades.Find(x => x.Codigo == codigo);
            if (localidadToDelete != null)
            {
                LocalidadInMemory.Localidades.Remove(localidadToDelete);
                return true;
            }
            else { return false; }
        }

        public LocalidadDTO Get(int codigo)
        {
            Localidad? localidad = LocalidadInMemory.Localidades.Find(x => x.Codigo == codigo);
            if (localidad != null)
            {
                return new LocalidadDTO
                {
                    Codigo = localidad.Codigo,
                    Nombre = localidad.Nombre
                };
            }
            else
            {
                return null;
            }
            
        }

        public IEnumerable<LocalidadDTO> GetAll()
        {
            return LocalidadInMemory.Localidades.Select(localidad => new LocalidadDTO
            {
                Codigo=localidad.Codigo,
                Nombre=localidad.Nombre
            }).ToList();

        }

        public bool Update(LocalidadDTO dto)
        {
            Localidad? LocalidadToUpdate = LocalidadInMemory.Localidades.Find(x => x.Codigo == dto.Codigo);
            if (LocalidadToUpdate != null)
            {
                LocalidadToUpdate.SetId(dto.Codigo);
                LocalidadToUpdate.SetNombre(dto.Nombre);

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
