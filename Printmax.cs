using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Printmax<T> where T : IComparable
    {
        public T[] value;
        public Printmax(T[] value)
        {
            this.value = value;
        }
        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }
        public T Comparevalues(params T[] values)
        {
            var sortedvalues = Sort(values);
            return sortedvalues[^1];
        }
        public T Maxmethod()
        {
            var max = Comparevalues(this.value);
            return max;
        }
        public void PrintmaxvalueUC4()
        {
            var max = Comparevalues(this.value);
            Console.WriteLine("Maximum value is" + max);
        }
        static void Main(string[] args)
        {
            int[] arr = { 10, 11, 12, 186, 48 };
            Printmax<int> generic = new Printmax<int>(arr);
            generic.PrintmaxvalueUC4();
        }

    }
    
  }

    
    

