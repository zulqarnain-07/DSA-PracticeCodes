//Design & implement all methods of Simple Queue.

using System;
public class SimpleQUEUE
{
    public int[] queueArray;
    public int maxsize;
    public int front;
    public int rear;
    public SimpleQUEUE(int size)
    {   maxsize = size;
        queueArray = new int[maxsize];
        front = -1;
        rear = -1;
    }
    public bool isEmpty()
    {
        return (front == -1 && rear == -1);
    }
    public bool isFull()
    {
        return (rear == maxsize - 1);
    }
    public void enqueue(int value)
    {
        if (isFull())
        {
            Console.WriteLine("Queue is full. Cannot enqueue " + value);
            return;
        }
        else if (isEmpty())
        {
            front = 0;
            rear = 0;
            queueArray[rear] = value;
        }
        else
        {
            rear++;
            queueArray[rear] = value;
        }
        Console.WriteLine("Enqueued: " + value);
    }
    public void dequeue()
    {
        if (isEmpty())
        {
            Console.WriteLine("Queue is empty. Nothing to dequeue.");
            return;
        }
        else if (front == rear)
        {
            Console.WriteLine("Dequeued: " + queueArray[front]);
            front = rear = -1;
        }
        else
        {
            Console.WriteLine("Dequeued: " + queueArray[front]);
            front++;
        }
    }
    public void display()
    {
        if (isEmpty())
        {
            Console.WriteLine("Queue is empty.");
            return;
        }
        Console.Write("Queue elements: ");
        for (int i = front; i <= rear; i++)
        {
            Console.Write(queueArray[i] + " ");
        }
        Console.WriteLine();
    }
    public void peek()
    {
        if (isEmpty())
        {
            Console.WriteLine("Queue is empty.");
        }
        else
        {
            Console.WriteLine("Front element: " + queueArray[front]);
        }
    }
    public static void Main()
    {
        SimpleQUEUE s1 = new SimpleQUEUE(5);
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
        s1.display();
    }
}
