namespace DTOs
{
    public class PedidoResolucionDTO
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Direccion {  get; set; }

        public string Descripcion { get; set; }

        public string Estado { get; set; }

        public string? Comentario { get; set; }

        public int Dificultad => Anomalias?.Sum(i => i.TipoAnomaliaDificultad) ?? 0;

        public int ZonaId { get; set; }
        public string? ZonaNombre { get; set; }

        public int LocalidadId { set; get; }
        public string? LocalidadCodigo { set; get; }
        public string? LocalidadNombre { set; get; }


        public int? CazadorId { get; set; }
        public string? CazadorNombre { get; set; }


        public int DenuncianteId { get; set; }
        public string? DenuncianteNombre { get; set; }


        public List<AnomaliaPedidoDTO> Anomalias { get; set; } = new List<AnomaliaPedidoDTO>();


    }
}
