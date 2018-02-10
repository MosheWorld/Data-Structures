using System;

namespace MosheBinieli.AVL_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            AVL avlTree = new AVL();

            AddValuesToAVLTree(avlTree);

            avlTree.DisplayTree();

            avlTree.Delete(7);

            avlTree.DisplayTree();
        }

        private static void AddValuesToAVLTree(AVL avlTree)
        {
            avlTree.Add(5);
            avlTree.Add(3);
            avlTree.Add(7);
            avlTree.Add(2);
        }
    }
}
