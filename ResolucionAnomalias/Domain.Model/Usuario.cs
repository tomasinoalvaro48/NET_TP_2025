using System.Text.RegularExpressions;

namespace Domain.Model
{
    public class Usuario
    {
        public int Cod_usu { get; set; }
        public string Nombre_usu { get; set; }
        public string Email_usu { get; set; }
        public string Passw_usu { get; set; }
        public string Tipo_usu { get; set; }

        private int _zonaId;
        private Zona? _zona;

        public int ZonaId
        {
            get => _zona?.Id ?? _zonaId;
            private set => _zonaId = value;
        }

        public Zona? Zona
        {
            get => _zona;
            private set
            {
                _zona = value;
                if (value != null && _zonaId != value.Id)
                {
                    _zonaId = value.Id;
                }
            }
        }

        public Usuario() { }

        public Usuario(int cod_usu, string nombre_usu, string email_usu, string passw_usu, string tipo_usu, int zonaId)
        {
            SetCod_usu(cod_usu);
            SetNombre_usu(nombre_usu);
            SetEmail_usu(email_usu);
            SetPassw_usu(passw_usu);
            SetTipo_usu(tipo_usu);
            SetZonaId(zonaId);
        }

        public void SetCod_usu(int cod_usu)
        {
            if (cod_usu < 0)
                throw new ArgumentException("El código del usuario debe ser mayor que 0.", nameof(cod_usu));
            Cod_usu = cod_usu;
        }

        public void SetNombre_usu(string nombre_usu)
        {
            if (string.IsNullOrWhiteSpace(nombre_usu))
                throw new ArgumentException("El nombre no puede ser nulo o vacío.", nameof(nombre_usu));
            Nombre_usu = nombre_usu;
        }

        public void SetEmail_usu(string email_usu)
        {
            if (!EsEmailValido(email_usu))
                throw new ArgumentException("El email no puede ser nulo o vacío.", nameof(email_usu));
            Email_usu = email_usu;
        }

        public void SetPassw_usu(string passw_usu)
        {
            if (string.IsNullOrWhiteSpace(passw_usu))
                throw new ArgumentException("La contraseña no puede ser nula o vacía.", nameof(passw_usu));
            Passw_usu = passw_usu;
        }

        public void SetTipo_usu(string tipo_usu)
        {
            if (string.IsNullOrWhiteSpace(tipo_usu))
                throw new ArgumentException("El tipo de usuario no puede ser nulo o vacío.", nameof(tipo_usu));
            Tipo_usu = tipo_usu;
        }

        private static bool EsEmailValido(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        public bool ValidarContrasenia(string password)
        {
            if (string.IsNullOrWhiteSpace(password)) return false;
            return true;
        }

        public void SetZonaId(int zonaId)
        {
            if (zonaId <= 0)
                throw new ArgumentException("El Id de la zona debe ser mayor que 0.", nameof(zonaId));
            _zonaId = zonaId;

            if (_zona != null && _zona.Id != zonaId)
            {
                _zona = null;
            }
        }

        public void SetZona(Zona zona)
        {
            ArgumentNullException.ThrowIfNull(zona);
            _zona = zona;
            _zonaId = zona.Id;
        }
    }
}