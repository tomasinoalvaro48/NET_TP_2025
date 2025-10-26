using Data;
using Domain.Model;
using DTOs;

namespace Application.Services
{
    public class UsuarioService
    {
        public async Task<UsuarioDTO> AddAsync(UsuarioDTO dto)
        {
            var usuarioRepository = new UsuarioRepository();

            if (await usuarioRepository.EmailExistsAsync(dto.Email_usu))
            {
                throw new ArgumentException($"Ya existe un usuario con el Email '{dto.Email_usu}'.");
            }

            Usuario usuario = new Usuario(0, dto.Nombre_usu, dto.Email_usu, dto.Passw_usu, dto.Tipo_usu, dto.ZonaId);
            await usuarioRepository.AddAsync(usuario);
            dto.Cod_usu = usuario.Cod_usu;
            return dto;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var usuarioRepository = new UsuarioRepository();
            return await usuarioRepository.DeleteAsync(id);
        }

        public async Task<UsuarioDTO> GetAsync(int id)
        {
            var usuarioRepository = new UsuarioRepository();
            Usuario? usuario = await usuarioRepository.GetAsync(id);

            if (usuario == null)
            {
                return null;
            }
            else
            {
                return new UsuarioDTO
                {
                    Cod_usu = usuario.Cod_usu,
                    Nombre_usu = usuario.Nombre_usu,
                    Email_usu = usuario.Email_usu,
                    Passw_usu = usuario.Passw_usu,
                    Tipo_usu = usuario.Tipo_usu,
                    ZonaId = usuario.ZonaId,
                    ZonaNombre = usuario.Zona?.Nombre,
                    LocalidadId = usuario.Zona?.LocalidadId ?? 0,
                    LocalidadCodigo = usuario.Zona?.Localidad?.Codigo.ToString(),
                    LocalidadNombre = usuario.Zona?.Localidad?.Nombre
                };
            }
        }

        public async Task<IEnumerable<UsuarioDTO>> GetAllAsync()
        {
            var usuarioRepository = new UsuarioRepository();
            var usuarios = await usuarioRepository.GetAllAsync();

            return usuarios.Select(usuario => new UsuarioDTO
            {
                Cod_usu = usuario.Cod_usu,
                Nombre_usu = usuario.Nombre_usu,
                Email_usu = usuario.Email_usu,
                Passw_usu = usuario.Passw_usu,
                Tipo_usu = usuario.Tipo_usu,
                ZonaId = usuario.ZonaId,
                ZonaNombre = usuario.Zona?.Nombre,
                LocalidadId = usuario.Zona?.LocalidadId ?? 0,
                LocalidadCodigo = usuario.Zona?.Localidad?.Codigo.ToString(),
                LocalidadNombre = usuario.Zona?.Localidad?.Nombre
            }).ToList();
        }

        public async Task<bool> UpdateAsync(UsuarioDTO dto)
        {
            var usuarioRepository = new UsuarioRepository();

            if (await usuarioRepository.EmailExistsAsync(dto.Email_usu, dto.Cod_usu))
            {
                throw new ArgumentException($"Ya existe otro usuario con el Email '{dto.Email_usu}'.");
            }

            Usuario usuario = new Usuario(dto.Cod_usu, dto.Nombre_usu, dto.Email_usu, dto.Passw_usu, dto.Tipo_usu, dto.ZonaId);
            return await usuarioRepository.UpdateAsync(usuario);
        }

        public async Task<IEnumerable<UsuarioDTO>> GetByCriteriaAsync(CriteriaDTO criteriaDTO)
        {
            // Mapear DTO a Domain Model
            var criteria = new UsuarioCriteria(criteriaDTO.Texto);

            // Llamar al repositorio
            var usuarioRepository = new UsuarioRepository();
            var clientes = await usuarioRepository.GetByCriteriaAsync(criteria);

            // Mapear Domain Model a DTO
            return clientes.Select(usuario => new UsuarioDTO
            {
                Cod_usu = usuario.Cod_usu,
                Nombre_usu = usuario.Nombre_usu,
                Email_usu = usuario.Email_usu,
                Passw_usu = usuario.Passw_usu,
                Tipo_usu = usuario.Tipo_usu,
                ZonaId = usuario.ZonaId,
                ZonaNombre = usuario.Zona?.Nombre,
                LocalidadId = usuario.Zona?.LocalidadId ?? 0,
                LocalidadCodigo = usuario.Zona?.Localidad?.Codigo.ToString(),
                LocalidadNombre = usuario.Zona?.Localidad?.Nombre
            });
        }
    }
}