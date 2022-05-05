using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPracticeProblem
{
    public class UC2_ArrayWithGeneric
    {
        public static void toPrint1<T>(T[] intArray1)
        {
            foreach (var element in intArray1)
            {
                Console.WriteLine(element);
            }
  
            Console.WriteLine("----------------------------------");
        }

        public static void toPrint2<T>(T[] doubleArray1)
        {
            foreach (var element in doubleArray1)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("----------------------------------");
        }

        public static void toPrint3<T>(T[] charArray1)
        {
            foreach (var element in charArray1)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("----------------------------------");
        }





    }
}
