using System;

namespace MosheBinieli.Heap
{
    class Program
    {
        static void Main(string[] args)
        {
            Heap<int> myHeap = new Heap<int>();

            InsertValuesToHeap(myHeap);

            PopValueAndDisplay(myHeap);
            PopValueAndDisplay(myHeap);
        }

        private static void PopValueAndDisplay(Heap<int> myHeap)
        {
            int value = myHeap.PopMin();
            Console.WriteLine(value);
        }

        private static void InsertValuesToHeap(Heap<int> myHeap)
        {
            myHeap.Add(1);
            myHeap.Add(6);
            myHeap.Add(3);
        }
    }
}
