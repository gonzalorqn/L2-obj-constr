using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_17;
using Librerias;

namespace Ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            Boligrafo azul = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo rojo = new Boligrafo(50, ConsoleColor.Red);
            
            //Console.WriteLine("Ingrese tinta azul a gastar: ");
            //int tinta = Console.ReadLine();
            Console.WriteLine(Test.Saludar());
            Console.ReadLine();
        }
    }
}
