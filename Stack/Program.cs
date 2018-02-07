using System;

namespace MosheBinieli.Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> myStack = new Stack<int>();

            AddValuesToStack(myStack);

            myStack.Pop();

            myStack.Pop();

            int valueFromStack = myStack.Pop();

            Console.WriteLine(valueFromStack);
        }

        private static void AddValuesToStack(Stack<int> myStack)
        {
            myStack.Push(2);
            myStack.Push(4);
            myStack.Push(12);
        }
    }
}
