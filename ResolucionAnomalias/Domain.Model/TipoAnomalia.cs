namespace Domain.Model
{
    public class TipoAnomalia
    {
        public int Cod_anom { get; private set; }
        public string Nombre_anom { get; private set; }
        public int Dif_anom { get; private set; }

        public TipoAnomalia(int cod_anom, string nombre_anom, int dif_anom)
        {
            SetCod_anom(cod_anom);
            SetNombre_anom(nombre_anom);
            SetDif_anom(dif_anom);
        }

        public void SetCod_anom(int cod_anom)
        {
            if (cod_anom < 0)
                throw new ArgumentException("El código de la anomalía debe ser mayor que 0.", nameof(cod_anom));
            Cod_anom = cod_anom;
        }

        public void SetNombre_anom(string nombre_anom)
        {
            if (string.IsNullOrWhiteSpace(nombre_anom))
                throw new ArgumentException("El nombre de la anomalía no puede ser nulo o vacío.", nameof(nombre_anom));
            Nombre_anom = nombre_anom;
        }

        public void SetDif_anom(int dif_anom)
        {
            Dif_anom = dif_anom;
        }
    }
}
