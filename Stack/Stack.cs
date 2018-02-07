using System;

public class Stack<T>
{
    #region Members
    private Node<T> Head;
    private Node<T> Tail;
    private int Counter;
    #endregion

    #region Constructor
    public Stack()
    {
        this.Head = null;
        this.Tail = null;
        this.Counter = 0;
    }
    #endregion

    #region Public Methods
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
            this.Head.Next.Previous = this.Head;
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

    public T Pop()
    {
        if (this.Head == null)
            return default(T);

        T valueToReturn = this.Head.Value;

        if (this.Head.Previous == null)
        {
            this.Head = null;
            this.Tail = null;
        }
        else
        {
            this.Head = this.Head.Previous;
            this.Head.Next = null;
        }

        this.Counter--;
        return valueToReturn;
    }

    public int Count()
    {
        return this.Counter;
    }
    #endregion
}