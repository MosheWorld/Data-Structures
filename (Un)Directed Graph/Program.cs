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
            graph.AddVertice(1);
            graph.AddVertice(3);
            graph.AddVertice(2);
            graph.AddVertice(5);
            graph.AddVertice(4);

            graph.AddDirectedEdge(1, 2);
            graph.AddDirectedEdge(2, 3);
            graph.AddUnDirectedEdge(4, 5, 112);
        }
    }
}
