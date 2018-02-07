public class Queue<T>
{
    #region Members
    private Node<T> Head;
    private Node<T> Tail;
    private int Counter;
    #endregion

    #region Constructor
    public Queue()
    {
        this.Head = null;
        this.Tail = null;
        this.Counter = 0;
    }
    #endregion

    #region Public Methods
    public void Enqueue(T newValue)
    {
        if (this.Head == null)
        {
            this.Head = new Node<T>();
            this.Tail = this.Head;
            this.Head.Value = newValue;
        }
        else
        {
            Node<T> tempNode = new Node<T>();
            tempNode.Value = newValue;

            tempNode.Next = this.Head;
            this.Head.Previous = tempNode;

            this.Head = tempNode;
        }

        this.Counter++;
    }

    public T Dequeue()
    {
        if (this.Tail == null)
            return default(T);

        T valueToReturn = this.Tail.Value;

        if (this.Tail.Previous == null)
        {
            this.Head = null;
            this.Tail = null;
        }
        else
        {
            this.Tail = this.Tail.Previous;
            this.Tail.Next = null;
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