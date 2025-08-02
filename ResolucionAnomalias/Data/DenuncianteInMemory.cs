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
                new Denunciante(456789123, "Juan Pepe", 3413123, "Corrientes 1400"),
                new Denunciante(123456789, "Ana Maria", 3414567, "Santa Fe 2000")
            };
        }
    }
}