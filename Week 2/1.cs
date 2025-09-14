//Write a code which prints the following series:
//     2   4   8 - - - -n

using System;
using System.Security.Cryptography.X509Certificates;

class MatrixOperations
{
    static void Main()
    {

        Console.Write("Enter the limit (n): ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Series:");
        printsequence(2, n);
    }
    public static void printsequence(int num , int n)
    {
       if(num> n)
        {
            return;
        }
        Console.WriteLine(num + " ");
        printsequence(num*2 , num);
    }


}
