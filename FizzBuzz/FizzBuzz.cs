using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizz
{
    public static class FizzBuzz
    {


        public static string GetMessage(this int value)
        {
            string result = string.Empty;

            if (value.IsModuloOf(3))
            {
                result += "Fizz";
            }

            if (value.IsModuloOf(5))
            {
                result += "Buzz";
            }

            return ( string.IsNullOrEmpty(result) ? value.ToString() : result);
        }

        //private bool IsModuloOf(int value, int modulo)
        //{
        //    return (value % modulo == 0);
        //}


        private static bool IsModuloOf(this int value, int modulo)
        {
            return (value % modulo == 0);
        }

    }
}
