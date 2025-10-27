using Data;
using Domain.Model;
using DTOs;

namespace Application.Services
{
    public class UsuarioService
    {
        public async Task<UsuarioDTO> AddAsync(UsuarioCreateDTO createDto)
        {
            var usuarioRepository = new UsuarioRepository();

            if (await usuarioRepository.EmailExistsAsync(createDto.Email_usu))
            {
                throw new ArgumentException($"Ya existe un usuario con el Email '{createDto.Email_usu}'.");
            }

            Usuario usuario = new Usuario(createDto.Nombre_usu, createDto.Email_usu, createDto.Passw_usu, createDto.Tipo_usu, createDto.ZonaId);
            
            await usuarioRepository.AddAsync(usuario);

            return new UsuarioDTO
            {
                Cod_usu = usuario.Cod_usu,
                Nombre_usu = usuario.Nombre_usu,
                Email_usu = usuario.Email_usu,
                Tipo_usu = usuario.Tipo_usu,
                ZonaId = usuario.ZonaId
            };
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var usuarioRepository = new UsuarioRepository();
            return await usuarioRepository.DeleteAsync(id);
        }

        public async Task<UsuarioDTO?> GetAsync(int id)
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
                Tipo_usu = usuario.Tipo_usu,
                ZonaId = usuario.ZonaId,
                ZonaNombre = usuario.Zona?.Nombre,
                LocalidadId = usuario.Zona?.LocalidadId ?? 0,
                LocalidadCodigo = usuario.Zona?.Localidad?.Codigo.ToString(),
                LocalidadNombre = usuario.Zona?.Localidad?.Nombre
            }).ToList();
        }

        public async Task<UsuarioUpdateDTO> GetByEmailAsync(string email)
        {
            var usuarioRepository = new UsuarioRepository();
            Usuario? usuario = await usuarioRepository.GetByEmailAsync(email);
            if (usuario == null)
            {
                return null;
            }
            else
            {
                return new UsuarioUpdateDTO
                {
                    Cod_usu = usuario.Cod_usu,
                    Nombre_usu = usuario.Nombre_usu,
                    Passw_usu = usuario.Passw_usu,
                    Email_usu = usuario.Email_usu,
                    Salt = usuario.Salt,
                    Tipo_usu = usuario.Tipo_usu,
                    ZonaId = usuario.ZonaId,
                };
            }
        } 

        public async Task<bool> UpdateAsync(UsuarioUpdateDTO updateDto)
        {
            var usuarioRepository = new UsuarioRepository();

            if (await usuarioRepository.EmailExistsAsync(updateDto.Email_usu, updateDto.Cod_usu))
            {
                throw new ArgumentException($"Ya existe otro usuario con el Email '{updateDto.Email_usu}'.");
            }

            var usuario = await usuarioRepository.GetAsync(updateDto.Cod_usu);
            if (usuario == null)
                return false;

            usuario.SetNombre_usu(updateDto.Nombre_usu);
            usuario.SetEmail_usu(updateDto.Email_usu);
            usuario.SetTipo_usu(updateDto.Tipo_usu);
            usuario.SetZonaId(updateDto.ZonaId);

            if (!string.IsNullOrWhiteSpace(updateDto.Passw_usu))
            {
                usuario.SetPassw_usu(updateDto.Passw_usu);
            }

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