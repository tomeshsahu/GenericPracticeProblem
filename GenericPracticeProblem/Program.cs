using System;
using GenericPracticeProblem;



public class Program
{

    public static void Main(string[] args)
    {
        Console.WriteLine("*********** Generic Practice Problem ***********");


        bool check = true;
        while (check)
        {
            Console.WriteLine("1.UC1-Sample Genric Problme\n2.UC2-Array with Generic\n3.UC3-MaxInterNumber\n4.UC4-MaxInterWithGeneric\n5.UC5-FindArrayMaxUsingGeneric");
            Console.WriteLine("Enter Any option for Execute the Program");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    int[] intArray = { 1, 2, 3, 4, 5 };
                    double[] doubleArray = { 1.1, 1.2, 1.3, 1.4, 1.5 };
                    char[] charArray = { 'A', 'B', 'C', 'D', 'E' };

                    UC1_GenericArray.toPrint(intArray);
                    UC1_GenericArray.toPrint(doubleArray);
                    UC1_GenericArray.toPrint(charArray);
                    break;

                case 2:
                    int[] intArray1 = { 11, 12, 13, 14, 15, 16 };
                    double[] doubleArray1 = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6 };
                    char[] charArray1 = { 'A', 'B', 'C', 'D', 'E', 'F' };

                    UC2_ArrayWithGeneric.toPrint1<int>(intArray1);
                    UC2_ArrayWithGeneric.toPrint1<double>(doubleArray1);
                    UC2_ArrayWithGeneric.toPrint1<char>(charArray1);
                    break;

                case 3:
                    Console.WriteLine($"Inter Maximum Number= { UC3_MaximumNumber.MaximumIntNumber(111, 222, 333)}");
                    Console.WriteLine($"Double Maximum Number= { UC3_MaximumNumber.MaximumDoubleNumber(11.1, 22.3, 33.8)}");
                    Console.WriteLine($"String Maximum Number= { UC3_MaximumNumber.MaximumStringNumber("999","955","988")}");

                    Console.WriteLine("----------------------------------"+"\n");
                    break;

                case 4:
                    MaxNumber<int> obj = new MaxNumber<int>(10,50,90);
                    int value=obj.MaxElement();
                    Console.WriteLine("Max Number is = "+value);
                    Console.WriteLine("----------------------------------" + "\n");
                    break;

                case 5:
                    ArrayMaxUsingGeneric obj1 = new ArrayMaxUsingGeneric();
                    int[] intNumber = { 1, 2, 4, 5, 6, 7, 8 };
                    double[] doubleNumber = { 1.1, 2.2, 4.3, 5.4, 6.6, 7.7, 8.8 };
                    string[] stringNumber = { "11", "22", "45", "40", "79", "89" };
                    obj1.ArrayMax(intNumber);
                    obj1.ArrayMax(doubleNumber);
                    obj1.ArrayMax(stringNumber);
                    Console.WriteLine(" ");
                    Console.WriteLine("----------------------------------" + "\n");
                    break;

                case 0:
                    check = false;
                    break;

            }
        }
    }

    private class UC4_MaxNumberWithGeneric
    {
        internal static T intMaxnumber<T>(T v1, T v2, T v3)
        {
            throw new NotImplementedException();
        }

        internal static T intMaxNumber<T>(T v1, T v2, T v3)
        {
            throw new NotImplementedException();
        }
    }
}

