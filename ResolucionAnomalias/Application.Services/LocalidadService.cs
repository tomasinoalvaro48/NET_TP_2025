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
            int id_localidad = GentNextIDLocalidad();
            Localidad localidad = new Localidad(id_localidad, dto.Codigo, dto.Nombre);
            LocalidadInMemory.Localidades.Add(localidad);
            dto.ID = localidad.ID;
            return dto;
        }
        
        internal int GentNextIDLocalidad()
        {
            int nextID;
            if (LocalidadInMemory.Localidades.Count > 0)
            {
                nextID = LocalidadInMemory.Localidades.Max(x => x.ID) + 1;
            }
            else { nextID = 1; }
            return nextID;
        }
        

        public bool delete(int id)
        {
            Localidad? localidadToDelete = LocalidadInMemory.Localidades.Find(x => x.ID == id);
            if (localidadToDelete != null)
            {
                LocalidadInMemory.Localidades.Remove(localidadToDelete);
                return true;
            }
            else { return false; }
        }

        public LocalidadDTO Get(int id)
        {
            Localidad? localidad = LocalidadInMemory.Localidades.Find(x => x.ID == id);
            if (localidad != null)
            {
                return new LocalidadDTO
                {
                    ID = localidad.ID,
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
                ID = localidad.ID,
                Codigo = localidad.Codigo,
                Nombre=localidad.Nombre
            }).ToList();

        }

        public bool Update(LocalidadDTO dto)
        {
            Localidad? LocalidadToUpdate = LocalidadInMemory.Localidades.Find(x => x.ID == dto.ID);
            if (LocalidadToUpdate != null)
            {
                LocalidadToUpdate.SetCodigo(dto.Codigo);
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
