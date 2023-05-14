namespace MultiThreading;

public static partial class GaussEliminationMethod
{
    public static void GaussTasks(double[][] matrix, double[] values, int threadCount)
    {
        var columnCount = matrix[0].Length;
        var rowCount = matrix.Length;
        var tasks = new Task[threadCount];
        var range = rowCount / threadCount;

        for (var i = 0; i < threadCount; i++)
        {
            var start = i * range;
            var end = (i + 1) * range;
            
            tasks[i] = Task.Run(() => {
                for (var e = start; e < end; e++)
                {
                    var row = matrix[e];
                    var factor = row[e];
                    row[e] = 1;

                    for (var j = e + 1; j < columnCount; j++)
                        row[j] = Math.Round(row[j] / factor, 2);
                    values[e] /= factor;

                    for (var j = e + 1; e < rowCount; e++)
                    {
                        var nextRow = matrix[j];
                        var nextFactor = nextRow[e];
                        nextRow[e] = 0;

                        for (var y = e + 1; y < columnCount; y++)
                            nextRow[y] = Math.Round(nextRow[y] - row[y] * nextFactor, 2);
                        values[j] -= values[e] * nextFactor;
                    }
                }
            });
        }
        Task.WaitAll(tasks);

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