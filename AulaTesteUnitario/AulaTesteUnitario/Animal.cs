using AulaTesteUnitario.Service;

namespace AulaTesteUnitario
{
    public abstract class Animal
    {
        public IAdrestrador adestradorPet;

        public abstract void Andar();
        public abstract void Comer();
        

        public Animal(IAdrestrador adrestrador)
        {
            if(adrestrador == null)
            {
                throw new ArgumentNullException(nameof(adrestrador));
            }

            adestradorPet = adrestrador;
        }

        public virtual string Falar(string mensagem)
        {
            if(mensagem == null)
            {
                return "Oi";
            }

            var temComida = adestradorPet.DarComida();

            if(!temComida)
            {
                return "Animal nao quer falar";
            }

            return $"Animal gritando {mensagem}";
        }

    }
}
