namespace MultiThreading;

public static class MatrixGenerator
{
    public static double[][] GenerateRandomMatrix(int size)
    {
        var matrix = new double[size][];
        var random = new Random();

        for (var i = 0; i < size; i++)
        {
            matrix[i] = new double[size];
            for (var e = 0; e < size; e++)
                matrix[i][e] = random.NextDouble();
        }

        return matrix;
    }

    public static int[][] GenerateRandomIntegerMatrix(int size, int maxValue)
    {
        var matrix = new int[size][];
        var random = new Random();

        for (var i = 0; i < size; i++)
        {
            matrix[i] = new int[size];
            for (var e = 0; e < size; e++)
                matrix[i][e] = random.Next(maxValue + 1);
        }

        return matrix;
    }
    
    public static double[] GenerateRandomVector(int size)
    {
        var vector = new double[size];
        var random = new Random();
        
        for (var i = 0; i < size; i++)
            vector[i] = random.NextDouble();

        return vector;
    }
}