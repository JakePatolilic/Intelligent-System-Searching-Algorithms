using System;
using System.Collections.Generic;

namespace TreeAlgo
{
    public class Search
    {
        public List<Tuple<char, char, int>> edges; // Tuple represents (vertex1, vertex2, weight)
        public int _V;
        public List<char> steps = new List<char>();
        public bool dfsFlag = false;

        public Search(int v)
        {
            edges = new List<Tuple<char, char, int>>();
            _V = v;
        }

        public void AddEdge(char v, char w, int weight)
        {
            edges.Add(Tuple.Create(v, w, weight));
        }

        public void BFS(char startVertex, char endVertex)
        {
            Queue<char> q = new Queue<char>();
            bool[] visited = new bool[_V];

            q.Enqueue(startVertex);
            visited[startVertex - 'A'] = true; // Assuming vertices are uppercase letters starting from 'A'
            Console.WriteLine(startVertex);

            while (q.Count > 0)
            {
                char currentVertex = q.Dequeue();
                steps.Add(currentVertex);

                if (currentVertex == endVertex)
                {
                    Console.WriteLine("found");
                    break;
                }

                foreach (var edge in edges)
                {
                    char v = edge.Item1;
                    char w = edge.Item2;
                    int weight = edge.Item3;

                    if (v == currentVertex && !visited[w - 'A'])
                    {
                        Console.WriteLine($"{w} (Weight: {weight})");
                        q.Enqueue(w);
                        visited[w - 'A'] = true;
                    }
                    else if (w == currentVertex && !visited[v - 'A'])
                    {
                        Console.WriteLine($"{v} (Weight: {weight})");
                        q.Enqueue(v);
                        visited[v - 'A'] = true;
                    }
                }
            }
        }

        public void DFS(char startVertex, char endVertex)
        {
            bool[] visited = new bool[_V];
            DFSUtil(startVertex, endVertex, visited);
        }

        private void DFSUtil(char currentVertex, char endVertex, bool[] visited)
        {          
            visited[currentVertex - 'A'] = true;
            Console.WriteLine(currentVertex);

            if (!steps.Contains(currentVertex) && dfsFlag == false)
            {
                steps.Add(currentVertex);
            }

            if (currentVertex == endVertex)
            {
                Console.WriteLine("found");
                dfsFlag = true;
                return;
            }

            foreach (var edge in edges)
            {
                char v = edge.Item1;
                char w = edge.Item2;

                if (v == currentVertex && !visited[w - 'A'])
                {
                    DFSUtil(w, endVertex, visited);
                }
                else if (w == currentVertex && !visited[v - 'A'])
                {
                    DFSUtil(v, endVertex, visited);
                }
            }
        }
    }
}
