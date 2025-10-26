
namespace Domain.Model
{
    public class PedidoResolucion
    {

        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Direccion { get; set; }

        public string? Descripcion { get; set; }

        public string Estado { get; set; }

        public string? Comentario { get; set; }

        public int Dificultad { get; set; }



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



        private int _denuncianteId;
        private Usuario? _denunciante;

        public int DenuncianteId
        {
            get => _denunciante?.Cod_usu ?? _denuncianteId;
            private set => _denuncianteId = value;
        }


        public Usuario? Denunciante
        {
            get => _denunciante;
            private set
            {
                _denunciante = value;
                if (value != null && _denuncianteId != value.Cod_usu)
                {
                    _denuncianteId = value.Cod_usu;
                }
            }
        }






        private int _cazadorId;
        private Usuario? _cazador;

        public int CazadorId
        {
            get => _denunciante?.Cod_usu ?? _denuncianteId;
            private set => _denuncianteId = value;
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

        private readonly List<AnomaliaPedido> _anomaliaPedido = new();
        public IReadOnlyCollection<AnomaliaPedido> AnomaliaPedidos => _anomaliaPedido.AsReadOnly();




        public PedidoResolucion()
        {
        }

        public PedidoResolucion(int id, DateTime fecha, string direccion, string descripcion, string estado, string comentario, int dificultad, int zonaId, int denuncianteId, int cazadorId)
        {
            setId(id);
            setFecha(fecha);
            setDireccion(direccion);
            setDescripcion(descripcion);
            setEstado(estado);
            setComentario(comentario);
            setDificultad(dificultad);

            SetZonaId(zonaId);
            SetCazadorId(cazadorId);
            SetDenuncianteId(denuncianteId);

        }


        public void setId(int id)
        {
            if (id < 0)
                throw new ArgumentException("El id debe ser mayor o igual a 0.", nameof(id));
            Id = id;
        }

        public void setFecha(DateTime fecha)
        {
            if (fecha > DateTime.Now)
                throw new ArgumentException("La fecha no puede ser futura.", nameof(fecha));
            Fecha = fecha;
        }

        public void setDireccion(string direccion)
        {
            if (string.IsNullOrWhiteSpace(direccion))
                throw new ArgumentException("La dirección no puede ser nula o vacía.", nameof(direccion));
            Direccion = direccion;
        }

        public void setDescripcion(string descripcion)
        {
            // if (string.IsNullOrWhiteSpace(descripcion))
            //   throw new ArgumentException("La descripción no puede ser nula o vacía.", nameof(descripcion));
            Descripcion = descripcion;
        }


        public void setEstado(string estado)
        {
            if (string.IsNullOrWhiteSpace(estado))
                throw new ArgumentException("El estado no puede ser nulo o vacío.", nameof(estado));
            Estado = estado;
        }


        public void setComentario(string comentario)
        {
            Comentario = comentario;
        }

        public void setDificultad(int dificultad)
        {
            if (dificultad < 0)
                throw new ArgumentException("La dificultad no puede ser negativa", nameof(dificultad));
            Dificultad = dificultad;
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


        public void SetCazadorId(int cazadorId)
        {
            if (cazadorId <= 0)
                throw new ArgumentException("El Id del cazador debe ser mayor que 0.", nameof(cazadorId));
            _cazadorId = cazadorId;

            if (_cazador != null && _cazador.Cod_usu != cazadorId)
            {
                _cazador = null;
            }
        }

        public void SetCazador(Usuario cazador)
        {
            ArgumentNullException.ThrowIfNull(cazador);
            _cazador = cazador;
            _cazadorId = cazador.Cod_usu;
        }


        public void SetDenuncianteId(int denuncianteId)
        {
            if (denuncianteId <= 0)
                throw new ArgumentException("El Id del denunciante debe ser mayor que 0.", nameof(denuncianteId));
            _denuncianteId = denuncianteId;

            if (_denunciante != null && _denunciante.Cod_usu != denuncianteId)
            {
                _denunciante = null;
            }
        }

        public void SetDenunciante(Usuario denunciante)
        {
            ArgumentNullException.ThrowIfNull(denunciante);
            _denunciante = denunciante;
            _denuncianteId = denunciante.Cod_usu;
        }

        public void AddAnomaliaPedido(AnomaliaPedido anomaliaPedido)
        {
            ArgumentNullException.ThrowIfNull(anomaliaPedido);
            _anomaliaPedido.Add(anomaliaPedido);
        }

        public void RemoveAnomaliaPedido(AnomaliaPedido anomaliaPedido)
        {
            ArgumentNullException.ThrowIfNull(anomaliaPedido);
            _anomaliaPedido.Remove(anomaliaPedido);

        }

        public void ClearAnomaliaPedidos()
        {
            _anomaliaPedido.Clear();

        }
    }
}
