using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int TipoIngreso;

            EmpleadoAsalariado Persona1 = new EmpleadoAsalariado();
            EmpleadoPorComision Persona2 = new EmpleadoPorComision();
            EmpleadoPorHoras Persona3 = new EmpleadoPorHoras();

            Empleado[] empleado = {Persona1,Persona2,Persona3};

            Console.WriteLine("Seleccione su fuente de ingresos: " +
                "\n (1) Asalariada" +
                "\n (2) Por comisión" +
                "\n (3) Por horas\n");
            TipoIngreso = int.Parse(Console.ReadLine());

            switch(TipoIngreso) 
            {


                case 1:
                    string nombre1, tipo1;
                    int edad1;
                    nombre1 = Persona1.Nombre();
                    edad1 = Persona1.edad();
                    tipo1 = Persona1.TipoDeSalario();
                    Console.WriteLine("\nEmpleado de tipo - Asalariado " +
                        "\n Trabajador: " + nombre1 + "" +
                        "\n Edad: " + edad1 + "" +
                        "\n Salario: " + tipo1);
                    break;

                case 2:
                    string nombre2, tipo2;
                    int edad2;
                    nombre2 = Persona2.Nombre();
                    edad2 = Persona2.edad();
                    tipo2 = Persona2.TipoDeSalario();
                    Console.WriteLine("\nEmpleado de tipo - Por comisión " +
                        "\n Trabajador: "+ nombre2 + "" +
                        "\n Edad: "+ edad2 + "" +
                        "\n Salario: "+ tipo2) ;
                    break;

                case 3:
                    string nombre3, tipo3;
                    int edad3;
                    nombre3 = Persona3.Nombre();
                    edad3 = Persona3.edad();
                    tipo3 = Persona3.TipoDeSalario();
                    Console.WriteLine("\nEmpleado de tipo - Por horas " +
                        "\n Trabajador: " + nombre3 + "" +
                        "\n Edad: " + edad3 + "" +
                        "\n Salario: " + tipo3);
                    break;

            }

            Console.ReadKey();
        }
    }
}
