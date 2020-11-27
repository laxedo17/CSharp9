using System;
using static System.Console;

namespace Argumentos
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine($"Hai {args.Length} argumentos en args");

            foreach (string arg in args)
            {
                WriteLine(args);
            }

            if (args.Length < 3)
            {
                WriteLine("Debes especificar 2 colores y tamanho de cursor, ej.");
                WriteLine("dotnet run red yellow 50");
                return; //el programa para
            }

            ForegroundColor = (ConsoleColor)Enum.Parse(
                enumType: typeof(ConsoleColor),
                value: args[0],
                ignoreCase: true
            );

            try
            {
                CursorSize = int.Parse(args[2]);
            }
            catch
            {
                WriteLine("La plataforma o sistema operativo en uso no soporta el cambio de tamanho del cursor");
            }

        }
    }
}
