using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class EmpleadoPorComision: Empleado
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
            double total, salad, comision;



            Console.Write("Ingrese la comisión: ");
            comision = double.Parse(Console.ReadLine());
            Console.Write("Ingresar de cuanto es tu salario: ");
            salad = double.Parse(Console.ReadLine());
            total = comision + salad;
            return total.ToString();

        }

  
    }
}

