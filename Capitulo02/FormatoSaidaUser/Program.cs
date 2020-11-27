using System;
using static System.Console;

namespace FormatoSaidaUser
{
    class Program
    {
        static void Main(string[] args)
        {

            int numeroDeMazans = 12;
            decimal precioPorMazan = 0.35M;

            WriteLine(
                format: "{0} as mazans costan {1:C} euros",
                arg0: numeroDeMazans,
                arg1: precioPorMazan * numeroDeMazans);


            string formateado = string.Format(
                format: "{0} mazans costan {1:C} euros",
                arg0: numeroDeMazans,
                arg1: precioPorMazan * numeroDeMazans
            );

            //EscribeEnArquivo(formateado); //escribe o string a un arquivo de existir ese metodo obviamente

            WriteLine($"{numeroDeMazans} mazans costan {precioPorMazan * numeroDeMazans} euros");

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

            WriteLine("Escribe o teu nome e presiona INTRO: ");
            string nome = ReadLine();

            WriteLine("Escribe a tua idade e presiona INTRO: ");
            string idade = ReadLine();

            WriteLine($"Hola {nome}, veseche ben tendo {idade} anos de idade.");

            WriteLine("Presiona calquera combinacion de teclas.");
            ConsoleKeyInfo tecla = ReadKey();
            WriteLine();//crea un salto de linea
            WriteLine("Tecla: {0}, Caracter: {1}, Modificadores: {2}",
            arg0: tecla.Key,
            arg1: tecla.KeyChar,
            arg2: tecla.Modifiers
            );
        }
    }
}
