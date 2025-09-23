namespace DTOs
{
    public class ZonaDTO
    {
        public int Id {  get; set; }
        public string Nombre { get; set; }

        public int LocalidadId { set; get; }
        public string? LocalidadCodigo { set; get; }
        public string? LocalidadNombre { set; get; }   
    }
}