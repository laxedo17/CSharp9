using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            object altura = 1.88;
            object nome = "Alba";
            Console.WriteLine($"{nome} ten unha altura de {altura} metros.");

            //int lonxitude1 = nome.Length; //da erro de compilacion
            int lonxitude2 = ((string)nome).Length; //dille a compilador que e un string
            Console.WriteLine($"O nome {nome} ten {lonxitude2} caracteres.");

            //gardando un string nun obxeto dynamic
            dynamic outroNome = "Leyla";

            //isto compila pero lanza unha excepcion no tempo de execucion
            //si despois gardas un tipo de dato que non ten a propiedade Length
            //int lonxitude = outroNome.Length;

            var poboacion = 46_000_000; //46 millons en Espanha
            var peso = 70.87; //en kilogramos
            var precio = 4.99M;//en euros
            var froita = "Mazans";//as cadenas de texto (string) usan comillas dobles
            var letra = 'Z';//char usa comillas simples
            var contenta = true;//os valores booleanos poden ser true ou false

            Console.WriteLine($"default(int) = {default(int)}");
            Console.WriteLine($"default(bool) = {default(bool)}");
            Console.WriteLine($"default(DateTime) = {default(DateTime)}");
            Console.WriteLine($"default(string) = {default(string)}");

        }
    }
}
