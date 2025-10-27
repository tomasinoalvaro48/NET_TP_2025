namespace DTOs
{
    public class PedidoAgregacionDTO
    {
        public int Id_pedido_agreg { get; set; }
        public string Descripcion_pedido_agreg { get; set; }
        public int Dificultad_pedido_agreg { get; set; }
        public string Estado_pedido_agreg { get; set; }


        public int CazadorId { get; set; }

        public string? NombreCazador { get; set; }

        public int? TipoAnomaliaId { get; set; }

        public string? NombreTipoAnomalia {  get; set; }



    }
}