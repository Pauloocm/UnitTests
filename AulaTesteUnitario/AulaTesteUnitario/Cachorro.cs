using AulaTesteUnitario.Service;

namespace AulaTesteUnitario
{
    public class Cachorro : Animal
    {
        public Cachorro(IAdrestrador adrestrador) : base(adrestrador)
        {
        }

        public override void Andar()
        {
            Console.WriteLine("Andando como um cachorro");
        }

        public override void Comer()
        {
            Console.WriteLine("Comendo como um cachorro");
        }
    }
}
