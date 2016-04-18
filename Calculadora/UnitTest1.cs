using System;
using Xunit;
using TesteDeUnidade;


namespace UnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestSomar()
        {
            Assert.Equal(4, Calculadora.Somar(2,2));
        }
    }
}
