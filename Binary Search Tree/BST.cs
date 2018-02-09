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
        Console.WriteLine();
    }

    public void InOrder()
    {
        InOrderExecute(this.Root);
        Console.WriteLine();
    }

    public void Delete(int valueToRemove)
    {
        this.Root = DeleteRec(this.Root, valueToRemove);
    }
    #endregion

    #region Private Methods
    private void InsertValueRecursively(Node Leaf, int newValue)
    {
        if (newValue <= Leaf.Value)
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

        Console.Write($"{Leaf.Value} ");
        PreOrderExecute(Leaf.Left);
        PreOrderExecute(Leaf.Right);
    }

    private void InOrderExecute(Node Leaf)
    {
        if (Leaf == null)
            return;

        InOrderExecute(Leaf.Left);
        Console.Write($"{Leaf.Value} ");
        InOrderExecute(Leaf.Right);
    }

    private Node DeleteRec(Node root, int key)
    {

        if (root == null)
            return root;

        if (key < root.Value)
            root.Left = DeleteRec(root.Left, key);
        else if (key > root.Value)
            root.Right = DeleteRec(root.Right, key);
        else
        {
            // Node with only one child or no child.
            if (root.Left == null)
                return root.Right;
            else if (root.Right == null)
                return root.Left;

            // Node with two children: Get the inorder successor ( Smallest in the right subtree )
            root.Value = MinValue(root.Right);

            // Delete the inorder successor
            root.Right = DeleteRec(root.Right, root.Value);
        }

        return root;
    }
    private int MinValue(Node root)
    {
        int min = root.Value;

        while (root.Left != null)
        {
            min = root.Left.Value;
            root = root.Left;
        }

        return min;
    }
    #endregion
}