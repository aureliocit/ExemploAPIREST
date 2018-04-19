using System;
using Xunit;
using Alturas;

namespace AlturasTest
{
    public class ConversorAlturaTest    
    {
        ConversorAlturas conversor;

        public ConversorAlturaTest()
        {
            conversor = new ConversorAlturas();
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 0.3048d)]
        [InlineData(2, 0.6096d)]
        public void PesParaMetros_Tests(double value, double result) {
            Assert.Equal(result, conversor.PesParaMetros(value));
        }
    }
}
