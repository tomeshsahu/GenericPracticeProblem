using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPracticeProblem
{
    public class ArrayMaxUsingGeneric
    {
        public void ArrayMax <T>( T[] array)
        {
            foreach(T element in array)
            {
                Console.Write(element+" ");
                
            }
            Array.Sort(array);
            int Lent = array.Length;
            Console.WriteLine(" ");
            Console.WriteLine("Max Number of Array is= "+array[Lent-1]);
                
        }
    }
}
