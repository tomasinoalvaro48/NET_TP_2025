using Data;
using Domain.Model;
using DTOs;

namespace Application.Services
{
    public class UsuarioService
    {
        public UsuarioDTO Add(UsuarioDTO dto)
        {
            var usuarioRepository = new UsuarioRepository();

            if (usuarioRepository.EmailExists(dto.Email_usu))
            {
                throw new ArgumentException($"Ya existe un usuario con el Email '{dto.Email_usu}'.");
            }

            Usuario usuario = new Usuario(0, dto.Nombre_usu, dto.Email_usu, dto.Passw_usu, dto.Tipo_usu, dto.ZonaId);
            usuarioRepository.Add(usuario);
            dto.Cod_usu = usuario.Cod_usu;
            return dto;
        }

        public bool Delete(int id)
        {
            var usuarioRepository = new UsuarioRepository();
            return usuarioRepository.Delete(id);
        }

        public UsuarioDTO Get(int id)
        {
            var usuarioRepository = new UsuarioRepository();
            Usuario? usuario = usuarioRepository.Get(id);

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

        public IEnumerable<UsuarioDTO> GetAll()
        {
            var usuarioRepository = new UsuarioRepository();
            var usuarios = usuarioRepository.GetAll();

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

        public bool Update(UsuarioDTO dto)
        {
            var usuarioRepository = new UsuarioRepository();

            if (usuarioRepository.EmailExists(dto.Email_usu, dto.Cod_usu))
            {
                throw new ArgumentException($"Ya existe otro usuario con el Email '{dto.Email_usu}'.");
            }

            Usuario usuario = new Usuario(dto.Cod_usu, dto.Nombre_usu, dto.Email_usu, dto.Passw_usu, dto.Tipo_usu, dto.ZonaId);
            return usuarioRepository.Update(usuario);
        }

        public IEnumerable<UsuarioDTO> GetByCriteria(CriteriaDTO criteriaDTO)
        {
            // Mapear DTO a Domain Model
            var criteria = new UsuarioCriteria(criteriaDTO.Texto);

            // Llamar al repositorio
            var usuarioRepository = new UsuarioRepository();
            var clientes = usuarioRepository.GetByCriteria(criteria);

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