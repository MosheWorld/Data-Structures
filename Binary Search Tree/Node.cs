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
        this.Left = null;
        this.Right = null;
        this.Parent = null;
        this.Value = 0;
    }
    #endregion
}