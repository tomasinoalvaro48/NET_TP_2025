using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Domain.Model
{
    public class Zona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

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

        public Zona(int id, string nombre, int localidadId)
        {
            SetId(id);
            SetNombre(nombre);
            SetLocalidadId(localidadId);

        }
        public void SetId(int id)
        {
            if (id < 0)
                throw new ArgumentException("El Id debe ser mayor que 0.", nameof(id));
            Id = id;
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
