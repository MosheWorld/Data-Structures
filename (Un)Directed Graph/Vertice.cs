using System;
using System.Collections.Generic;

public class Vertice
{
    #region Members
    public int Value { get; set; }
    public List<Edge> OutgoingVertices { get; set; }
    public List<Edge> IncomingVertices { get; set; }
    #endregion

    #region Constructor
    public Vertice(int newValue)
    {
        this.Value = newValue;
        this.OutgoingVertices = new List<Edge>();
        this.IncomingVertices = new List<Edge>();
    }
    #endregion
}