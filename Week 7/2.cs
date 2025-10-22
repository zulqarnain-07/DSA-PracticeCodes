// Scenario: This program simulates a queue system for an amusement park ride. 
// Visitors join the queue, take the ride, and leave in a first-come, first-served order.

using System;

class AmusementParkRide
{
    class Queue
    {
        private string[] line;
        private int max;
        private int front;
        private int rear;

        public Queue(int size)
        {
            front = -1;
            rear = -1;
            max = size;
            line = new string[size];
        }

        public bool IsFull()
        {
            return rear == max - 1;
        }

        public bool IsEmpty()
        {
            return (front == -1 && rear == -1);
        }

        public void Enqueue(string value)
        {
            if (IsFull())
            {
                Console.WriteLine("Queue is full. Cannot add " + value);
                return;
            }

            if (IsEmpty())
            {
                front = 0;
                rear = 0;
                line[rear] = value;
            }
            else
            {
                rear++;
                line[rear] = value;
            }

            Console.WriteLine(value + " joined the ride queue.");
        }

        public void Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty. Nothing to dequeue.");
                return;
            }

            Console.WriteLine(line[front] + " has taken the ride and left the queue.");

            if (front == rear)
            {
                front = rear = -1;
            }
            else
            {
                front++;
            }
        }

        public void Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty.");
                return;
            }

            Console.WriteLine("Next person for the ride: " + line[front]);
        }

        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty.");
                return;
            }

            Console.WriteLine("\nPeople currently in queue:");
            for (int i = front; i <= rear; i++)
            {
                Console.WriteLine(line[i]);
            }
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Amusement Park Ride Queue Simulation\n");

        Queue rideQueue = new Queue(5);

        rideQueue.Enqueue("A");
        rideQueue.Enqueue("B");
        rideQueue.Enqueue("C");
        rideQueue.Enqueue("D");
        rideQueue.Display();

        rideQueue.Peek();

        rideQueue.Dequeue();
        rideQueue.Peek();
        rideQueue.Display();
    }
}
