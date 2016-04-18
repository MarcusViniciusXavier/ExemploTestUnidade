using System;
using TesteDeUnidade;
using Xunit;

namespace Unit
{
    public class TestaCalculadora
    {
        [Fact]
        public void TestSomar()
        {
            Assert.Equal(4, Calculadora.Somar(2, 2));
        }

        [Theory]
        [InlineData(3, 4)]
        [InlineData(2, 4)]
        [InlineData(5, 4)]
        [InlineData(6, 4)]
        [InlineData(7, 4)]
        public void TestSubtrair(decimal n1, decimal n2)
        {
            Assert.Equal((n1 - n2), Calculadora.Subtrair(n1, n2));
        }

        [Theory]
        [InlineData(2,2 , 4)]
        [InlineData(3, 3, 9)]
        [InlineData(4, 4, 16)]
        public void TestMultiplicacao(decimal n1, decimal n2, decimal resultado)
        {
            Assert.Equal(resultado, Calculadora.Multiplicar(n1, n2));
        }

        [Theory]
        [InlineData(2, 2, 1)]
        public void Divisao(decimal n1, decimal n2, decimal resultado)
        {
            Assert.Equal(resultado, Calculadora.Dividir(n1, n2));
        }

        [Fact]
        public void DivisaoPorZero()
        {
            Assert.Throws<ArgumentException>(() => Calculadora.Dividir(2, 0)).Equals(Exceptions.DIVISAO_POR_ZERO);
        }

    }
}
