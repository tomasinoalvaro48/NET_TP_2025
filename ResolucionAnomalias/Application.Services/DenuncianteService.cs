using Domain.Model;
using Data;
using DTOs;

namespace Application.Services
{
    public class DenuncianteService
    {
        public DenuncianteDTO Add(DenuncianteDTO dto)
        {
            var cod_den = GetNextCod_den();
            Denunciante denunciante = new Denunciante(cod_den, dto.Nombre_den, dto.Telefono, dto.Direccion_den);
            DenuncianteInMemory.Denunciantes.Add(denunciante);
            dto.Cod_den = denunciante.Cod_den;
            return dto;
        }

        public bool Delete(int cod_den)
        {
            Denunciante? denuncianteToDelete = DenuncianteInMemory.Denunciantes.Find(x => x.Cod_den == cod_den);
            if (denuncianteToDelete != null)
            {
                DenuncianteInMemory.Denunciantes.Remove(denuncianteToDelete);
                return true;
            }
            else
            {
                return false;
            }
        }

        public DenuncianteDTO Get(int cod_den)
        {
            Denunciante? denunciante = DenuncianteInMemory.Denunciantes.Find(x => x.Cod_den == cod_den);

            if (denunciante == null)
                return null;

            return new DenuncianteDTO
            {
                Cod_den = denunciante.Cod_den,
                Nombre_den = denunciante.Nombre_den,
                Telefono = denunciante.Telefono,
                Direccion_den = denunciante.Direccion_den
            };
        }

        public IEnumerable<DenuncianteDTO> GetAll()
        {
            return DenuncianteInMemory.Denunciantes.Select(denunciante => new DenuncianteDTO
            {
                Cod_den = denunciante.Cod_den,
                Nombre_den = denunciante.Nombre_den,
                Telefono = denunciante.Telefono,
                Direccion_den = denunciante.Direccion_den
            }).ToList();
        }

        public bool Update(DenuncianteDTO dto)
        {
            Denunciante? denuncianteToUpdate = DenuncianteInMemory.Denunciantes.Find(x => x.Cod_den == dto.Cod_den);
            if (denuncianteToUpdate != null)
            {
                denuncianteToUpdate.SetNombre_den(dto.Nombre_den);
                denuncianteToUpdate.SetTelefono(dto.Telefono);
                denuncianteToUpdate.SetDireccion_den(dto.Direccion_den);
                return true;
            }
            else
            {
                return false;
            }
        }

        private static int GetNextCod_den()
        {
            int nextCod_den;
            if (DenuncianteInMemory.Denunciantes.Count > 0)
            {
                nextCod_den = DenuncianteInMemory.Denunciantes.Max(x => x.Cod_den) + 1;
            }
            else
            {
                nextCod_den = 1;
            }
            return nextCod_den;
        }
    }
}