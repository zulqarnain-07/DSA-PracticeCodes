using System;
namespace StringReverseApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string to reverse: ");
            string input = Console.ReadLine();
            CharStack stack = new CharStack(input.Length);
            foreach (char c in input) stack.Push(c);
            string reversed = "";
            while (!stack.IsEmpty()) reversed += stack.Pop();
            Console.WriteLine($"\nReversed string: {reversed}");
            Console.WriteLine("\nOriginal string printed vertically:");
            foreach (char c in input) Console.WriteLine(c);
        }
    }
    internal class CharStack
    {
        private readonly char[] items; private int top; private readonly int size;
        public CharStack(int capacity) {
            size = capacity; items = new char[size]; top = -1; }
        public void Push(char ch) { 
            if (IsFull()) { 
                Console.WriteLine("⚠️ Stack overflow!"); 
                return; } items[++top] = ch; }
        public char Pop() { 
            if (IsEmpty()) { 
                Console.WriteLine("⚠️ Stack underflow!");
                return '\0'; } return items[top--]; }
        public bool IsFull() => top == size - 1;
        public bool IsEmpty() => top == -1;
    }
}
