namespace Domain.Model
{
    public class Localidad
    {
        public int ID { get; private set; }
        public int Codigo { get; private set; }
        public string Nombre { get; private set; }

        public Localidad() { }

        public Localidad(int id, int codigo, string nombre)
        {
            SetId(id);
            SetCodigo(codigo);
            SetNombre(nombre);
        }

        public void SetId(int id)
        {
            if (id < 0)
                throw new ArgumentException("El Id debe ser mayor que 0.", nameof(id));
            ID = id;
        }

        public void SetCodigo(int codigo)
        {
            if (codigo < 0)
                throw new ArgumentException("El Codigo debe ser mayor que 0.", nameof(codigo));
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