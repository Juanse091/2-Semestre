using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class EmpleadoPorHoras: Empleado
    {
        public override string Nombre()
        {
            string nombre;
            Console.Write("\nIngresar su nombre: ");
            return nombre = Console.ReadLine();
        }

        public override int edad()
        {
            int edad;
            Console.Write("Ingresar su edad: ");
            return edad = int.Parse(Console.ReadLine());
        }

        public override string TipoDeSalario()
        {
            string TipoDeSalad;
            Console.Write("Ingresar cuanto cobra por hora: ");
            return TipoDeSalad = Console.ReadLine();
        }
    }
}

