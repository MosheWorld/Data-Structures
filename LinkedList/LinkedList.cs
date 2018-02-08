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

    }

    public void InsertToEnd(T newValue)
    {

    }

    public int Count()
    {
        return this.Counter;
    }
    #endregion
}