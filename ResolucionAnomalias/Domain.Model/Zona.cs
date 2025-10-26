namespace Domain.Model
{
    public class Zona
    {
        public int Id { get; private set; }
        public string Nombre { get; private set; }

        private int _localidadId;
        private Localidad? _localidad;

        public int LocalidadId
        {
            get => _localidad?.ID ?? _localidadId;
            private set => _localidadId = value;
        }

        public Localidad? Localidad
        {
            get => _localidad;
            private set
            {
                _localidad = value;
                if (value != null && _localidadId != value.ID)
                {
                    _localidadId = value.ID;
                }
            }
        }

        public Zona() { }

        public Zona(string nombre, int localidadId)
        {
            SetNombre(nombre);
            SetLocalidadId(localidadId);
        }

        public void SetNombre(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre no puede ser nulo o vacío.", nameof(nombre));
            Nombre = nombre;
        }

        public void SetLocalidadId(int localidadId)
        {
            if(localidadId < 0)
                throw new ArgumentException("El PaisId debe ser mayor que 0.", nameof(localidadId));
            _localidadId = localidadId;

            if(_localidad != null && _localidad.ID != localidadId)
            { _localidad = null; }
        }

        public void SetLocalidad(Localidad localidad)
        {
            ArgumentNullException.ThrowIfNull(localidad);
            _localidad = localidad;
            _localidadId = localidad.ID;
        }
    }
}