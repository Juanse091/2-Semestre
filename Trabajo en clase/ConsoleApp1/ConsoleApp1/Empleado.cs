using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Empleado
    {
        public abstract string Nombre();

        public abstract int edad();

        public abstract string TipoDeSalario();

        public virtual double Comision()
        {
            return 1;
        }
    }
}
