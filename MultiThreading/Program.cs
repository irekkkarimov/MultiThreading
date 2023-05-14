using BenchmarkDotNet;
using BenchmarkDotNet.Running;
using Multu_Threading;

namespace MultiThreading;

public class Program
{
    public static void Main(string[] args)
    {
        
    }

    public static void GaussTester()
    {
        var equations1 = new[]
        {
            new double[] { 5, 4, 3, 2, 1 },
            new double[] { 6, 2, 4, 7, 1 },
            new double[] { 4, 8, 5, 6, 2 },
            new double[] { 4, 7, 2, 4, 6 },
            new double[] { 2, 7, 8, 5, 9 }
        };

        var equations2 = new[]
        {
            new double[] { 5, 4, 3 },
            new double[] { 6, 2, 4 },
            new double[] { 4, 8, 5 }
        };
        
        var values = new double[] { 5, 7, 8, 4, 2 };
        MatrixPrinter(equations2);
        Array.ForEach(values, Console.WriteLine);
        
        GaussEliminationMethod.GaussTasks(equations2, values, 1);
     
        MatrixPrinter(equations2);
        Array.ForEach(values, Console.WriteLine);
    }

    private static void MatrixPrinter(double[][] matrix)
    {
        foreach (var row in matrix)
        {
            foreach (var item in row)
                Console.Write(item + " | ");
            Console.WriteLine("\n---------------------------------------------");
        }
        Console.WriteLine("\n -------------------- \n");
    }

    private static void MatrixPrinter(int[][] matrix)
    {
        foreach (var row in matrix)
        {
            foreach (var item in row)
                Console.Write(item + " ");
            Console.WriteLine();
        }
    }
    
    
    
    
    
    
    
    
    
    
    
    
    
    public static async Task Testing(string[] args)
    {
        Console.WriteLine("Execution started");
        Console.WriteLine("Message before starting async method");
        Method1();
        Console.WriteLine("Execution of Main() finished");
        await Task.Delay(11500);
        Console.WriteLine("finished");
    }

    private static async Task Method1()
    {
        Console.WriteLine("Execution of async method started");
        Console.WriteLine("First Process (before await)");
        await Task.Run(async () =>
        {
            for (var i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
                await Task.Delay(100);
            }
            Console.WriteLine("hey");
        });
        Console.WriteLine("Second Process (after await)");
        Console.WriteLine("Third Process");
        Console.WriteLine("Execution of async method finished");
    }
}