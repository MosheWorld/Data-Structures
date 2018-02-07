using System;

namespace MosheBinieli.Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> myStack = new Stack<int>();

            myStack.Push(1);
            myStack.Push(1);
            myStack.Push(1);
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(1);

            myStack.DisplayStack();
        }
    }
}
