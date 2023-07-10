using System;

class StackWithArray
{
    static void Main(string[] args)
    {
        Stack stack = new Stack(5);
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);
        stack.Push(40);
        stack.ShowStack();

        Console.WriteLine("After adding new item to stack");
        stack.Push(50);
        stack.ShowStack();

        stack.Pop();
        stack.Pop();
        Console.Write("After two item removal from stack: ");
        stack.ShowStack();

        stack.Peek();
    }
}

class Stack
{
    private int top;
    private int capacity;
    private int[] stack;

    public Stack(int size)
    {
        top = -1;
        capacity = size;
        stack = new int[capacity];
    }

    public void Push(int item)
    {
        if (top == capacity - 1)
        {
            Console.WriteLine("Stack is full. Cannot push.");
            return;
        }

        stack[++top] = item;
    }

    public int Pop()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack is empty. Cannot pop.");
            return -1;
        }

        return stack[top--];
    }

    public int Peek()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack is empty. Cannot peek.");
            return -1;
        }

        Console.WriteLine("Top element in stack: " + stack[top]);
        return stack[top];
    }

    public void ShowStack()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack is empty.");
            return;
        }

        Console.WriteLine("Stack elements:");
        for (int i = top; i >= 0; i--)
        {
            Console.WriteLine(stack[i]);
        }
    }
}
