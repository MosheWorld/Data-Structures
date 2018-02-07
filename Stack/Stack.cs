using System;

public class Stack<T>
{
    private Node<T> Head;
    private Node<T> Tail;
    private int Counter;

    public Stack()
    {
        this.Head = null;
        this.Tail = null;
        this.Counter = 0;
    }

    public void Push(T newValue)
    {
        if (this.Head == null)
        {
            this.Head = new Node<T>();
            this.Tail = this.Head;
        }
        else
        {
            this.Head.Next = new Node<T>();
            this.Head = this.Head.Next;
        }

        this.Head.Value = newValue;
        this.Counter++;
    }

    public T Top()
    {
        if (this.Head != null)
        {
            return this.Head.Value;
        }

        return default(T);
    }

    public void DisplayStack()
    {
        Node<T> Inspector;

        if (this.Tail == null)
            return;

        Inspector = this.Tail;

        while (Inspector != null)
        {
            Console.Write($"{Inspector.Value}-> ");
            Inspector = Inspector.Next;
        }

        Console.WriteLine();
    }

    public int Count()
    {
        return this.Counter;
    }
}