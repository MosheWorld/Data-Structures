public class Node
{
    #region Members
    public int Value;
    public Node Left;
    public Node Right;
    public Node Parent;
    #endregion

    #region Constructor
    public Node()
    {
        Left = null;
        Right = null;
        Parent = null;
        Value = 0;
    }
    #endregion
}