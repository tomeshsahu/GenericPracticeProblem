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
            Console.WriteLine("1.UC1-Sample Genric Problme\n2.UC2-Array with Generic");
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
                    UC2_ArrayWithGeneric.toPrint2<double>(doubleArray1);
                    UC2_ArrayWithGeneric.toPrint3<char>(charArray1);

                    break;


                case 0:
                    check = false;
                    break;

            }
        }
    }
}

