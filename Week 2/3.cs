//Write a program which takes input of an integer number and returns the sum of all numbers.
//i.e., if input is 3453 then the output should be 15 (3+4+5+3).


using System;
using System.Security.Cryptography.X509Certificates;

class MatrixOperations
{
    static void Main()
    {
        Console.WriteLine("Enter Number : ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(sumDigits(n));
      
    }

    public static int sumDigits(int n)
    {
        if (n == 0) { return 0; }
        return (n % 10) + sumDigits(n / 10);
    }
}
