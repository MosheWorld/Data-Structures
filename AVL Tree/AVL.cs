using System;

public class AVL
{
    #region Members
    private Node Root;
    #endregion

    #region Public Methods
    public void Add(int newData)
    {
        Node newLeaf = new Node(newData);

        if (this.Root == null)
            this.Root = newLeaf;
        else
            this.Root = RecursiveInsert(this.Root, newLeaf);
    }

    public void DisplayTree()
    {
        if (this.Root == null)
        {
            Console.WriteLine("Tree is empty");
            return;
        }

        InOrderDisplayTree(this.Root);

        Console.WriteLine();
    }

    public void Delete(int target)
    {
        this.Root = Delete(this.Root, target);
    }

    public void Find(int key)
    {
        if (Find(key, this.Root).Data == key)
            Console.WriteLine("{0} was found!", key);
        else
            Console.WriteLine("Nothing found!");
    }
    #endregion

    #region Private Methods
    private Node RecursiveInsert(Node current, Node newLeaf)
    {
        if (current == null)
        {
            current = newLeaf;
            return current;
        }
        else if (newLeaf.Data < current.Data)
        {
            current.Left = RecursiveInsert(current.Left, newLeaf);
            current = BalanceTree(current);
        }
        else if (newLeaf.Data >= current.Data)
        {
            current.Right = RecursiveInsert(current.Right, newLeaf);
            current = BalanceTree(current);
        }

        return current;
    }

    private Node BalanceTree(Node current)
    {
        int bFactor = BalanceFactor(current);

        if (bFactor > 1)
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
        else if (bFactor < -1)
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

    private void InOrderDisplayTree(Node current)
    {
        if (current != null)
        {
            InOrderDisplayTree(current.Left);
            Console.Write($"({current.Data}) ");
            InOrderDisplayTree(current.Right);
        }
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
        //right subtree
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
        //if target is found
        else
        {
            if (current.Right != null)
            {
                //delete its inorder successor
                parent = current.Right;
                while (parent.Left != null)
                {
                    parent = parent.Left;
                }
                current.Data = parent.Data;
                current.Right = Delete(current.Right, parent.Data);
                if (BalanceFactor(current) == 2)//rebalancing
                {
                    if (BalanceFactor(current.Left) >= 0)
                    {
                        current = RotateLL(current);
                    }
                    else { current = RotateLR(current); }
                }
            }
            else
            {   // If current.left != null
                return current.Left;
            }
        }


        return current;
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
}