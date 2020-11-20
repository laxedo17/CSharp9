using System;
using System.Linq;
using System.Reflection;

namespace Fundamentos
{
    class Program
    {
        static void Main(string[] args)
        { //inicio dun bloque
            Console.WriteLine("Hello World!");//unha instruccion

            //declara algunhas variables non utilizadas usando tipos
            //in ensamblaxes(assemblies) adicionales
            System.Data.DataSet ds;
            System.Net.Http.HttpClient cliente;

            //fai loop sobre todas as ensamblaxes -assemblies- que referencia esta app
            foreach (var r in Assembly.GetEntryAssembly().GetReferencedAssemblies())
            {
                //Lee a ensamblaxe de maneira que podemos ler os seus detalles
                var a = Assembly.Load(new AssemblyName(r.FullName));

                //declara unha variable para contar o numero de metodos
                int numeroMetodos = 0;

                //Fai loop recorrendo todos os tipos da ensamblaxe
                foreach (var t in a.DefinedTypes)
                {
                    //vai sumando a conta de metodos
                    numeroMetodos += t.GetMethods().Count();
                }

                //saca por pantalla a conta de tipos e os seus metodos
                Console.WriteLine(
                    "{0:N0} tipos con {1:N0} metods en ensamblaxe (assembly) {2} ",
                    arg0: a.DefinedTypes.Count(),
                    arg1: numeroMetodos,
                    arg2: r.Name
                );
            }

            //Fai que a variable alturaEnMetros sexa igual a 1.88
            double alturaEnMetros = 1.88;
            Console.WriteLine($"A variable {nameof(alturaEnMetros)} equivale a {alturaEnMetros} metros.");

            char letra = 'A'; //asignando caracteres literales
            char digito = '1';
            char simbolo = '€';
            //char eleccionUsuarix=ObterPulsacionTeclado(); //asignando desde unha funcion imaxinaria (non a temos feita ainda)

            string nome = "Alba";
            string apelido = "Martin";
            string numeroTelefono = "986777777";

            //asignando unha cadena de texto string devolta pola chamada a unha funcion
            //string direccion=ObtenDireccionDaBaseDeDatos(id: 563);

            string nomeCompletoConSeparadorTabulacion = "Bob\tSmith";
            string rutaArquivo = @"C:\televisions\phillips\C70.txt";

        }//o final dun bloque
    }
}
