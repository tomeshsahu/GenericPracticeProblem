using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPracticeProblem
{
    public class UC1_GenericArray
    {
      public static void toPrint(int[]intArray)
        {
            foreach(int element in intArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("---------------------------------");
        }

        public static void toPrint(double[] doubleArray)
        {
            foreach (double element in doubleArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("---------------------------------");
        }

        public static void toPrint(char[] charArray)
        {
            foreach (char element in charArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("---------------------------------");
        }
    }
}
