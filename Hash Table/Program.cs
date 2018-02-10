using System;

namespace MosheBinieli.Hash_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            HashTable<string, string> hashTable = new HashTable<string, string>(20);

            AddValuesToHashTable(hashTable);

            string one = hashTable.Find("1");
            string two = hashTable.Find("2");
            string seven = hashTable.Find("7");

            Console.WriteLine($"{one} \n{two} \n{seven}");

            hashTable.Remove("1");

            one = hashTable.Find("1");

            if (one != null)
                Console.WriteLine(one);
            else
                Console.WriteLine("Nothing has been found.");
        }

        private static void AddValuesToHashTable(HashTable<string, string> hashTable)
        {
            hashTable.Add("1", "item 1");
            hashTable.Add("2", "item 2");
            hashTable.Add("7", "item 7");
        }
    }
}
