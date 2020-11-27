using System;
using static System.Console;

namespace Ejercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string textoMazans = "Mazans";
            int contadorMazans = 1234;
            string textoBananas = "Bananas";
            int contadorBananas = 56789;



            WriteLine(
                format: "{0,-8} {1:6:N0}",
                arg0: "Nome",
                arg1: "Conta"
            );

            WriteLine(
                format: "{0,-8} {1,6:N0}",
                arg0: textoMazans,
                arg1: contadorMazans
            );

            WriteLine(
                format: "{0,-8} {1,6:N0}",
                arg0: textoBananas,
                arg1: contadorBananas
            );

            Console.WriteLine($"int usa {sizeof(int)} bytes e pode albergar numeros no rango de {int.MinValue:N0} a {int.MaxValue:N0}.");
            Console.WriteLine($"double usa {sizeof(double)} bytes e pode albergar numeros no rango de {double.MinValue:N0} a {double.MaxValue:N0}.");
            Console.WriteLine($"decimal usa {sizeof(decimal)} bytes e pode albergar numeros no rango de {decimal.MinValue:N0} a {decimal.MaxValue:N0}.");

            string textoSbyte = "sbyte";
            string textoByte = "byte";
            string textoShort = "short";
            string textoUshort= "ushort";
            string textoInt = "int";
            string textoUint = "uint";
            string textoLong = "long";
            string textoUlong = "ulong";
            string textoFloat = "float";
            string textoDouble = "double";
            string textoDecimal = "decimal";

            int espacioSbyte = 1;
            int espacioByte = 1;
            int espacioShort = 2;
            int espacioUshort = 2;
            int espacioInt = 4;
            int espacioUint = 4;
            int espaciolong = 8;
            int espacioUlong = 8;
            int espacioFloat = 4;
            int espacioDouble = 8;
            int espacioDecimal = 16;
        }
    }
}
