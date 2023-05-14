namespace Multu_Threading;

public class MatrixMax
{
    public int[][] Matrix { get; }
    public int Max = int.MinValue;
    public int ThreadsCount { get; }

    public MatrixMax(int[][] matrix)
    {
        Matrix = matrix;
        ThreadsCount = matrix.Length;
    }

    public int FindMaxAmongMins()
    {
        var minimums = new int[Matrix.Length];
        for (var i = 0; i < Matrix.Length; i++)
        {
            var min = int.MaxValue;

            for (var e = 0; e < Matrix[i].Length; e++)
                if (Matrix[i][e] < min)
                    min = Matrix[i][e];
            minimums[i] = min;
        }
        
        var max = 0;
        foreach (var number in minimums)
            if (number > max)
                max = number;

        return max;
    }
    
    public int FindMaxAmongMinsParallel()
    {
        var minimums = new int[Matrix.Length];

        Parallel.For(0, Matrix.Length, i =>
        {
            var row = Matrix[i];
            var min = int.MaxValue;
            foreach (var number in row)
                if (number < min)
                    min = number;

            minimums[i] = min;
        });
        foreach (var number in minimums)
            if (number > Max)
                Max = number;
        
        return Max;
    }
}