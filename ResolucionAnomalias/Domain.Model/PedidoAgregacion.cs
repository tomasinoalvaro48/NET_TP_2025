namespace Domain.Model
{
    public class PedidoAgregacion
    {
        public int Id_pedido_agreg { get; private set; }
        public string Descripcion_pedido_agreg { get; private set; }
        public int Dificultad_pedido_agreg { get; private set; }
        public string Estado_pedido_agreg { get; private set; }

        public PedidoAgregacion() { }

        public PedidoAgregacion(int id, string descripcion, int dificultad, string estado)
        {
            SetId(id);
            SetDescripcion(descripcion);
            SetDificultad(dificultad);
            SetEstado(estado);
        }

        public void SetId(int id)
        {
            if (id < 0)
                throw new ArgumentException("El id debe ser mayor que 0.", nameof(id));
            Id_pedido_agreg = id;
        }

        public void SetDescripcion(string descripcion)
        {
            if (string.IsNullOrWhiteSpace(descripcion))
                throw new ArgumentException("La descripcion no puede ser nula o vacía.", nameof(descripcion));
            Descripcion_pedido_agreg = descripcion;
        }

        public void SetDificultad(int dificultad)
        {
            if (dificultad < 0)
                throw new ArgumentException("La dificultad debe ser mayor que 0.", nameof(dificultad));
            Dificultad_pedido_agreg = dificultad;
        }

        public void SetEstado(string estado)
        {
            if (string.IsNullOrWhiteSpace(estado))
                throw new ArgumentException("El estado no puede ser nulo o vacío.", nameof(estado));
            Estado_pedido_agreg = estado;
        }
    }
}