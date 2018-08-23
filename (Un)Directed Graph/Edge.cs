public class Edge
{
    #region Members
    public int Weight { get; set; }
    public Vertice Source { get; set; }
    public Vertice Destination { get; set; }
    #endregion

    #region Constructor
    public Edge(Vertice newSourceVertice, Vertice newDestinationVertice, int weight = 0)
    {
        Weight = weight;
        Source = newSourceVertice;
        Destination = newDestinationVertice;
    }
    #endregion
}