using System;
using System.Collections.Generic;

public class Graph
{
    #region Members
    public Dictionary<int, Vertice> DictionaryOfVertices { get; set; }
    #endregion

    #region Constructor
    public Graph()
    {
        this.DictionaryOfVertices = new Dictionary<int, Vertice>();
    }
    #endregion

    #region Public Methods
    public void AddVertices(int newVerticesValue)
    {
        if (this.DictionaryOfVertices.ContainsKey(newVerticesValue))
            return;

        this.DictionaryOfVertices.Add(newVerticesValue, new Vertice(newVerticesValue));
    }

    public void AddDirectedEdge(int source, int destination)
    {
        Vertice sourceVertice = null, destinationVertice = null;

        if (this.DictionaryOfVertices.ContainsKey(source))
            sourceVertice = this.DictionaryOfVertices.GetValueOrDefault(source);

        if (this.DictionaryOfVertices.ContainsKey(destination))
            destinationVertice = this.DictionaryOfVertices.GetValueOrDefault(destination);

        if (sourceVertice == null || destinationVertice == null)
            throw new ArgumentException("Given source value or destination value doesn't exist in graph.");
    }

    public void AddUnDirectedEdge(int vertice1, int vertice2)
    {

    }

    public void DisplayGraph()
    {
        foreach (int key in this.DictionaryOfVertices.Keys)
        {
            Vertice currentVertice = this.DictionaryOfVertices.GetValueOrDefault(key);

            Console.WriteLine(currentVertice.Value);
        }
    }
    #endregion
}