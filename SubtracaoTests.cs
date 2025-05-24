using Xunit;
using CalculadoraBasica;

namespace CalculadoraBasica.Tests
{
    public class TesteSubtracao
    {
        private readonly Calculadora _calc;

        public TesteSubtracao()
        {
            _calc = new Calculadora();
        }

        [Fact]
        public void Subtrair_DoisPositivos_DeveRetornarResultadoCorreto()
        {
            
            int a = 10;
            int b = 4;
            int esperado = 6;

            int resultado = _calc.Subtrair(a, b);

            Xunit.Assert.Equal(esperado, resultado);
        }

        [Fact]
        public void Subtrair_NegativoDePositivo_DeveRetornarResultadoCorreto()
        {
            Xunit.Assert.Equal(12, _calc.Subtrair(5, -7));
        }

        [Fact]
        public void Subtrair_DoisNegativos_DeveRetornarResultadoCorreto()
        {
            Xunit.Assert.Equal(2, _calc.Subtrair(-3, -5));
        }
    }
}
