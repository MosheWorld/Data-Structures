using System;

public class HeapExecutor
{
    public int value { get; set; }

    #region Main
    public void ExecuteMinHeap()
    {
        MinHeap myHeap = new MinHeap();

        myHeap.Add(1);
        myHeap.Add(6);
        myHeap.Add(3);

        value = myHeap.PopMin();
        Console.WriteLine(value);

        value = myHeap.PopMin();
        Console.WriteLine(value);
    }

    public void ExecuteMaxHeap()
    {
        MaxHeap myHeap = new MaxHeap();

        myHeap.Add(1);
        myHeap.Add(6);
        myHeap.Add(3);

        value = myHeap.PopMax();
        Console.WriteLine(value);

        value = myHeap.PopMax();
        Console.WriteLine(value);
    }
    #endregion
}