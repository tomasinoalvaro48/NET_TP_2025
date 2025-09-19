using Domain.Model;

namespace Data
{
    public class TipoAnomaliaInMemory
    {
        public static List<TipoAnomalia> TiposAnomalia;
        static TipoAnomaliaInMemory()
        {
            TiposAnomalia = new List<TipoAnomalia>
            {
                new TipoAnomalia(1, "Fantasma de Persona ", 1),
                new TipoAnomalia(2, "Ejército de Zombies", 3),
                new TipoAnomalia(3, "Vikingos Fantasmas", 3),
                new TipoAnomalia(4, "Objetos Flotantes", 1),
                new TipoAnomalia(5, "Armadura Encantada", 2)
            };
        }
    }
}
