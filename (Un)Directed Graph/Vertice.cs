using System;
using System.Collections.Generic;

public class Vertice
{
    #region Members
    public int Value { get; set; }
    public List<Edge> OutgoingVertices { get; set; }
    #endregion

    #region Constructor
    public Vertice(int value)
    {
        Value = value;
        OutgoingVertices = new List<Edge>();
    }
    #endregion

    #region Public Methods
    public void AddEdge(Vertice destinationVertice, int weight = 0)
    {
        Edge newEdge = new Edge(this, destinationVertice, weight);
        OutgoingVertices.Add(newEdge);
    }

    public void DisplayOutgoingVertices()
    {
        foreach (Edge item in this.OutgoingVertices)
            Console.Write($"[Value: {item.Destination.Value}, Weight: {item.Weight}]");
    }

    public bool ContainsEdge(Vertice destinationVertice)
    {
        foreach (Edge edge in OutgoingVertices)
            if (edge.Destination == destinationVertice)
                return true;

        return false;
    }
    #endregion
}