using System;

// Node class for linked list
class Node
{
    public int Data;
    public Node? Next;

    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}

// LinkedList class with operations
class LinkedList
{
    private Node? head;

    // Constructor
    public LinkedList()
    {
        head = null;
    }

    // Traversing: Print the linked list
    public void Traverse()
    {
        if (head == null)
        {
            Console.WriteLine("List is empty");
            return;
        }

        Node current = head;
        while (current != null)
        {
            Console.Write(current.Data + " -> ");
            current = current.Next;
        }
        Console.WriteLine("null");
    }

    // Insertion at the beginning
    public void InsertAtBeginning(int data)
    {
        Node newNode = new Node(data);
        newNode.Next = head;
        head = newNode;
    }

    // Insertion at the end
    public void InsertAtEnd(int data)
    {
        Node newNode = new Node(data);
        if (head == null)
        {
            head = newNode;
            return;
        }

        Node current = head;
        while (current.Next != null)
        {
            current = current.Next;
        }
        current.Next = newNode;
    }

    // Insertion at a specific position (0-based index)
    public void InsertAtPosition(int data, int position)
    {
        if (position < 0)
        {
            Console.WriteLine("Invalid position");
            return;
        }

        Node newNode = new Node(data);

        if (position == 0)
        {
            newNode.Next = head;
            head = newNode;
            return;
        }

        Node current = head;
        int currentPosition = 0;

        while (current != null && currentPosition < position - 1)
        {
            current = current.Next;
            currentPosition++;
        }

        if (current == null)
        {
            Console.WriteLine("Position out of bounds");
            return;
        }

        newNode.Next = current.Next;
        current.Next = newNode;
    }

    // Deletion from the beginning
    public void DeleteFromBeginning()
    {
        if (head == null)
        {
            Console.WriteLine("List is empty");
            return;
        }

        head = head.Next;
    }

    // Deletion from the end
    public void DeleteFromEnd()
    {
        if (head == null)
        {
            Console.WriteLine("List is empty");
            return;
        }

        if (head.Next == null)
        {
            head = null;
            return;
        }

        Node current = head;
        while (current.Next.Next != null)
        {
            current = current.Next;
        }
        current.Next = null;
    }

    // Deletion from a specific position (0-based index)
    public void DeleteFromPosition(int position)
    {
        if (position < 0 || head == null)
        {
            Console.WriteLine("Invalid position or list is empty");
            return;
        }

        if (position == 0)
        {
            head = head.Next;
            return;
        }

        Node current = head;
        int currentPosition = 0;

        while (current != null && currentPosition < position - 1)
        {
            current = current.Next;
            currentPosition++;
        }

        if (current == null || current.Next == null)
        {
            Console.WriteLine("Position out of bounds");
            return;
        }

        current.Next = current.Next.Next;
    }
}

class Program
{
    static void Main(string[] args)
    {
        LinkedList list = new LinkedList();

        Console.WriteLine("Lab 2: Linked List Operations");
        Console.WriteLine("=============================");

        // Demonstrate Traversing
        Console.WriteLine("\n1. Traversing (Empty List):");
        list.Traverse();

        // Demonstrate Insertion
        Console.WriteLine("\n2. Insertion Operations:");
        Console.WriteLine("Inserting 10 at beginning:");
        list.InsertAtBeginning(10);
        list.Traverse();

        Console.WriteLine("Inserting 20 at end:");
        list.InsertAtEnd(20);
        list.Traverse();

        Console.WriteLine("Inserting 15 at position 1:");
        list.InsertAtPosition(15, 1);
        list.Traverse();

        Console.WriteLine("Inserting 5 at beginning:");
        list.InsertAtBeginning(5);
        list.Traverse();

        Console.WriteLine("Inserting 25 at end:");
        list.InsertAtEnd(25);
        list.Traverse();

        // Demonstrate Deletion
        Console.WriteLine("\n3. Deletion Operations:");
        Console.WriteLine("Deleting from beginning:");
        list.DeleteFromBeginning();
        list.Traverse();

        Console.WriteLine("Deleting from end:");
        list.DeleteFromEnd();
        list.Traverse();

        Console.WriteLine("Deleting from position 1:");
        list.DeleteFromPosition(1);
        list.Traverse();

        Console.WriteLine("Deleting from beginning:");
        list.DeleteFromBeginning();
        list.Traverse();

        Console.WriteLine("Deleting from end:");
        list.DeleteFromEnd();
        list.Traverse();

        // Final state
        Console.WriteLine("\nFinal List:");
        list.Traverse();
    }
}