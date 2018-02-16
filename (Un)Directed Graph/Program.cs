using System;

namespace MosheBinieli._Un_Directed_Graph
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Graph graph = new Graph();

                AddVerticesAndEdgesToGraph(graph);

                graph.DisplayGraph();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void AddVerticesAndEdgesToGraph(Graph graph)
        {
            graph.AddVertices(1);
            graph.AddVertices(3);
            graph.AddVertices(2);
            graph.AddVertices(5);
            graph.AddVertices(4);

            graph.AddDirectedEdge(1, 2);
            graph.AddDirectedEdge(2, 3);
            graph.AddUnDirectedEdge(4, 5, 112);
        }
    }
}
