namespace MultiThreading;

public static partial class GaussEliminationMethod
{
    public static void GaussParallelFor(double[][] matrix, double[] values, int threadCount)
    {
        var ColumnCount = matrix[0].Length;
        var rowCount = matrix.Length;

        Parallel.For(0, rowCount, new ParallelOptions { MaxDegreeOfParallelism = threadCount },
            j =>
            {
                var row = matrix[j];
                var factor = row[j];
                row[j] = 1;

                for (var i = j + 1; i < ColumnCount; i++)
                    row[i] = Math.Round(row[i] / factor, 2);
                values[j] /= factor;


                for (var i = j + 1; i < rowCount; i++)
                {
                    var nextRow = matrix[i];
                    var nextFactor = nextRow[j];
                    nextRow[j] = 0;

                    for (var e = j + 1; e < ColumnCount; e++)
                        nextRow[e] = Math.Round(nextRow[e] - row[e] * nextFactor, 2);
                    values[i] -= values[j] * nextFactor;
                }
            });


        for (var i = rowCount - 1; i >= 0; i--)
        {
            var row = matrix[i];
            var value = values[i];

            for (var e = i + 1; e < rowCount; e++)
                value -= row[e] * values[e];
            values[i] = Math.Round(value / row[i], 2);
        }
    }
}