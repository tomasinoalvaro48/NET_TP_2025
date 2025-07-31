namespace Domain.Model
{
    public class Denunciante
    {
        public int Cod_den { get; private set; }
        public string Nombre_den { get; private set; }
        public int Telefono { get; private set; }
        public string Direccion_den { get; private set; }

        public Denunciante(int cod_den, string nombre_den, int telefono, string direccion_den)
        {
            SetCod_den(cod_den);
            SetNombre_den(nombre_den);
            SetTelefono(telefono);
            SetDireccion_den(direccion_den);
        }

        public void SetCod_den(int cod_den)
        {
            if (cod_den < 0)
                throw new ArgumentException("El código del denunciante debe ser mayor que 0.", nameof(cod_den));
            Cod_den = cod_den;
        }

        public void SetNombre_den(string nombre_den)
        {
            if (string.IsNullOrWhiteSpace(nombre_den))
                throw new ArgumentException("El nombre no puede ser nulo o vacío.", nameof(nombre_den));
            Nombre_den = nombre_den;
        }

        public void SetTelefono(int telefono)
        {
            if (telefono == 0)
                throw new ArgumentException("El telefono no puede ser nulo o vacío.", nameof(telefono));
            Telefono = telefono;
        }

        public void SetDireccion_den(string direccion_den)
        {
            if (string.IsNullOrWhiteSpace(direccion_den))
                throw new ArgumentException("La dirección no puede ser nula o vacía.", nameof(direccion_den));
            Direccion_den = direccion_den;
        }
    }
}