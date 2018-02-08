public class Node<T>
{
    #region Members
    public T Value;
    public Node<T> Next;
    public Node<T> Previous;
    #endregion

    #region Constructor
    public Node()
    {
        this.Next = null;
        this.Previous = null;
    }
    #endregion
}