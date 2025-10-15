//Design & implement all methods of Circular Queue.
using System;
public class CircularQUEUE
{
    public int[] queueArray;
    public int maxsize;
    public int front;
    public int rear;
    public CircularQUEUE(int size)
    {
        maxsize = size;
        queueArray = new int[maxsize];
        front = -1;
        rear = -1;
    }
    public bool isEmpty()
    { return (front == -1 && rear == -1); }
    public bool isFull()
    { return ((rear + 1) % maxsize == front); }

    public void enqueue(int value)
    {
        if (isFull())
        {Console.WriteLine("Queue is full. Cannot enqueue " + value);
            return;
        }else if (isEmpty())
        {
            front = rear = 0;
            queueArray[rear] = value;
        }
        else
        {rear = (rear + 1) % maxsize;
            queueArray[rear] = value;
        }
        Console.WriteLine("Enqueued: " + value);
    }
    public void dequeue()
    {if (isEmpty())
        {Console.WriteLine("Queue is empty. Nothing to dequeue.");
            return;
        }
        else if (front == rear)
        {Console.WriteLine("Dequeued: " + queueArray[front]);
            front = rear = -1;
        }
        else{Console.WriteLine("Dequeued: " + queueArray[front]);
            front = (front + 1) % maxsize;}
    }
    public void display()
    {
        if (isEmpty())
        {Console.WriteLine("Queue is empty.");
            return;}
        Console.Write("Queue elements: ");
        int i = front;
        while (true)
        {
            Console.Write(queueArray[i] + " ");
            if (i == rear) break;
            i = (i + 1) % maxsize;
        }
        Console.WriteLine();
    }
    public void peek()
    {
        if (isEmpty())
        {Console.WriteLine("Queue is empty.");}
        else
        {Console.WriteLine("Front element: " + queueArray[front]);
        }
    }
    public static void Main()
    {
        Console.WriteLine("Circular Queue Operations");
        CircularQUEUE s1 = new CircularQUEUE(5);
        s1.enqueue(1);
        s1.enqueue(2);
        s1.enqueue(3);
        s1.display();
        s1.dequeue();
        s1.dequeue();
        s1.display();
        s1.peek();
        s1.enqueue(4);
        s1.enqueue(5);
        s1.enqueue(6);
        s1.enqueue(7);
        s1.enqueue(8);
        s1.display();
    }
}
