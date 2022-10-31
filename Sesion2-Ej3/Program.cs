using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion2_Ej3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            char a;

            Console.WriteLine("Ingrese un numero: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese una letra: ");
            a = Convert.ToChar(Console.ReadLine());

            Console.WriteLine(n >= 18);
            Console.WriteLine(a == 'a');
            Console.WriteLine(n >= 18 && a == 'a');
            Console.WriteLine(n >= 18 || a == 'a');

            Console.ReadLine();



        }
    }
}
