using System;
using System.Collections.Generic;

public class LinkedList<T>
{
    #region Members
    private Node<T> Head;
    private Node<T> Tail;
    private int Counter;
    #endregion

    #region Constructor
    public LinkedList()
    {
        this.Head = null;
        this.Tail = null;
        this.Counter = 0;
    }
    #endregion

    #region Public Methods
    public void InsertToStart(T newValue)
    {
        if (this.Head == null)
            DynamicAllocationFirstNode(newValue);
        else
        {
            Node<T> newNode = new Node<T>();
            newNode.Value = newValue;

            newNode.Next = this.Head;
            this.Head.Previous = newNode;

            this.Head = newNode;
        }

        this.Counter++;
    }

    public void InsertToEnd(T newValue)
    {
        if (this.Head == null)
            DynamicAllocationFirstNode(newValue);
        else
        {
            Node<T> newNode = new Node<T>();
            newNode.Value = newValue;

            newNode.Previous = this.Tail;
            this.Tail.Next = newNode;

            this.Tail = newNode;
        }

        this.Counter++;
    }

    public int Count()
    {
        return this.Counter;
    }

    public void DisplayFromBeginning()
    {
        Node<T> runner = this.Head;

        while (runner != null)
        {
            Console.Write($"{runner.Value} -> ");
            runner = runner.Next;
        }

        Console.WriteLine();
    }

    public void DisplayFromEnd()
    {
        Node<T> runner = this.Tail;

        while (runner != null)
        {
            Console.Write($"{runner.Value} -> ");
            runner = runner.Previous;
        }

        Console.WriteLine();
    }

    public T ValueAt(int index)
    {
        if (index > this.Counter || index < 0)
            return default(T);

        Node<T> runner = this.Head;

        while (index != 0)
        {
            runner = runner.Next;
            index--;
        }

        return runner.Value;
    }

    public List<T> ToList()
    {
        List<T> generatedList = new List<T>(this.Counter);

        Node<T> runner = this.Head;

        while (runner != null)
        {
            generatedList.Add(runner.Value);
            runner = runner.Next;
        }

        return generatedList;
    }

    public void DeleteIndex(int index)
    {
        if (index < 0 || index > this.Counter)
            throw new ArgumentException("Index location is invalid.");

        Node<T> runner = this.Head;

        while (index != 0)
        {
            runner = runner.Next;
            index--;
        }

        PerformDeleteOfItem(runner);
    }
    #endregion

    #region Private Methods
    private void DynamicAllocationFirstNode(T newValue)
    {
        this.Head = new Node<T>();
        this.Tail = this.Head;
        this.Head.Value = newValue;
    }

    private void PerformDeleteOfItem(Node<T> runner)
    {
        Node<T> previous = runner.Previous;
        Node<T> next = runner.Next;

        // In case the head is about to be removed.
        if (previous == null)
            this.Head = this.Head.Next;

        // In case the tail is about to be removed.
        if (next == null)
            this.Tail = this.Tail.Previous;

        runner.Next = null;
        runner.Previous = null;

        if (previous != null)
            previous.Next = next;


        if (next != null)
            next.Previous = previous;

    }
    #endregion
}