using System;

namespace MosheBinieli.Binary_Search_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            BST bst = new BST();

            bst.Add(3);
            bst.Add(6);
            bst.Add(5);
            bst.Add(7);
            bst.Add(1);

            bst.InOrder();

            bst.Delete(6);

            bst.InOrder();
        }
    }
}
