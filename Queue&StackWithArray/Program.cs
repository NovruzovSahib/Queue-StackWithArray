using System;
internal class QueueWithArray
{

    public static void Main(String[] args)
    {
        Queue queue = new Queue(5);
        queue.queueEnqueue(20);
        queue.queueEnqueue(30);
        queue.queueEnqueue(40);
        queue.queueEnqueue(50);
        queue.ShowQueue();

        Console.WriteLine("After added new queue");
        queue.queueEnqueue(60);
        queue.ShowQueue();

        queue.queueDequeue();
        queue.queueDequeue();
        queue.queueDequeue();
        Console.Write("After two queue deletion");
        queue.ShowQueue();

        queue.queueFront();
        Console.WriteLine();
        queue.queueRear();
    }
}
public class Queue
{
    private int front, rear, capacity;
    private int[] queue;

    public Queue(int c)
    {
        front = rear = 0;
        capacity = c;
        queue = new int[capacity];
    }
    public void ShowQueue()
    {
        if (front == rear)
        {
            Console.WriteLine("Queue is Empty");
            return;
        }
        Console.WriteLine("Queue elements");
        for (int i = front; i < rear; i++)
        {
            Console.WriteLine(queue[i]);
        }
    }
    public void queueEnqueue(int data)
    {
        if (capacity == rear)
        {
            Console.WriteLine("Queue is full");
            return;
        }
        else
        {
            queue[rear] = data;
            rear++;
        }
    }
    public void queueDequeue()
    {
        if (front == rear)
        {
            Console.WriteLine("Queue is empty");
            return;
        }
        else
        {
            for (int i = 0; i < rear - 1; i++)
            {
                queue[i] = queue[i + 1];
            }

            if (rear < capacity)
                queue[rear] = 0;
            rear--;
        }
    }
 
    public void queueFront()
    {
        if (front == rear)
        {
            Console.WriteLine("Queue is Empty");
            return;
        }
        Console.Write("Front Element is: {0}",
                    queue[front]);
    }
    public void queueRear()
    {
        if (front == rear)
        {
            Console.WriteLine("Queue is Empty");
            return;
        }
        Console.Write("Rear Element is: {0}",
                    queue[rear]);
    }
}


