using System;

namespace Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            //enteiro (integer uint) sin signo representa un numero enteiro positivo
            //incluindo 0
            uint numeroNatural = 23;

            //enteiro (int) e un numero enteiro negativo ou positivo
            int numeroEnteiro = -23;

            //float e un numero en coma flotante de precision simple (single precision floating point)
            //o sufixo F fai que sexa un float literal
            float numeroReal = 2.3F;

            //double e un numero en coma flotante de doble precision (double-precision floating point)
            double outroNumeroReal = 2.3; //double literal

            //tres variables que gardan o numero 2 millons
            int notacionDecimal = 2_000_000;
            int notacionBinaria = 0b_0001_1110_1000_0100_1000_0000;
            int notacionHexadecimal = 0x_001E_8480;

            //comproba que as tres variables son do mesmo valor
            //ambas instruccions devolven true
            Console.WriteLine($"{notacionDecimal == notacionBinaria}");
            Console.WriteLine($"{notacionDecimal == notacionHexadecimal}");

            Console.WriteLine($"int usa {sizeof(int)} bytes e pode albergar numeros no rango de {int.MinValue:N0} a {int.MaxValue:N0}.");
            Console.WriteLine($"double usa {sizeof(double)} bytes e pode albergar numeros no rango de {double.MinValue:N0} a {double.MaxValue:N0}.");
            Console.WriteLine($"decimal usa {sizeof(decimal)} bytes e pode albergar numeros no rango de {decimal.MinValue:N0} a {decimal.MaxValue:N0}.");

            Console.WriteLine("Usando doubles: ");
            double a = 0.1;
            double b = 0.2;

            if (a + b == 0.3)
            {
                Console.WriteLine($"{a} +{b} igual a 0.3");
            }
            else
            {
                Console.WriteLine($"{a}+{b} NON e igual a 0.3");
            }
        }
    }
}