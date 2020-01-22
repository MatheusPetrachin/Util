using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    /// <summary>
    /// Classe que calcula subtração.
    /// </summary>
    public static class SubtractionCalculator
    {
        private static float Subtraction_float { get; set; }

        /// <summary>
        /// Método de Subtração com "int".
        /// </summary>
        /// <param name="N1"> (int). </param>
        /// <param name="N2"> (int). </param>
        /// <returns></returns>
        public static int SubtractionMethod<T>(int N1, params T[] N2)
        {
            foreach (T element in N2)
            {
                N1 -= Convert.ToInt32(element);
            }
            return N1;
        }

        /// <summary>
        /// Método de Subtração com "double". 
        /// </summary>
        /// <param name="N1"> (double). </param>
        /// <param name="N2"> (double). </param>
        /// <returns></returns>
        public static double SubtractionMethod(double N1, params double[] N2)
        {
            foreach (int element in N2)
            {
                N1 -= element;
            }
            return N1;
        }

        /// <summary>
        /// Método de Subtração com "float". 
        /// </summary>
        /// <param name="N1"> (float). </param>
        /// <param name="N2"> (float). </param>
        /// <returns></returns>
        public static float SubtractionMethod(float N1, params float[] N2)
        {
            foreach (int element in N2)
            {
                N1 -= element;
            }
            return N1;
        }
    }
}
