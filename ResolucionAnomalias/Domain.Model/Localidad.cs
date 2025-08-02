using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Localidad
    {
        public int Codigo { get; private set; }
        public string Nombre { get; private set; }


        public Localidad(int codigo, string nombre)
        {
            SetId(codigo);
            SetNombre(nombre);
        }

        public void SetId(int codigo)
        {
            if (codigo < 0)
                throw new ArgumentException("El Id debe ser mayor que 0.", nameof(codigo));
            Codigo = codigo;
        }

        public void SetNombre(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre no puede ser nulo o vacío.", nameof(nombre));
            Nombre = nombre;
        }
    }
}
