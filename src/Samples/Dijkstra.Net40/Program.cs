using Dijkstra.NET.Graph;
using Dijkstra.NET.ShortestPath;

namespace Dijkstra.Net40
{
    class Program
    {
        static void Main(string[] args)
        {
            var graph = new Graph<int, string>() + 1 + 2;

            bool connected = graph >> 1 >> 2 >> 5 ^ "edge information";

            var immutablePath = graph.Dijkstra(1, 2);
            var immutablePathDescriptions = immutablePath.GetPathEdgesCustom(graph);


            var graph2 = new Graph<string, string>();
            graph2.AddNode("one");
            graph2.AddNode("two");
            graph2.AddNode("three");

            graph2.Connect("one", "two", 1, "customm");
            graph2.Connect("two", "three", 1, "customm2");

            //var immutablePath = graph.Dijkstra(1, 2);


            var nodeKey = graph2.GetNodeFirstKeyByValue("one");


        }
    }
}
