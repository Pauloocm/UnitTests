using AulaTesteUnitario;
using AulaTesteUnitario.Service;
using NSubstitute;
using NUnit.Framework;

namespace TestsProject
{
    [TestFixture]
    public class AnimalTests
    {
        private IAdrestrador adrestadorMock;
        private Cachorro dog;
        private Gato cat;

        [SetUp]
        public void SetUp()
        {
            adrestadorMock = Substitute.For<IAdrestrador>();

            dog = new Cachorro(adrestadorMock);
            cat = new Gato(adrestadorMock);
        }

        [Test]
        public void Cat_Should_Throw_Exception_If_Adestrador_Is_Null()
        {
            Assert.Throws<ArgumentNullException>(() => new Gato(null));
        }

        [Test]
        public void Gato_Deve_Retornar_Oi_Se_Mensagem_For_Null()
        {
            var expectedResult = cat.Falar(null);

            Assert.That(expectedResult, Is.Not.Null);

            Assert.That(expectedResult, Is.EqualTo("Oi"));
        }

        
        [Test]
        public void Gato_Nao_Deve_Miar_Se_Adrestador_Nao_Der_Comida()
        {
            adrestadorMock.DarComida().Returns(false);

            var expectedResult = cat.Falar("Olá Davi!");

            Assert.That(expectedResult, Is.Not.Null);

            Assert.That(expectedResult, Is.EqualTo("Animal nao quer falar"));

            adrestadorMock.Received(1).DarComida();
        }

        [Test]
        public void Gato_Deve_Miar()
        {
            adrestadorMock.DarComida().Returns(true);

            var expectedResult = cat.Falar("Olá Davi!");

            Assert.That(expectedResult, Is.Not.Null);

            Assert.That(expectedResult, Is.EqualTo("Animal gritando Olá Davi!"));

            adrestadorMock.Received(1).DarComida();
        }


    }
}
