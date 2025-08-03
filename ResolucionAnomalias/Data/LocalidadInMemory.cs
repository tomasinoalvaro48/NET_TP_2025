using Domain.Model;

namespace Data
{
    public class LocalidadInMemory
    {
        public static List<Localidad> Localidades;

        static LocalidadInMemory()
        {
            Localidades = new List<Localidad>
            {
                new Localidad(1, 2500, "Santa Fe"),
                new Localidad(2, 2000, "Rosario")

            };
        }
    }
}
