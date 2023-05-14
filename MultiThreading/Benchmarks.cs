// using System.Numerics;
// using System.Text;
// using BenchmarkDotNet.Attributes;
// using MultiThreading;
//
// namespace Multu_Threading;
//
// [MemoryDiagnoser]
// public class BenchmarksParallelFor
// {
//     private int[] Sizes;
//     private int[] ThreadsCount;
//     private (double[][], double[])[] Systems;
//     
//     [GlobalSetup]
//     public void GlobalSetup()
//     {
//         Sizes = new[] { 10, 100, 1000 };
//         ThreadsCount = new[] { 1, 2, 4, 8, 16 };
//         Systems = new (double[][], double[])[Sizes.Length * ThreadsCount.Length];
//
//         for (var i = 0; i < ThreadsCount.Length; i++)
//             Systems[i] = (MatrixGenerator.GenerateRandomMatrix(Sizes[0]), 
//                 MatrixGenerator.GenerateRandomVector(Sizes[0]));
//         
//         for (var i = ThreadsCount.Length; i < ThreadsCount.Length * 2; i++)
//             Systems[i] = (MatrixGenerator.GenerateRandomMatrix(Sizes[1]), 
//                 MatrixGenerator.GenerateRandomVector(Sizes[1]));
//         
//         for (var i = ThreadsCount.Length * 2; i < ThreadsCount.Length * 3; i++)
//             Systems[i] = (MatrixGenerator.GenerateRandomMatrix(Sizes[2]), 
//                 MatrixGenerator.GenerateRandomVector(Sizes[2]));
//     }
//
//    [Benchmark]
//     public void ParallelFor_Size10_Threads1()
//     {
//         GaussEliminationMethod.GaussParallelFor(Systems[0].Item1, Systems[0].Item2, ThreadsCount[0]);
//     }
//     
//    [Benchmark]
//     public void ParallelFor_Size10_Threads2()
//     {
//         GaussEliminationMethod.GaussParallelFor(Systems[1].Item1, Systems[1].Item2, ThreadsCount[1]);
//     }
//     
//    [Benchmark]
//     public void ParallelFor_Size10_Threads4()
//     {
//         GaussEliminationMethod.GaussParallelFor(Systems[2].Item1, Systems[2].Item2, ThreadsCount[2]);
//     }
//     
//    [Benchmark]
//     public void ParallelFor_Size10_Threads8()
//     {
//         GaussEliminationMethod.GaussParallelFor(Systems[3].Item1, Systems[3].Item2, ThreadsCount[3]);
//     }
//     
//    [Benchmark]
//     public void ParallelFor_Size10_Threads16()
//     {
//         GaussEliminationMethod.GaussParallelFor(Systems[4].Item1, Systems[4].Item2, ThreadsCount[4]);
//     }
//     
//    [Benchmark]
//     public void ParallelFor_Size100_Threads1()
//     {
//         GaussEliminationMethod.GaussParallelFor(Systems[5].Item1, Systems[5].Item2, ThreadsCount[0]);
//     }
//     
//    [Benchmark]
//     public void ParallelFor_Size100_Threads2()
//     {
//         GaussEliminationMethod.GaussParallelFor(Systems[6].Item1, Systems[6].Item2, ThreadsCount[1]);
//     }
//     
//    [Benchmark]
//     public void ParallelFor_Size100_Threads4()
//     {
//         GaussEliminationMethod.GaussParallelFor(Systems[7].Item1, Systems[7].Item2, ThreadsCount[2]);
//     }
//     
//    [Benchmark]
//     public void ParallelFor_Size100_Threads8()
//     {
//         GaussEliminationMethod.GaussParallelFor(Systems[8].Item1, Systems[8].Item2, ThreadsCount[3]);
//     }
//     
//    [Benchmark]
//     public void ParallelFor_Size100_Threads16()
//     {
//         GaussEliminationMethod.GaussParallelFor(Systems[9].Item1, Systems[9].Item2, ThreadsCount[4]);
//     }
//     
//    [Benchmark]
//     public void ParallelFor_Size1000_Threads1()
//     {
//         GaussEliminationMethod.GaussParallelFor(Systems[10].Item1, Systems[10].Item2, ThreadsCount[0]);
//     }
//     
//    [Benchmark]
//     public void ParallelFor_Size1000_Threads2()
//     {
//         GaussEliminationMethod.GaussParallelFor(Systems[11].Item1, Systems[11].Item2, ThreadsCount[1]);
//     }
//     
//    [Benchmark]
//     public void ParallelFor_Size1000_Threads4()
//     {
//         GaussEliminationMethod.GaussParallelFor(Systems[12].Item1, Systems[12].Item2, ThreadsCount[2]);
//     }
//     
//    [Benchmark]
//     public void ParallelFor_Size1000_Threads8()
//     {
//         GaussEliminationMethod.GaussParallelFor(Systems[13].Item1, Systems[13].Item2, ThreadsCount[3]);
//     }
//     
//    [Benchmark]
//     public void ParallelFor_Size1000_Threads16()
//     {
//         GaussEliminationMethod.GaussParallelFor(Systems[14].Item1, Systems[14].Item2, ThreadsCount[4]);
//     }
// }
//
// [MemoryDiagnoser]
// public class BenchmarksTasks
// {
//     private int[] Sizes;
//     private int[] ThreadsCount;
//     private (double[][], double[])[] Systems;
//     
//     [GlobalSetup]
//     public void GlobalSetup()
//     {
//         Sizes = new[] { 10, 100, 1000 };
//         ThreadsCount = new[] { 1, 2, 4, 8, 16 };
//         Systems = new (double[][], double[])[Sizes.Length * ThreadsCount.Length];
//
//         for (var i = 0; i < ThreadsCount.Length; i++)
//             Systems[i] = (MatrixGenerator.GenerateRandomMatrix(Sizes[0]), 
//                     MatrixGenerator.GenerateRandomVector(Sizes[0]));
//         
//         for (var i = ThreadsCount.Length; i < ThreadsCount.Length * 2; i++)
//             Systems[i] = (MatrixGenerator.GenerateRandomMatrix(Sizes[1]), 
//                     MatrixGenerator.GenerateRandomVector(Sizes[1]));
//         
//         for (var i = ThreadsCount.Length * 2; i < ThreadsCount.Length * 3; i++)
//             Systems[i] = (MatrixGenerator.GenerateRandomMatrix(Sizes[2]), 
//                 MatrixGenerator.GenerateRandomVector(Sizes[2]));
//     }
//
//    [Benchmark]
//     public void Tasks_Size10_Threads1()
//     {
//         GaussEliminationMethod.GaussTasks(Systems[0].Item1, Systems[0].Item2, ThreadsCount[0]);
//     }
//     
//    [Benchmark]
//     public void Tasks_Size10_Threads2()
//     {
//         GaussEliminationMethod.GaussTasks(Systems[1].Item1, Systems[1].Item2, ThreadsCount[1]);
//     }
//     
//    [Benchmark]
//     public void Tasks_Size10_Threads4()
//     {
//         GaussEliminationMethod.GaussTasks(Systems[2].Item1, Systems[2].Item2, ThreadsCount[2]);
//     }
//     
//    [Benchmark]
//     public void Tasks_Size10_Threads8()
//     {
//         GaussEliminationMethod.GaussTasks(Systems[3].Item1, Systems[3].Item2, ThreadsCount[3]);
//     }
//     
//    [Benchmark]
//     public void Tasks_Size10_Threads16()
//     {
//         GaussEliminationMethod.GaussTasks(Systems[4].Item1, Systems[4].Item2, ThreadsCount[4]);
//     }
//     
//    [Benchmark]
//     public void Tasks_Size100_Threads1()
//     {
//         GaussEliminationMethod.GaussTasks(Systems[5].Item1, Systems[5].Item2, ThreadsCount[0]);
//     }
//     
//    [Benchmark]
//     public void Tasks_Size100_Threads2()
//     {
//         GaussEliminationMethod.GaussTasks(Systems[6].Item1, Systems[6].Item2, ThreadsCount[1]);
//     }
//     
//    [Benchmark]
//     public void Tasks_Size100_Threads4()
//     {
//         GaussEliminationMethod.GaussTasks(Systems[7].Item1, Systems[7].Item2, ThreadsCount[2]);
//     }
//     
//    [Benchmark]
//     public void Tasks_Size100_Threads8()
//     {
//         GaussEliminationMethod.GaussTasks(Systems[8].Item1, Systems[8].Item2, ThreadsCount[3]);
//     }
//     
//    [Benchmark]
//     public void Tasks_Size100_Threads16()
//     {
//         GaussEliminationMethod.GaussTasks(Systems[9].Item1, Systems[9].Item2, ThreadsCount[4]);
//     }
//     
//    [Benchmark]
//     public void Tasks_Size1000_Threads1()
//     {
//         GaussEliminationMethod.GaussTasks(Systems[10].Item1, Systems[10].Item2, ThreadsCount[0]);
//     }
//     
//    [Benchmark]
//     public void Tasks_Size1000_Threads2()
//     {
//         GaussEliminationMethod.GaussTasks(Systems[11].Item1, Systems[11].Item2, ThreadsCount[1]);
//     }
//     
//    [Benchmark]
//     public void Tasks_Size1000_Threads4()
//     {
//         GaussEliminationMethod.GaussTasks(Systems[12].Item1, Systems[12].Item2, ThreadsCount[2]);
//     }
//     
//    [Benchmark]
//     public void Tasks_Size1000_Threads8()
//     {
//         GaussEliminationMethod.GaussTasks(Systems[13].Item1, Systems[13].Item2, ThreadsCount[3]);
//     }
//     
//    [Benchmark]
//     public void Tasks_Size1000_Threads16()
//     {
//         GaussEliminationMethod.GaussTasks(Systems[14].Item1, Systems[14].Item2, ThreadsCount[4]);
//     }
// }
//
// [MemoryDiagnoser]
// public class BenchmarksThreads
// {
//     private int[] Sizes;
//     private int[] ThreadsCount;
//     private (double[][], double[])[] Systems;
//     
//     [GlobalSetup]
//     public void GlobalSetup()
//     {
//         Sizes = new[] { 10, 100, 1000 };
//         ThreadsCount = new[] { 1, 2, 4, 8, 16 };
//         Systems = new (double[][], double[])[Sizes.Length * ThreadsCount.Length];
//
//         for (var i = 0; i < ThreadsCount.Length; i++)
//             Systems[i] = (MatrixGenerator.GenerateRandomMatrix(Sizes[0]), 
//                     MatrixGenerator.GenerateRandomVector(Sizes[0]));
//         
//         for (var i = ThreadsCount.Length; i < ThreadsCount.Length * 2; i++)
//             Systems[i] = (MatrixGenerator.GenerateRandomMatrix(Sizes[1]), 
//                     MatrixGenerator.GenerateRandomVector(Sizes[1]));
//         
//         for (var i = ThreadsCount.Length * 2; i < ThreadsCount.Length * 3; i++)
//             Systems[i] = (MatrixGenerator.GenerateRandomMatrix(Sizes[2]), 
//                 MatrixGenerator.GenerateRandomVector(Sizes[2]));
//     }
//
//    [Benchmark]
//     public void Threads_Size10_Threads1()
//     {
//         GaussEliminationMethod.GaussThreads(Systems[0].Item1, Systems[0].Item2, ThreadsCount[0]);
//     }
//     
//    [Benchmark]
//     public void Threads_Size10_Threads2()
//     {
//         GaussEliminationMethod.GaussThreads(Systems[1].Item1, Systems[1].Item2, ThreadsCount[1]);
//     }
//     
//    [Benchmark]
//     public void Threads_Size10_Threads4()
//     {
//         GaussEliminationMethod.GaussThreads(Systems[2].Item1, Systems[2].Item2, ThreadsCount[2]);
//     }
//     
//    [Benchmark]
//     public void Threads_Size10_Threads8()
//     {
//         GaussEliminationMethod.GaussThreads(Systems[3].Item1, Systems[3].Item2, ThreadsCount[3]);
//     }
//     
//    [Benchmark]
//     public void Threads_Size10_Threads16()
//     {
//         GaussEliminationMethod.GaussThreads(Systems[4].Item1, Systems[4].Item2, ThreadsCount[4]);
//     }
//     
//    [Benchmark]
//     public void Threads_Size100_Threads1()
//     {
//         GaussEliminationMethod.GaussThreads(Systems[5].Item1, Systems[5].Item2, ThreadsCount[0]);
//     }
//     
//    [Benchmark]
//     public void Threads_Size100_Threads2()
//     {
//         GaussEliminationMethod.GaussThreads(Systems[6].Item1, Systems[6].Item2, ThreadsCount[1]);
//     }
//     
//    [Benchmark]
//     public void Threads_Size100_Threads4()
//     {
//         GaussEliminationMethod.GaussThreads(Systems[7].Item1, Systems[7].Item2, ThreadsCount[2]);
//     }
//     
//    [Benchmark]
//     public void Threads_Size100_Threads8()
//     {
//         GaussEliminationMethod.GaussThreads(Systems[8].Item1, Systems[8].Item2, ThreadsCount[3]);
//     }
//     
//    [Benchmark]
//     public void Threads_Size100_Threads16()
//     {
//         GaussEliminationMethod.GaussThreads(Systems[9].Item1, Systems[9].Item2, ThreadsCount[4]);
//     }
//     
//    [Benchmark]
//     public void Threads_Size1000_Threads1()
//     {
//         GaussEliminationMethod.GaussThreads(Systems[10].Item1, Systems[10].Item2, ThreadsCount[0]);
//     }
//     
//    [Benchmark]
//     public void Threads_Size1000_Threads2()
//     {
//         GaussEliminationMethod.GaussThreads(Systems[11].Item1, Systems[11].Item2, ThreadsCount[1]);
//     }
//     
//    [Benchmark]
//     public void Threads_Size1000_Threads4()
//     {
//         GaussEliminationMethod.GaussThreads(Systems[12].Item1, Systems[12].Item2, ThreadsCount[2]);
//     }
//     
//    [Benchmark]
//     public void Threads_Size1000_Threads8()
//     {
//         GaussEliminationMethod.GaussThreads(Systems[13].Item1, Systems[13].Item2, ThreadsCount[3]);
//     }
//     
//    [Benchmark]
//     public void Threads_Size1000_Threads16()
//     {
//         GaussEliminationMethod.GaussThreads(Systems[14].Item1, Systems[14].Item2, ThreadsCount[4]);
//     }
// }
