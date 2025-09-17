//Write a program which calculates the square of a number using 
//odd number series implemented with the help of recursion concept.

using System;
using System.Security.Cryptography.X509Certificates;

class MatrixOperations
{
    static void Main()
    {

        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        int result = SquareUsingOdd(num);
        Console.WriteLine($"The square of {num} is: {result}");
    }

    public static int SquareUsingOdd(int n, int odd = 1)
    {
        if (n == 1) { return 1; }
        return odd + SquareUsingOdd(n - 1, odd + 2);
    }

}
