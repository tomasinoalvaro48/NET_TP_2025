using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class AnomaliaPedido
    {

        public int PedidoId { get; private set; }

        private int _tipoAnomaliaId;
        private TipoAnomalia? _tipoAnomalia;

        public int TipoAnomaliaId
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

        public AnomaliaPedido(int pedidoId, int tipoAnomaliaId) {
            SetPedidoId(pedidoId);
            SetTipoAnomaliaId(tipoAnomaliaId);
        }

        public void SetPedidoId(int pedidoId)
        {
            if (pedidoId < 0)
                throw new ArgumentException("El Id del pedido debe ser mayor que 0.", nameof(pedidoId));
            PedidoId = pedidoId;
        }

        public void SetTipoAnomaliaId(int tipoAnomaliaId)
        {
            if(tipoAnomaliaId < 0) throw new ArgumentException("El id del tipo de anomalia debe ser mayor a 0",nameof(tipoAnomaliaId));

            _tipoAnomaliaId = tipoAnomaliaId;

            if(_tipoAnomalia != null && _tipoAnomalia.Cod_anom != tipoAnomaliaId)
            {
                _tipoAnomalia = null;
            }

        }

        public void SetTipoAnomalia(TipoAnomalia tipoAnomalia)
        {
            ArgumentNullException.ThrowIfNull(tipoAnomalia);
            _tipoAnomalia = tipoAnomalia;
            _tipoAnomaliaId = tipoAnomalia.Cod_anom;
        }





    }
}
