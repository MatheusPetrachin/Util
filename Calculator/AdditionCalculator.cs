using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    /// <summary>
    /// Classe que calcula Adição.
    /// </summary>
    public static class AdditionCalculator
    {
        public static int Addition_int { get; set; }
        public static double Addition_double { get; set; }
        public static float Addition_float { get; set; }

        /// <summary>
        /// Método de Adição com "int". 
        /// </summary>
        /// <param name="N"> (int). </param>
        /// <returns></returns>
        public static bool AdditionMethod(params int[] N)
        {
            bool retorno;
            try
            {
                foreach (int element in N)
                {
                    Addition_int += element;
                }
                retorno = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("" + ex);
                retorno = false;
            }
            return retorno;
        }

        /// <summary>
        /// Método de Adição com "double". 
        /// </summary>
        /// <param name="N"> (double). </param>
        /// <returns></returns>
        public static bool AdditionMethod(params double[] N)
        {
            bool retorno;
            try
            {
                foreach (int element in N)
                {
                    Addition_double += element;
                }
                retorno = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("" + ex);
                retorno = false;
            }
            return retorno;
        }

        /// <summary>
        /// Método de Adição com "float". 
        /// </summary>
        /// <param name="N"> (float). </param>
        /// <returns></returns>
        public static bool AdditionMethod(params float[] N)
        {
            bool retorno;
            try
            {
                foreach (int element in N)
                {
                    Addition_float += element;
                }
                retorno = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("" + ex);
                retorno = false;
            }
            return retorno;
        }
    }
}

