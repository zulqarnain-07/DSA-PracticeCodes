using System;
using System.Collections.Generic;

//Create an array A of length 10 of integers. Values ranging from 1 to 50.
//1. Find all pair of elements whose sum is 25.
//2. Find the number of elements of A which are even, and the number of elements of A which are odd.
//3. Write a procedure which finds the average of the value of A.


class Program
{
    static void Main()
    {
       
            int[] A = { 3, 7, 12, 15, 10, 5, 20, 25, 2, 23 };
            int sum = 0;
            List<(int, int)> pairs = new List<(int, int)>();
            List<int> even = new List<int>();
            List<int> odd = new List<int>();
            for (int i = 0; i < A.Length; i++)
            {
                sum += A[i];
                if (i % 2 == 0) { even.Add(i); }
                else { odd.Add(i); }
                for (int j = i + 1; j < A.Length; j++)
                {
                    if (A[i] + A[j] == 25)
                    {
                        pairs.Add((A[i], A[j]));
                    }
                }
            }
            Console.WriteLine("Pairs Having Sum = 25 : ");
            foreach (var p in pairs)
            {
                Console.WriteLine("{0},{1}", p.Item1, p.Item2);
            }
            Console.Write("Even = ");
            foreach (var p in even)
            {
                Console.Write("{0} ", p);
            }
            Console.WriteLine();
            Console.Write("ODD = ");
            foreach (var q in odd)
            {
                Console.Write("{0} ", q);
            }
            Console.WriteLine();
            double avgA = (double)sum / A.Length;
            Console.WriteLine("Average = " + avgA);
        }
}
