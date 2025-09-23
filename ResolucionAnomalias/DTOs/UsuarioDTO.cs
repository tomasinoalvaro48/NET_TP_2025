namespace DTOs
{
    public class UsuarioDTO
    {
        public int Cod_usu { get; set; }
        public string Nombre_usu { get; set; }
        public string Email_usu { get; set; }
        public string Passw_usu { get; set; }
        public string Tipo_usu { get; set; }

        public int ZonaId { get; set; }
        public string? ZonaNombre { get; set; }

        public int LocalidadId { set; get; }
        public string? LocalidadCodigo { set; get; }
        public string? LocalidadNombre { set; get; }
    }
}