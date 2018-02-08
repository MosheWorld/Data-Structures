public class Node<T>
{
    #region Members
    public T Value;
    public Node<T> Left;
    public Node<T> Right;
    #endregion

    #region Constructor
    public Node()
    {
        this.Left = null;
        this.Right = null;
    }
    #endregion
}