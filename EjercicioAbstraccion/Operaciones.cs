using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAbstraccion
{
    public abstract class Operaciones
    {
        /// <summary>
        /// Metodo para sumar los dos atributos
        /// </summary>
        public abstract double Sumar();

        /// <summary>
        /// Metodo para restar los dos atributos
        /// </summary>
        public abstract double Restar();

        /// <summary>
        /// Metodo para multiplicar los dos atributos
        /// </summary>
        public abstract double Multiplicar();

        /// <summary>
        /// Metodo para dividir los dos atributos
        /// </summary>
        public abstract double Dividr();

        /// <summary>
        /// Metodo para imprimir las operaciones
        /// </summary>
        public abstract void Imprimir();
    }
}
