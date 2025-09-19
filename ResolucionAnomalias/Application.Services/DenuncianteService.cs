using Domain.Model;
using Data;
using DTOs;

namespace Application.Services
{
    public class DenuncianteService
    {
        public DenuncianteDTO Add(DenuncianteDTO dto)
        {
            var denuncianteRepository = new DenuncianteRepository();
            Denunciante denunciante = new Denunciante(0, dto.Nombre_den, dto.Telefono, dto.Direccion_den);
            denuncianteRepository.Add(denunciante);
            dto.Cod_den = denunciante.Cod_den;
            return dto;
        }

        public bool Delete(int cod_den)
        {
            var denuncianteRepository = new DenuncianteRepository();
            return denuncianteRepository.Delete(cod_den);
        }

        public DenuncianteDTO Get(int cod_den)
        {
            var denuncianteRepository = new DenuncianteRepository();
            Denunciante? denunciante = denuncianteRepository.Get(cod_den);

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
            var denuncianteRepository = new DenuncianteRepository();
            var denunciantes = denuncianteRepository.GetAll();

            return denunciantes.Select(denunciante => new DenuncianteDTO
            {
                Cod_den = denunciante.Cod_den,
                Nombre_den = denunciante.Nombre_den,
                Telefono = denunciante.Telefono,
                Direccion_den = denunciante.Direccion_den
            }).ToList();
        }

        public bool Update(DenuncianteDTO dto)
        {
            var denuncianteRepository = new DenuncianteRepository();
            Denunciante denunciante = new Denunciante(dto.Cod_den, dto.Nombre_den, dto.Telefono, dto.Direccion_den);
            return denuncianteRepository.Update(denunciante);
        }

        /*private static int GetNextCod_den()
        {
            int nextCod_den;
            if (DenuncianteRepository.Denunciantes.Count > 0)
            {
                nextCod_den = DenuncianteRepository.Denunciantes.Max(x => x.Cod_den) + 1;
            }
            else
            {
                nextCod_den = 1;
            }
            return nextCod_den;
        }*/
    }
}