//Implement Certain Operation On binary Trees
using System;

namespace BinaryTreeLab
{
    public class ArrayBinaryTree
    {
        private string[] tree;
        private int size;

        public ArrayBinaryTree(string[] elements)
        {
            tree = elements;
            size = elements.Length;
        }

        public void SetLeft(string data, int parentIndex)
        {
            int left = 2 * parentIndex + 1;

            if (left >= size)
            {
                Console.WriteLine("Cannot set left child. Index out of range.");
                return;
            }

            tree[left] = data;
            Console.WriteLine($"Left child of {tree[parentIndex]} set to {data}");
        }

        public void SetRight(string data, int parentIndex)
        {
            int right = 2 * parentIndex + 2;

            if (right >= size)
            {
                Console.WriteLine("Cannot set right child. Index out of range.");
                return;
            }

            tree[right] = data;
            Console.WriteLine($"Right child of {tree[parentIndex]} set to {data}");
        }

        public void PreOrderTraversal(int index)
        {
            if (index >= size || string.IsNullOrEmpty(tree[index]))
                return;

            Console.Write(tree[index] + " ");
            PreOrderTraversal(2 * index + 1);
            PreOrderTraversal(2 * index + 2);
        }

        public void InOrderTraversal(int index)
        {
            if (index >= size || string.IsNullOrEmpty(tree[index]))
                return;

            InOrderTraversal(2 * index + 1);
            Console.Write(tree[index] + " ");
            InOrderTraversal(2 * index + 2);
        }

        public void PostOrderTraversal(int index)
        {
            if (index >= size || string.IsNullOrEmpty(tree[index]))
                return;

            PostOrderTraversal(2 * index + 1);
            PostOrderTraversal(2 * index + 2);
            Console.Write(tree[index] + " ");
        }

        public bool SearchNode(string target, int index)
        {
            if (index >= size || string.IsNullOrEmpty(tree[index]))
                return false;

            if (tree[index] == target)
                return true;

            return SearchNode(target, 2 * index + 1) || SearchNode(target, 2 * index + 2);
        }

        public void DisplayTree()
        {
            Console.WriteLine("\n--- Binary Tree ---");
            Console.WriteLine("Index\tValue\tLeft\tRight");
            Console.WriteLine("-------------------------------");

            for (int i = 0; i < size; i++)
            {
                if (!string.IsNullOrEmpty(tree[i]))
                {
                    string left = GetLeftValue(i);
                    string right = GetRightValue(i);
                    Console.WriteLine($"{i}\t{tree[i]}\t{left}\t{right}");
                }
            }
        }

        private string GetLeftValue(int index)
        {
            int left = 2 * index + 1;
            return (left < size && !string.IsNullOrEmpty(tree[left])) ? tree[left] : "null";
        }

        private string GetRightValue(int index)
        {
            int right = 2 * index + 2;
            return (right < size && !string.IsNullOrEmpty(tree[right])) ? tree[right] : "null";
        }

        public void DisplayArray()
        {
            Console.WriteLine("\n--- Array View ---");
            Console.Write("Index:\t");
            for (int i = 0; i < size; i++) Console.Write(i + "\t");

            Console.Write("\nValue:\t");
            for (int i = 0; i < size; i++)
                Console.Write((string.IsNullOrEmpty(tree[i]) ? "null" : tree[i]) + "\t");

            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Binary Tree Example\n");

            string[] treeArray = new string[15];
            ArrayBinaryTree tree = new ArrayBinaryTree(treeArray);

            treeArray[0] = "8";
            Console.WriteLine("Root set to 8\n");

            tree.SetLeft("3", 0);
            tree.SetRight("10", 0);
            tree.SetLeft("1", 1);
            tree.SetRight("6", 1);
            tree.SetRight("14", 2);
            tree.SetLeft("4", 4);
            tree.SetRight("7", 4);
            tree.SetLeft("13", 6);

            tree.DisplayArray();
            tree.DisplayTree();

            Console.WriteLine("\nPre-order: ");
            tree.PreOrderTraversal(0);

            Console.WriteLine("\nIn-order: ");
            tree.InOrderTraversal(0);

            Console.WriteLine("\nPost-order: ");
            tree.PostOrderTraversal(0);

            Console.WriteLine("\n\nSearch Results:");
            string[] searchItems = { "6", "14", "5", "8", "13", "10" };
            foreach (string s in searchItems)
            {
                bool found = tree.SearchNode(s, 0);
                Console.WriteLine($"{s} found: {found}");
            }

            Console.WriteLine("\nAdding a new left child (9) to node 10...");
            tree.SetLeft("9", 2);

            Console.WriteLine("\nUpdated Pre-order: ");
            tree.PreOrderTraversal(0);

            tree.DisplayTree();

            Console.WriteLine("\nDone!");
            Console.ReadKey();
        }
    }
}
