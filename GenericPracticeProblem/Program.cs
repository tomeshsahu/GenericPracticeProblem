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
            Console.WriteLine("1.Sample Genric Problme");
            Console.WriteLine("Enter Any option for Execute the Program");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    int[] intArray = { 1, 2, 3, 4, 5 };
                    double[] doubleArray = { 1.1, 1.2, 1.3, 1.4, 1.5 };
                    char[] charArray = { 'A', 'B', 'C', 'D', 'E' };

                    GenericArray.toPrint(intArray);
                    GenericArray.toPrint(doubleArray);
                    GenericArray.toPrint(charArray);
                    break;

                case 0:
                    check = false;
                    break;

            }
        }
    }
}

