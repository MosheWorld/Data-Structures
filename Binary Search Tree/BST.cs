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
        Root = null;
    }
    #endregion

    #region Public Methods
    public int Count()
    {
        return Counter;
    }

    public void Add(int value)
    {
        if (Root == null)
        {
            Root = new Node();
            Root.Value = value;
        }
        else
            Add(Root, value);

        Counter++;
    }

    public void PreOrder()
    {
        PreOrder(Root);
        Console.WriteLine();
    }

    public void InOrder()
    {
        InOrder(Root);
        Console.WriteLine();
    }

    public void PostOrder()
    {
        PostOrder(Root);
        Console.WriteLine();
    }

    public void Delete(int value)
    {
        Root = Delete(Root, value);
        Counter--;
    }
    #endregion

    #region Private Methods
    private void Add(Node Leaf, int newValue)
    {
        if (newValue <= Leaf.Value)
        {
            if (Leaf.Left == null)
                Leaf.Left = DynamicAllocationWithValueInsertion(newValue, Leaf);
            else
                Add(Leaf.Left, newValue);
        }
        else
        {
            if (Leaf.Right == null)
                Leaf.Right = DynamicAllocationWithValueInsertion(newValue, Leaf);
            else
                Add(Leaf.Right, newValue);
        }
    }

    private Node DynamicAllocationWithValueInsertion(int value, Node parentLeaf)
    {
        return new Node
        {
            Value = value,
            Parent = parentLeaf,
        };
    }

    private void PreOrder(Node Leaf)
    {
        if (Leaf == null)
            return;

        Console.Write($"{Leaf.Value} ");
        PreOrder(Leaf.Left);
        PreOrder(Leaf.Right);
    }

    private void InOrder(Node Leaf)
    {
        if (Leaf == null)
            return;

        InOrder(Leaf.Left);
        Console.Write($"{Leaf.Value} ");
        InOrder(Leaf.Right);
    }

    private void PostOrder(Node Leaf)
    {
        PostOrder(Leaf.Left);
        PostOrder(Leaf.Right);
        Console.Write($"{Leaf.Value} ");
    }

    private Node Delete(Node root, int key)
    {

        if (root == null)
            return root;

        if (key < root.Value)
            root.Left = Delete(root.Left, key);
        else if (key > root.Value)
            root.Right = Delete(root.Right, key);
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
            root.Right = Delete(root.Right, root.Value);
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