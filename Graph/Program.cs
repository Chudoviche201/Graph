using System;

class Graph
{
    private int V; // число вершин
    private int[,] adjMatrix; // матрица смежности

    // конструктор
    public Graph(int v)
    {
        V = v;
        adjMatrix = new int[V, V];
        for (int i = 0; i < V; i++)
        {
            for (int j = 0; j < V; j++)
            {
                adjMatrix[i, j] = 0; // заполняем матрицу смежности нулями
            }
        }
    }

    // добавление ребра
    public void AddEdge(int i, int j)
    {
        adjMatrix[i, j] = 1;
        adjMatrix[j, i] = 1;
    }

    // построение матрицы смежности
    public void PrintAdjMatrix()
    {
        Console.WriteLine("Матрица смежности:");
        for (int i = 0; i < V; i++)
        {
            for (int j = 0; j < V; j++)
            {
                Console.Write(adjMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Graph g = new Graph(5);
        g.AddEdge(0, 1);
        g.AddEdge(0, 4);
        g.AddEdge(1, 2);
        g.AddEdge(1, 3);
        g.AddEdge(1, 4);
        g.AddEdge(2, 3);
        g.AddEdge(3, 4);

        g.PrintAdjMatrix();
    }
}