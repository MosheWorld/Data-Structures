using System;

public class AVL
{
    #region Members
    private Node Root;
    private int Count;
    #endregion

    #region Add
    public void Add(int data)
    {
        Node newLeaf = new Node(data);

        if (Root == null)
            Root = newLeaf;
        else
            Root = Add(Root, newLeaf);
        Count++;
    }

    private Node Add(Node current, Node newLeaf)
    {
        if (current == null)
        {
            current = newLeaf;
            return current;
        }
        else if (newLeaf.Data < current.Data)
        {
            current.Left = Add(current.Left, newLeaf);
            current = BalanceTree(current);
        }
        else if (newLeaf.Data >= current.Data)
        {
            current.Right = Add(current.Right, newLeaf);
            current = BalanceTree(current);
        }

        return current;
    }
    #endregion

    #region Delete
    public void Delete(int target)
    {
        Root = Delete(Root, target);
    }

    private Node Delete(Node current, int target)
    {
        Node parent;

        if (current == null)
            return null;

        // Left Sub-Tree.
        if (target < current.Data)
        {
            current.Left = Delete(current.Left, target);
            if (BalanceFactor(current) == -2)
            {
                if (BalanceFactor(current.Right) <= 0)
                {
                    current = RotateRR(current);
                }
                else
                {
                    current = RotateRL(current);
                }
            }
        }
        // Right subtree.
        else if (target > current.Data)
        {
            current.Right = Delete(current.Right, target);
            if (BalanceFactor(current) == 2)
            {
                if (BalanceFactor(current.Left) >= 0)
                {
                    current = RotateLL(current);
                }
                else
                {
                    current = RotateLR(current);
                }
            }
        }
        // If target is found.
        else
        {
            if (current.Right != null)
            {
                // Delete its inorder successor.
                parent = current.Right;
                while (parent.Left != null)
                {
                    parent = parent.Left;
                }
                current.Data = parent.Data;
                current.Right = Delete(current.Right, parent.Data);
                if (BalanceFactor(current) == 2) // Rebalancing.
                {
                    if (BalanceFactor(current.Left) >= 0)
                    {
                        current = RotateLL(current);
                    }
                    else { current = RotateLR(current); }
                }
            }
            else
            {   // If current.left != null.
                return current.Left;
            }
        }


        return current;
    }
    #endregion

    #region Find
    public void Find(int key)
    {
        if (Find(key, Root).Data == key)
            Console.WriteLine("{0} was found!", key);
        else
            Console.WriteLine("Nothing found!");
    }

    private Node Find(int target, Node current)
    {
        if (target < current.Data)
        {
            if (target == current.Data)
                return current;
            else
                return Find(target, current.Left);
        }
        else
        {
            if (target == current.Data)
                return current;
            else
                return Find(target, current.Right);
        }
    }
    #endregion

    #region Private Methods
    private Node BalanceTree(Node current)
    {
        int balanceFactor = BalanceFactor(current);

        if (balanceFactor > 1)
        {
            if (BalanceFactor(current.Left) > 0)
            {
                current = RotateLL(current);
            }
            else
            {
                current = RotateLR(current);
            }
        }
        else if (balanceFactor < -1)
        {
            if (BalanceFactor(current.Right) > 0)
            {
                current = RotateRL(current);
            }
            else
            {
                current = RotateRR(current);
            }
        }

        return current;
    }

    private int BalanceFactor(Node current)
    {
        int leftHeight = GetHeight(current.Left);
        int rightHeight = GetHeight(current.Right);

        int balanceFactor = leftHeight - rightHeight;
        return balanceFactor;
    }

    private int Max(int leftValue, int rightValue)
    {
        return leftValue > rightValue ? leftValue : rightValue;
    }

    private int GetHeight(Node current)
    {
        int height = 0;

        if (current != null)
        {
            int leftHeight = GetHeight(current.Left);
            int rightHeight = GetHeight(current.Right);
            int maxHeight = Max(leftHeight, rightHeight);

            height = maxHeight + 1;
        }

        return height;
    }

    private Node RotateRR(Node parent)
    {
        Node pivot = parent.Right;

        parent.Right = pivot.Left;
        pivot.Left = parent;

        return pivot;
    }
    private Node RotateLL(Node parent)
    {
        Node pivot = parent.Left;

        parent.Left = pivot.Right;
        pivot.Right = parent;

        return pivot;
    }
    private Node RotateLR(Node parent)
    {
        Node pivot = parent.Left;
        parent.Left = RotateRR(pivot);

        return RotateLL(parent);
    }
    private Node RotateRL(Node parent)
    {
        Node pivot = parent.Right;
        parent.Right = RotateLL(pivot);

        return RotateRR(parent);
    }
    #endregion

    #region PreOrder
    public void PreOrder()
    {
        if (Root == null)
        {
            Console.WriteLine("Tree is empty");
            return;
        }

        PreOrder(Root);
        Console.WriteLine();
    }

    private void PreOrder(Node leaf)
    {
        if (leaf == null)
            return;

        Console.Write($"({leaf.Data}) ");
        PreOrder(leaf.Left);
        PreOrder(leaf.Right);
    }
    #endregion

    #region InOrder
    public void InOrder()
    {
        if (Root == null)
        {
            Console.WriteLine("Tree is empty");
            return;
        }

        InOrder(Root);
        Console.WriteLine();
    }

    private void InOrder(Node leaf)
    {
        if (leaf == null)
            return;

        InOrder(leaf.Left);
        Console.Write($"({leaf.Data}) ");
        InOrder(leaf.Right);
    }
    #endregion

    #region PostOrder
    public void PostOrder()
    {
        if (Root == null)
        {
            Console.WriteLine("Tree is empty");
            return;
        }

        PostOrder(Root);
        Console.WriteLine();
    }

    private void PostOrder(Node leaf)
    {
        if (leaf == null)
            return;

        PostOrder(leaf.Left);
        PostOrder(leaf.Right);
        Console.Write($"({leaf.Data}) ");
    }
    #endregion
}