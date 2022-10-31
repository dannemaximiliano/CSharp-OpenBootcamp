using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion2_Ej1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre, apellido, sabeProgramar, msj;
            int edad;

            Console.WriteLine("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su apellido: ");
            apellido = Console.ReadLine();
            Console.WriteLine("Ingrese su edad: ");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sabe programar? ");
            sabeProgramar = Console.ReadLine();

            msj = "Hola, " + nombre + " " + apellido + " de " + edad + "años. Asi que " + sabeProgramar + " sabes programar? Genial";
            Console.WriteLine(msj);

        }
    }
}
