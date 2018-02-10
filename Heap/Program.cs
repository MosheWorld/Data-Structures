using System;

namespace MosheBinieli.HeapGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
            Could have implemented strategy & factory pattern with executor class, but I avoid it to let it stay simple.

            here is whole project in my GitHub for design patterns.
            https://github.com/MosheWorld/Design-Patterns
             */
            try
            {
                HeapExecutor executor = new HeapExecutor();

                executor.ExecuteMinHeap();

                Console.WriteLine();

                executor.ExecuteMaxHeap();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
