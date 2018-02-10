using System;
using System.Collections.Generic;

public class MinHeap : AbstractHeap
{
    #region Public Methods
    public int GetMin()
    {
        return this.GetValueOfHeapAtTop();
    }

    public int PopMin()
    {
        if (elements == null || elements.Count == 0)
            throw new InvalidOperationException("No element in heap.");

        int item = elements[0];
        elements[0] = elements[elements.Count - 1];
        elements.RemoveAt(elements.Count - 1);

        this.HeapifyDown(0);

        return item;
    }

    public override void Add(int item)
    {
        elements.Add(item);
        this.HeapifyUp(elements.Count - 1);
    }
    #endregion

    #region Protected Methods
    protected override void HeapifyUp(int index)
    {
        int parent = this.GetParent(index);

        if (parent >= 0 && elements[index].CompareTo(this.elements[parent]) < 0)
        {
            this.Swap(index, parent);
            HeapifyUp(parent);
        }
    }

    protected override void HeapifyDown(int index)
    {
        var smallest = index;

        var left = this.GetLeft(index);
        var right = this.GetRight(index);

        if (left < this.GetSize() && elements[left].CompareTo(elements[index]) < 0)
            smallest = left;

        if (right < this.GetSize() && elements[right].CompareTo(elements[smallest]) < 0)
            smallest = right;

        if (smallest != index)
        {
            this.Swap(index, smallest);
            HeapifyDown(smallest);
        }
    }
    #endregion
}