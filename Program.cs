using System;

namespace CalculadoraBasica
{
    public class Calculadora
    {

        public int Somar(int a, int b)
        {
            return a + b;
        }

        public int Subtrair(int a, int b)
        {
            return a - b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculadora();

            Console.WriteLine($"5 + 3 = {calc.Somar(5, 3)}");
            Console.WriteLine($"-2 + 10 = {calc.Somar(-2, 10)}");

            Console.WriteLine($"10 - 4 = {calc.Subtrair(10, 4)}");
            Console.WriteLine($"5 - 8 = {calc.Subtrair(5, 8)}");

            Console.WriteLine("\nPressione qualquer tecla para sair");
            Console.ReadKey();
        }
    }
}
