using System;

namespace MosheBinieli.Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> myQueue = new Queue<int>();

            AddValuesToQueue(myQueue);

            myQueue.Dequeue();
            int valueFromQueue = myQueue.Dequeue();

            Console.WriteLine(valueFromQueue);
        }

        private static void AddValuesToQueue(Queue<int> myQueue)
        {
            myQueue.Enqueue(2);
            myQueue.Enqueue(4);
            myQueue.Enqueue(12);
        }
    }
}
