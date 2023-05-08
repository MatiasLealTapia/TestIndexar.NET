using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestIndexar.NET.Functions
{
    internal class Palindromo
    {
        public static bool IsPalindromo(string palindromo)
        {
            if (ReverseString(palindromo).ToLower() == palindromo.ToLower())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string ReverseString(string palindromo)
        {
            char[] caracteres = palindromo.ToCharArray();
            Array.Reverse(caracteres);
            return new string(caracteres);
        }
    }
}
