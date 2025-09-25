//Double Linked List Operations
using DSA_2;
using System;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doublezack
{

    public class DLinkedList
    {
        public class Node
        {
            public int data;
            public Node next;
            public Node prev;
            public Node(int d)
            {
                data = d;
            }
        }

        public Node head;

        public void PrintListForward()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            Console.WriteLine("\nForward Print : ");
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.data + "->");
                temp = temp.next;
            }
            Console.WriteLine("Null");
        }
        public void PrintListBackward()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            Console.WriteLine("\nBackward Print : ");
            while (temp != null)
            {
                Console.Write(temp.data + "->");
                temp = temp.prev;
            }
            Console.WriteLine("Null");

        }

        public void InsertAtEnd(int new_data)
        {
            Node new_Node = new Node(new_data);
            if (head == null)
            {
                head = new_Node;
                return;
            }

            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = new_Node;
            new_Node.prev = temp;
        }
        public void InsertAtFront(int new_data)
        {
            Node new_Node = new Node(new_data);
            if (head == null)
            {
                head = new_Node;
                return;
            }
            new_Node.next = head;
            head.prev = new_Node;
            head = new_Node;
        }

        public void InsertAfter(Node prevNode, int data)
        {
            if (prevNode == null)
            {
                Console.WriteLine("The given previous node cannot be null");
                return;
            }

            Node newNode = new Node(data);
            newNode.next = prevNode.next;
            newNode.prev = prevNode;
            prevNode.next = newNode;
            if (newNode.next != null)
            {
                newNode.next.prev = newNode;

            }
        }
        public void InsertBefore(Node nextNode, int data)
        {
            if (nextNode == null)
            {
                Console.WriteLine("The given previous node cannot be null");
                return;
            }

            Node newNode = new Node(data);
            newNode.next = nextNode.next;
            newNode.prev = nextNode;
            nextNode.next = newNode;
            if (newNode.next != null)
            {
                newNode.next.prev = newNode;

            }
        }
        public void Delete(int data)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            Node temp = head;
            if (temp.data == data)
            {
                head = temp.next;
                if (head != null)
                {
                    head.prev = null;
                    return;
                }
            }
            while (temp != null && temp.data != data)
            {
                temp = temp.next;
            }
            if (temp == null)
            {
                Console.WriteLine("Data not found");
                return;
            }
            if (temp.next != null)
            {
                temp.next.prev = temp.prev;
            }
            if (temp.prev != null)
            {
                temp.prev.next = temp.next;
            }
        }
        static void Main(string[] args)
        {
            DLinkedList list1 = new DLinkedList();

            list1.InsertAtEnd(41);
            list1.InsertAtEnd(42);
            list1.InsertAtEnd(43);
            list1.InsertAtEnd(44);
            Console.WriteLine("Initial Traversals");
            list1.PrintListForward();
            list1.PrintListBackward();
            Console.WriteLine("\nInsert At Front");
            list1.InsertAtFront(40);
            list1.PrintListForward();
            Console.WriteLine("\nInsert After");

            list1.InsertAfter(list1.head, 100);
            list1.PrintListForward();
            Console.WriteLine("\nInsert Before");

            list1.InsertBefore(list1.head, 00);
            list1.PrintListForward();

            Console.WriteLine("\nDelete ");
            list1.Delete(41);
            list1.PrintListForward();
        }

    }
}

