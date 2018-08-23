using System;

public class KeyValue<K, V>
{
    #region Members
    public K Key { get; set; }
    public V Value { get; set; }
    #endregion

    #region Constructor
    public KeyValue()
    {
        Key = default(K);
        Value = default(V);
    }
    #endregion
}