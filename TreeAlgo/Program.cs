using TreeAlgo;
public class Program
{
    private static void Main(string[] args)
    {
        var graph = new Search('Z');
        graph.AddEdge('A', 'B', 5);
        graph.AddEdge('A', 'C', 4);
        //graph.AddEdge('B', 'C', 10);
        graph.AddEdge('B', 'G', 5);
        graph.AddEdge('C', 'D', 7);
        graph.AddEdge('D', 'E', 5);
        graph.AddEdge('E', 'F', 5);
        

        Console.WriteLine("Breadth First Traversal starting from vertex 2:");
        //graph.BFS('A', 'C');
        graph.DFS('A', 'G');
        Console.WriteLine("\n\n steps:\n");
        foreach(int n in graph.steps)
        {
            Console.WriteLine(n);
        }
    }
}