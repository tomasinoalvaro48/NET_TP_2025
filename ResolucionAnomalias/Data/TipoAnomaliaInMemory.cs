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
                new TipoAnomalia(1, "Fantasma de Familiar", "facil"),
                new TipoAnomalia(2, "Ejército de Zombies", "dificil"),
                new TipoAnomalia(3, "Vikingos Fantasmas", "dificil"),
                new TipoAnomalia(4, "Objetos Flotantes", "facil"),
                new TipoAnomalia(5, "Armadura Encantada", "normal")
            };
        }
    }
}
