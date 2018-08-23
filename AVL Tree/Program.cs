namespace MosheBinieli.AVL_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            AVL avlTree = CreateValuesForTree();

            avlTree.InOrder();

            avlTree.Delete(7);

            avlTree.InOrder();
        }

        private static AVL CreateValuesForTree()
        {
            AVL avlTree = new AVL();

            avlTree.Add(5);
            avlTree.Add(3);
            avlTree.Add(7);
            avlTree.Add(2);

            return avlTree;
        }
    }
}
