using Multu_Threading;

namespace MatrixTests;

public class Tests
{
    private int[][][] Matrices;
    [SetUp]
    public void Setup()
    {
        Matrices = new int[10][][];

        for (var i = 0; i < 10; i++)
            Matrices[i] = MultiThreading.MatrixGenerator.GenerateRandomIntegerMatrix((i + 1) * 5, 1000);
    }

    [Test]
    public void Test1()
    {
        foreach (var i in Matrices)
        {
            var matrixMax = new MatrixMax(i);
            Assert.That(matrixMax.FindMaxAmongMins(), Is.EqualTo(matrixMax.FindMaxAmongMinsParallel()));
        }
    }
}