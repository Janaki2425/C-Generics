using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Maxstrings
    {
        public static string Maximumstring(string firststring, string secondstring, string thirdstring)
        {
            if (firststring.CompareTo(secondstring) > 0 && firststring.CompareTo(thirdstring) > 0 ||
                    firststring.CompareTo(secondstring) >= 0 && firststring.CompareTo(thirdstring) > 0 ||
                firststring.CompareTo(secondstring) > 0 && secondstring.CompareTo(thirdstring) >= 0)
            {
                return firststring;
            }

            if (secondstring.CompareTo(firststring) > 0 && secondstring.CompareTo(thirdstring) > 0 ||
                    secondstring.CompareTo(firststring) >= 0 && secondstring.CompareTo(thirdstring) > 0 ||
                secondstring.CompareTo(firststring) > 0 && secondstring.CompareTo(thirdstring) >= 0)
            {
                return secondstring;
            }

            if (thirdstring.CompareTo(firststring) > 0 && thirdstring.CompareTo(secondstring) > 0 ||
                    thirdstring.CompareTo(firststring) >= 0 && thirdstring.CompareTo(secondstring) > 0 ||
                thirdstring.CompareTo(firststring) > 0 && thirdstring.CompareTo(secondstring) >= 0)
            {
                return thirdstring;
            }
            return firststring;


        }
    }
}
