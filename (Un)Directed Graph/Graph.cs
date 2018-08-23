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
        DictionaryOfVertices = new Dictionary<int, Vertice>();
    }
    #endregion

    #region Public Methods
    public void AddVertice(int value)
    {
        if (DictionaryOfVertices.ContainsKey(value))
            return;

        DictionaryOfVertices.Add(value, new Vertice(value));
    }

    public void AddDirectedEdge(int source, int destination, int weight = 0)
    {
        Vertice sourceVertice = GetVertice(source);
        Vertice destinationVertice = GetVertice(destination);

        if (sourceVertice == null || destinationVertice == null)
            throw new ArgumentException("Given source value or destination value doesn't exist in graph.");

        if (!sourceVertice.ContainsEdge(destinationVertice))
            sourceVertice.AddEdge(destinationVertice, weight);
    }

    public void AddUnDirectedEdge(int vertice1, int vertice2, int weight = 0)
    {
        Vertice sourceVertice = GetVertice(vertice1);
        Vertice destinationVertice = GetVertice(vertice2);

        if (sourceVertice == null || destinationVertice == null)
            throw new ArgumentException("Given source value or destination value doesn't exist in graph.");

        if (!sourceVertice.ContainsEdge(destinationVertice))
            sourceVertice.AddEdge(destinationVertice, weight);

        if (!destinationVertice.ContainsEdge(sourceVertice))
            destinationVertice.AddEdge(sourceVertice, weight);
    }

    public void DisplayGraph()
    {
        foreach (int key in this.DictionaryOfVertices.Keys)
        {
            Vertice currentVertice = DictionaryOfVertices.GetValueOrDefault(key);

            Console.Write(currentVertice.Value + " : { ");
            currentVertice.DisplayOutgoingVertices();
            Console.Write(" }");

            Console.WriteLine("\n");
        }
    }
    #endregion

    #region Private Methods
    public Vertice GetVertice(int value)
    {
        Vertice verticeToReturn = null;

        if (DictionaryOfVertices.ContainsKey(value))
            verticeToReturn = DictionaryOfVertices.GetValueOrDefault(value);

        return verticeToReturn;
    }
    #endregion
}