using System;

public class Node<T>
{
    public T Value;
    public Node<T> Next;
    public Node<T> Previous;

    public Node()
    {
        this.Next = null;
        this.Previous = null;
    }
}