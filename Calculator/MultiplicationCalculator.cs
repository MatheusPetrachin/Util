using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    /// <summary> 
    /// Classe que calcula Multiplicação.
    /// </summary>
    public static class MultiplicationCalculator
    {

        private static int Multiplication_int { get; set; }
        private static double Multiplication_double { get; set; }
        private static float Multiplication_float { get; set; }

        /// <summary>
        /// Método de Multiplicação com "int". 
        /// </summary>
        /// <param name="N"> (int). </param>
        /// <returns></returns>
        public static int MultiplicationMethod(params int[] N)
        {
            foreach (int element in N)
            {
                Multiplication_int *= element;
            }
            return Multiplication_int;
        }

        /// <summary>
        /// Método de Multiplicação com "double". 
        /// </summary>
        /// <param name="N"> (double). </param>
        /// <returns></returns>
        public static double MultiplicationMethod(params double[] N)
        {
            foreach (int element in N)
            {
                Multiplication_double *= element;
            }
            return Multiplication_double;
        }

        /// <summary>
        /// Método de Multiplicação com "float". 
        /// </summary>
        /// <param name="N"> (float). </param>
        /// <returns></returns>
        public static float MultiplicationMethod(params float[] N)
        {
            foreach (int element in N)
            {
                Multiplication_float *= element;
            }
            return Multiplication_float;
        }
    }
}

