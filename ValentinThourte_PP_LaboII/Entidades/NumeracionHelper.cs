using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal static class NumeracionHelper
    {
        public static string GetNumeroBinarioFromDecimal(double valor)
        {
            int index;
            double valorAbsoluto = Math.Abs(valor);
            List<int> doubles = new List<int>();
            for (index = 0; valorAbsoluto >= 1; index++)
            {
                doubles.Add((int)valorAbsoluto % 2);
                valorAbsoluto = valorAbsoluto / 2;
            }
            string binario = "";
            foreach (var element in doubles)
            {
                binario = element.ToString() + binario;
            }

            return binario;
        }

        public static double GetNumeroDecimalFromBinario(string valor)
        {
            int i;
            double returnNumber = 0;
            StringBuilder stringBuilder = new StringBuilder();
            int binarioLength = valor.Length;
            for (i = 0; i < binarioLength; i++)
            {
                char binaryChar = valor[binarioLength - 1 - i];
                int binaryDigit = binaryChar - '0';
                returnNumber += binaryDigit * (Math.Pow(2, i));
            }
            return returnNumber;
        }

    }
}
