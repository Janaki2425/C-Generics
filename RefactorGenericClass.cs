using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class RefactorGenericClass<T> where T : IComparable
    {
        public T firstvalue, secondvalue, thirdvalue;

        public RefactorGenericClass(T firstvalue, T secondvalue, T thirdvalue)
        {
            this.firstvalue = firstvalue;
            this.secondvalue = secondvalue;
            this.thirdvalue = thirdvalue;

        }
        public static  T Comparevalue(T firstvalue, T secondvalue, T thirdvalue)
        {
            if (firstvalue.CompareTo(secondvalue) > 0 && firstvalue.CompareTo(thirdvalue) > 0 ||
                    firstvalue.CompareTo(secondvalue) >= 0 && firstvalue.CompareTo(thirdvalue) > 0 ||
                firstvalue.CompareTo(secondvalue) > 0 && secondvalue.CompareTo(thirdvalue) >= 0)
            {
                return firstvalue;
            }

            if (secondvalue.CompareTo(firstvalue) > 0 && secondvalue.CompareTo(thirdvalue) > 0 ||
                    secondvalue.CompareTo(firstvalue) >= 0 && secondvalue.CompareTo(thirdvalue) > 0 ||
                secondvalue.CompareTo(firstvalue) > 0 && secondvalue.CompareTo(thirdvalue) >= 0)
            {
                return secondvalue;
            }

            if (thirdvalue.CompareTo(firstvalue) > 0 && thirdvalue.CompareTo(secondvalue) > 0 ||
                    thirdvalue.CompareTo(firstvalue) >= 0 && thirdvalue.CompareTo(secondvalue) > 0 ||
                thirdvalue.CompareTo(firstvalue) > 0 && thirdvalue.CompareTo(secondvalue) >= 0)
            {
                return thirdvalue;
            }
            return firstvalue;


        }
        public T Maxmethod()
        {
            T max = RefactorGenericClass<T>.Comparevalue(this.firstvalue, this.secondvalue, this.thirdvalue);
            return max;
        }
            
    }
}
