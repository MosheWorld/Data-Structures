using System;
using System.Collections.Generic;

public class Heap<T> where T : IComparable
{
    #region Members
    private List<T> elements = new List<T>();
    #endregion

    #region Public Methods
    public int GetSize()
    {
        return elements.Count;
    }

    public T GetMin()
    {
        return this.elements.Count > 0 ? this.elements[0] : default(T);
    }

    public void Add(T item)
    {
        elements.Add(item);
        this.HeapifyUp(elements.Count - 1);
    }

    public T PopMin()
    {
        if (elements == null || elements.Count == 0)
            throw new InvalidOperationException("No element in heap.");

        T item = elements[0];
        elements[0] = elements[elements.Count - 1];
        elements.RemoveAt(elements.Count - 1);

        this.HeapifyDown(0);
        
        return item;
    }
    #endregion

    #region Private Methods
    private void HeapifyUp(int index)
    {
        int parent = this.GetParent(index);

        if (parent >= 0 && elements[index].CompareTo(elements[parent]) < 0)
        {
            Swap(index, parent);
            this.HeapifyUp(parent);
        }
    }

    private void HeapifyDown(int index)
    {
        var smallest = index;

        var left = this.GetLeft(index);
        var right = this.GetRight(index);

        if (left < this.GetSize() && elements[left].CompareTo(elements[index]) < 0)
        {
            smallest = left;
        }

        if (right < this.GetSize() && elements[right].CompareTo(elements[smallest]) < 0)
        {
            smallest = right;
        }

        if (smallest != index)
        {
            Swap(index, smallest);
            this.HeapifyDown(smallest);
        }
    }

    private int GetParent(int index)
    {
        if (index <= 0)
            return -1;

        return (index - 1) / 2;
    }

    private int GetLeft(int index)
    {
        return 2 * index + 1;
    }

    private int GetRight(int index)
    {
        return 2 * index + 2;
    }

    private void Swap(int index, int smallest)
    {
        T temp = elements[index];
        elements[index] = elements[smallest];
        elements[smallest] = temp;
    }
    #endregion
}