//Write a program to create a circular linked list by using all functions of insertion and
//deletion.

using System;

namespace Doublezack
{
    // Node class
    public class CNode
    {
        public int data;
        public CNode next;

        public CNode(int d)
        {
            data = d;
            next = null;
        }
    }

    // Circular Linked List class
    public class CLinkedList
    {
        public CNode head;

        // Print the list
        public void PrintList()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            Console.WriteLine("\nCircular Linked List:");
            CNode temp = head;
            do
            {
                Console.Write(temp.data + "->");
                temp = temp.next;
            } while (temp != head);
            Console.WriteLine("(head)");
        }

        // Insert at End
        public void InsertAtEnd(int new_data)
        {
            CNode newNode = new CNode(new_data);

            if (head == null)
            {
                head = newNode;
                newNode.next = head; // point to itself
                return;
            }

            CNode temp = head;
            while (temp.next != head)
            {
                temp = temp.next;
            }
            temp.next = newNode;
            newNode.next = head;
        }

        // Insert at Front
        public void InsertAtFront(int new_data)
        {
            CNode newNode = new CNode(new_data);

            if (head == null)
            {
                head = newNode;
                newNode.next = head;
                return;
            }

            CNode temp = head;
            while (temp.next != head)
            {
                temp = temp.next;
            }

            newNode.next = head;
            temp.next = newNode;
            head = newNode;
        }

        // Insert After a given node
        public void InsertAfter(CNode prevNode, int data)
        {
            if (prevNode == null)
            {
                Console.WriteLine("The given previous node cannot be null");
                return;
            }

            CNode newNode = new CNode(data);
            newNode.next = prevNode.next;
            prevNode.next = newNode;
        }

        // Delete a node by value
        public void Delete(int key)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            CNode curr = head, prev = null;

            // Case: head is to be deleted
            if (curr.data == key)
            {
                if (curr.next == head) // only one node
                {
                    head = null;
                    return;
                }

                // find last node
                CNode temp = head;
                while (temp.next != head)
                {
                    temp = temp.next;
                }

                temp.next = head.next;
                head = head.next;
                return;
            }

            // Other cases
            prev = curr;
            curr = curr.next;
            while (curr != head)
            {
                if (curr.data == key)
                {
                    prev.next = curr.next;
                    return;
                }
                prev = curr;
                curr = curr.next;
            }

            Console.WriteLine("Key not found in the list");
        }
    }

    // Main Program
    internal class Program
    {
        static void Main(string[] args)
        {
            CLinkedList list = new CLinkedList();

            list.InsertAtEnd(10);
            list.InsertAtEnd(20);
            list.InsertAtEnd(30);
            list.InsertAtEnd(40);

            Console.WriteLine("Initial Circular List:");
            list.PrintList();

            Console.WriteLine("\nInsert At Front:");
            list.InsertAtFront(5);
            list.PrintList();

            Console.WriteLine("\nInsert After:");
            list.InsertAfter(list.head.next, 15); // after node with value 10
            list.PrintList();

            Console.WriteLine("\nDelete 30:");
            list.Delete(30);
            list.PrintList();

            Console.WriteLine("\nDelete Head (5):");
            list.Delete(5);
            list.PrintList();
        }
    }
}
