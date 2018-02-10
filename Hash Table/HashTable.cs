using System;
using System.Collections.Generic;

public class HashTable<K, V>
{
    #region Members
    private int size;
    private LinkedList<KeyValue<K, V>>[] items;
    #endregion

    #region Constructor
    public HashTable(int size)
    {
        this.size = size;
        this.items = new LinkedList<KeyValue<K, V>>[size];
    }
    #endregion

    #region Public Methods
    public V Find(K key)
    {
        int position = GetArrayPosition(key);

        LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);

        foreach (KeyValue<K, V> item in linkedList)
        {
            if (item.Key.Equals(key))
            {
                return item.Value;
            }
        }

        return default(V);
    }

    public void Add(K key, V value)
    {
        int position = GetArrayPosition(key);

        LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
        KeyValue<K, V> item = new KeyValue<K, V>() { Key = key, Value = value };

        linkedList.AddLast(item);
    }

    public void Remove(K key)
    {
        int position = GetArrayPosition(key);

        LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);

        foreach (KeyValue<K, V> item in linkedList)
        {
            if (item.Key.Equals(key))
            {
                linkedList.Remove(item);
                break;
            }
        }

    }
    #endregion

    #region Private Methods
    private int GetArrayPosition(K key)
    {
        return Math.Abs(key.GetHashCode() % size);
    }

    private LinkedList<KeyValue<K, V>> GetLinkedList(int position)
    {
        LinkedList<KeyValue<K, V>> linkedList = items[position];

        if (linkedList == null)
        {
            linkedList = new LinkedList<KeyValue<K, V>>();
            items[position] = linkedList;
        }

        return linkedList;
    }
    #endregion
}