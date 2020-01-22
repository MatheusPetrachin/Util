using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    /// <summary>
    /// Classe que calcula Divisão.
    /// </summary>
    public static class DivisionCalculator
    {

        /// <summary>
        /// Método de Divisão de "int". 
        /// </summary>
        /// <param name="N1"> (int). </param>
        /// <param name="N2"> (int). </param>
        /// <returns></returns>
        public static int DivisionMethod(int N1, int N2)
        {
            return N1 / N2;
        }
        /// <summary>
        /// Método de Divisão de "int". 
        /// </summary>
        /// <param name="N1"> (int). </param>
        /// <param name="N2"> (double). </param>
        /// <returns></returns>
        public static double DivisionMethod(int N1, double N2)
        {
            var retorno = N1 / N2;
            return retorno;
        }
        /// <summary>
        /// Método de Divisão de "int". 
        /// </summary>
        /// <param name="N1"> (int). </param>
        /// <param name="N2"> (float). </param>
        /// <returns></returns>
        public static float DivisionMethod(int N1, float N2)
        {
            var retorno = N1 / N2;
            return retorno;
        }


        /// <summary>
        /// Método de Divisão com "double".
        /// </summary>
        /// <param name="N1"> (double). </param>
        /// <param name="N2"> (double). </param>
        /// <returns></returns>
        public static double DivisionMethod(double N1, double N2)
        {
            return N1 / N2;
        }
        /// <param name="N1"> (double). </param>
        /// <param name="N2"> (int). </param>
        public static double DivisionMethod(double N1, int N2)
        {
            return N1 / N2;
        }
        /// <param name="N1"> (double). </param>
        /// <param name="N2"> (float). </param>
        public static float DivisionMethod(double N1, float N2)
        {
            return (float)N1 / N2;
        }

        /// <summary>
        /// Método de Divisão com "float". 
        /// </summary>
        /// <param name="N1"> (float). </param>
        /// <param name="N2"> (float). </param>
        /// <returns></returns>
        public static float DivisionMethod(float N1, float N2)
        {
            return N1 / N2;
        }
        /// <param name="N1"> (float)</param>
        /// <param name="N2"> (int)</param>
        public static float DivisionMethod(float N1, int N2)
        {
            return N1 / N2;
        }
        /// <param name="N1"> (float). </param>
        /// <param name="N2"> (double). </param>
        public static double DivisionMethod(float N1, double N2)
        {
            return N1 / N2;
        }
    }
}
