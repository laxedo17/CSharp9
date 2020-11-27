using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes;//pode referencia un array calquera de strings (cadenas de texto)

            //asignando memoria para catro strings nun array
            nomes = new string[4];

            //almacenando obxetos nas posicions do indice (index)
            nomes[0] = "Carol";
            nomes[1] = "Mercedes Ben";
            nomes[2] = "Dolores Fortes de Barriga";
            nomes[3] = "Pierre";

            //facendo loop para recorrer os nomes
            for (int i = 0; i < nomes.Length; i++)
            {
                //saca por pantalla o obxeto na posicion do indice
                Console.WriteLine(nomes[i]);
            }
        }
    }
}