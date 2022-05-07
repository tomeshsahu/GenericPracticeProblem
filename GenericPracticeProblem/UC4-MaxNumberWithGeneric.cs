using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPracticeProblem
{
    public class MaxNumber<T>where T:IComparable
        {
        public T firstNumber;
        public T secondNumber;
        public T thirdNumber;

        public MaxNumber(T firstNumber, T secondNumber, T thirdNumber)
        {
            this.firstNumber = firstNumber;
            this.secondNumber = secondNumber;
            this.thirdNumber = thirdNumber;
        }

        public T MaxElement()
        {
            if(firstNumber.CompareTo(secondNumber) > 0 && firstNumber.CompareTo(thirdNumber)>0)
            {
                return firstNumber;
            }
            if(secondNumber.CompareTo(firstNumber)>0 && secondNumber.CompareTo(thirdNumber)>0)
            {
                return secondNumber;
            }
            if(thirdNumber.CompareTo(firstNumber)>0 && thirdNumber.CompareTo(secondNumber)>0)
            {
                return thirdNumber;
            }
            throw new Exception("firstNumber,secondNumber and thirdNumber are same");
        }
    }

}