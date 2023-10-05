using AulaTesteUnitario.Service;

namespace AulaTesteUnitario
{
    public class Gato : Animal
    {
        public Gato(IAdrestrador adrestrador) : base(adrestrador)
        {
        }

        public override void Andar()
        {
            Console.WriteLine("Andando como um gato");
        }

        public override void Comer()
        {
            
            Console.WriteLine("Comendo como um gato");
        }
    }
}
