using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EjercicioAbstraccion
{
    public class Matematicas : Operaciones
    {
        /// <summary>
        /// Numero 1
        /// </summary>
        public double num1 { get; set; }

        /// <summary>
        /// Numero 2
        /// </summary>
        public double num2 { get; set; }

        public override double Dividr()
        {
            return num1 / num2;
        }

        public override void Imprimir()
        {
            Console.WriteLine($"Suma: {Sumar()}");
            Console.WriteLine($"Restar: {Restar()}");
            Console.WriteLine($"Multiplicar: {Multiplicar()}");
            Console.WriteLine($"Dividr: {Dividr()}");
        }

        public override double Multiplicar()
        {
            return num1 * num2;
        }

        public override double Restar()
        {
            return num1 - num2;
        }

        public override double Sumar()
        {
            return num1 + num2;
        }
    }
}
