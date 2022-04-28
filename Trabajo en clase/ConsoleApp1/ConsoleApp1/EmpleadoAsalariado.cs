using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class EmpleadoAsalariado: Empleado
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
            Console.Write("Ingresar de cuanto es tu salario: ");
            return TipoDeSalad = Console.ReadLine();
        }
    }
}
