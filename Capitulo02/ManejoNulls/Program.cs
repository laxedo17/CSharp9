#nullable enable
using System;

namespace ManejoNulls
{
    class Direccion
    {
        public string? Edificio;
        public string Calle = string.Empty;
        public string Cidade = string.Empty;
        public string Region = string.Empty;
    }
    class Program
    {
        static void Main(string[] args)
        {
            int istoNonPodeSerNull = 4;
            //istoNonPodeSerNull = null; //da erro de compilacion

            int? istoPodeSerNull = null;
            Console.WriteLine(istoPodeSerNull);
            Console.WriteLine(istoPodeSerNull.GetValueOrDefault());

            istoPodeSerNull = 7;
            Console.WriteLine(istoPodeSerNull);
            Console.WriteLine(istoPodeSerNull.GetValueOrDefault());

            var direccion = new Direccion();
            direccion.Edificio = null;
            direccion.Calle = null;
            direccion.Cidade = "Lugo";
            direccion.Region = null;

            // if(istoPodeSerNull!=null){
            //     //accede a un membro de istoPodeSerNull
            //     //int lonxitude = istoPodeSerNull.Length;//pode lanzar excepcion
            // }

            string nomeAutor = null;

            //o seguinte lanza unha NullReferenceException
            //int x = nomeAutor.Length;

            //en vez de lanzar unha excepcion
            //null asignase a y
            int? y = nomeAutor?.Length;

            //resultado sera 3 se nomeAutor?.Length e null
            var resultado = nomeAutor?.Length ?? 3;
            Console.WriteLine(resultado);

        }
    }
}
