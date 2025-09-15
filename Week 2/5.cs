//Write a program to calculate H.C.F of two numbers, using recursion.




using System;

class Program
{
    static int HCF(int a, int b)
    {
        if (b == 0)
            return a;
        return HCF(b, a % b);
    }

    static void Main()
    {
        Console.Write("Enter first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = int.Parse(Console.ReadLine());

        int result = HCF(num1, num2);

        Console.WriteLine($"H.C.F of {num1} and {num2} is: {result}");
    }
}
