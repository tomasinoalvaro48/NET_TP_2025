namespace Domain.Model
{
    public class PedidoAgregacion
    {
        public int Id_pedido_agreg { get; private set; }
        public string Descripcion_pedido_agreg { get; private set; }
        public int Dificultad_pedido_agreg { get; private set; }
        public string Estado_pedido_agreg { get; private set; }



        private int _cazadorId;
        private Usuario? _cazador;

        public int CazadorId
        {
            get => _cazador?.Cod_usu ?? _cazadorId;
            private set => _cazadorId = value;
        }


        public Usuario? Cazador
        {
            get => _cazador;
            private set
            {
                _cazador = value;
                if (value != null && _cazadorId != value.Cod_usu)
                {
                    _cazadorId = value.Cod_usu;
                }
            }
        }


        private int? _tipoAnomaliaId;
        private TipoAnomalia? _tipoAnomalia;

        public int? TipoAnomaliaId
        {
            get => _tipoAnomalia?.Cod_anom ?? _tipoAnomaliaId;
            private set => _tipoAnomaliaId = value;
        }


        public TipoAnomalia? TipoAnomalia
        {
            get => _tipoAnomalia;
            private set
            {
                _tipoAnomalia = value;
                if (value != null && _tipoAnomaliaId != value.Cod_anom)
                {
                    _tipoAnomaliaId = value.Cod_anom;
                }
            }
        }




        public PedidoAgregacion() { }

        public PedidoAgregacion(string descripcion, int dificultad, string estado, int idCazador) 
        {
            SetDescripcion(descripcion);
            SetDificultad(dificultad);
            SetEstado(estado);
            CazadorId = idCazador;
            TipoAnomaliaId = null;

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

        public void SetTipoAnomalia(int? idTipoAnomalia)
        {
            if(idTipoAnomalia != null)
            {
                this.TipoAnomaliaId = idTipoAnomalia;
            }
        }




    }
}