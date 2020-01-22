using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Util
{
    public class Validations
    {
        /// <summary>
        /// Este método verifica se o telefone é Válido
        /// </summary>
        public static bool IsValidTelephone(string telephone)
        {
            string regexPadrao = "[11-99]?[0-9]{4,5}-?[0-9]{4}";
            return Regex.IsMatch(telephone, regexPadrao);
        }

        /// <summary>
        /// Este método verifica se o E-MAIL é Válido
        /// </summary>
        /// <param name="email"> deve conter nome@dominio.com/org/edu etc...</param>
        public static bool IsMailValid(string email)
        {
            string regexPadrao = string.Format("{0}{1}",
                @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))",
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$");
            return Regex.IsMatch(email, regexPadrao);
        }
    }
}
