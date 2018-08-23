public class Node
{
    #region Members
    public int Data;
    public Node Left;
    public Node Right;
    #endregion

    #region Constructor
    public Node(int newData)
    {
        Data = newData;
        Left = null;
        Right = null;
    }
    #endregion
}