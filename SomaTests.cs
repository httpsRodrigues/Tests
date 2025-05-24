using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CalculadoraBasica;

namespace CalculadoraBasica.Tests
{
    public class TesteSoma
    {
        private readonly Calculadora _calc;

        public TesteSoma()
        {
            _calc = new Calculadora();
        }

        [Fact]
        public void Somar_DoisPositivos_DeveRetornarSomaCorreta()
        {
 
            int a = 5;
            int b = 3;
            int esperado = 8;

            int resultado = _calc.Somar(a, b);

            Xunit.Assert.Equal(esperado, resultado);
        }

        [Fact]
        public void Somar_PositivoComNegativo_DeveRetornarSomaCorreta()
        {
            Xunit.Assert.Equal(3, _calc.Somar(7, -4));
        }

        [Fact]
        public void Somar_DoisNegativos_DeveRetornarSomaCorreta()
        {
            Xunit.Assert.Equal(-10, _calc.Somar(-4, -6));
        }
    }
}
