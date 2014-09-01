using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClassLibrary1;

namespace Componente1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Componente 1");

            Console.WriteLine(Class1.concatena("hola ", "mundo"));


            Console.Read();
        }
    }
}
