using System;
using System.Collections.Generic;

namespace MosheBinieli.LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> myLinked = new LinkedList<int>();

            InsertValuesRandomly(myLinked);

            myLinked.DisplayFromBeginning();

            Console.WriteLine(myLinked.ValueAt(3));

            List<int> integerCollection = myLinked.ToList();

            foreach (int item in integerCollection)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();

            myLinked.DeleteIndex(6);

            myLinked.DisplayFromBeginning();
        }

        private static void InsertValuesRandomly(LinkedList<int> myLinked)
        {
            myLinked.InsertToStart(1);
            myLinked.InsertToStart(2);
            myLinked.InsertToStart(3);
            myLinked.InsertToStart(4);

            myLinked.InsertToEnd(5);
            myLinked.InsertToEnd(6);
            myLinked.InsertToEnd(7);
        }
    }
}
