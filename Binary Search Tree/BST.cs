using System;

public class BST
{
    #region Members
    private Node Root;
    private int Counter;
    #endregion

    #region Constructor
    public BST()
    {
        this.Root = null;
    }
    #endregion

    #region Public Methods
    public int Count()
    {
        return this.Counter;
    }

    public void Add(int newValue)
    {
        if (this.Root == null)
        {
            this.Root = new Node();
            this.Root.Value = newValue;
        }
        else
        {
            InsertValueRecursively(this.Root, newValue);
        }

        this.Counter++;
    }

    public void PreOrder()
    {
        PreOrderExecute(this.Root);
    }
    #endregion

    #region Private Methods
    private void InsertValueRecursively(Node Leaf, int newValue)
    {
        if (newValue < Leaf.Value)
        {
            if (Leaf.Left == null)
                Leaf.Left = DynamicAllocationWithValueInsertion(newValue, Leaf);
            else
                InsertValueRecursively(Leaf.Left, newValue);
        }
        else
        {
            if (Leaf.Right == null)
                Leaf.Right = DynamicAllocationWithValueInsertion(newValue, Leaf);
            else
                InsertValueRecursively(Leaf.Right, newValue);
        }
    }

    private Node DynamicAllocationWithValueInsertion(int newValue, Node connectParentLeaf)
    {
        Node newNode = new Node();

        newNode.Parent = connectParentLeaf;
        newNode.Value = newValue;

        return newNode;
    }

    private void PreOrderExecute(Node Leaf)
    {
        if (Leaf == null)
            return;

        Console.Write(Leaf.Value);
        PreOrderExecute(Leaf.Left);
        PreOrderExecute(Leaf.Right);
    }
    #endregion
}