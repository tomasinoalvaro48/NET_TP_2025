using Domain.Model;

namespace Data
{
    public class DenuncianteInMemory
    {
        public static List<Denunciante> Denunciantes;

        static DenuncianteInMemory()
        {
            Denunciantes = new List<Denunciante>
            {
                new Denunciante(1, "Juan Pepe", "3413123456", "Corrientes 1400"),
                new Denunciante(2, "Ana Maria", "3415456789", "Santa Fe 2000")
            };
        }
    }
}