using Lesson8.Labirinth;
using System;

namespace Lesson8
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region Print Figure

            // PrintFigure(6);

            #endregion Print Figure

            #region Factoriel

            //int N = 50;
            //Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();
            //long factorielResult = FactorielCalc.Factoriel.RecursiveFactoriel(N);
            //Console.WriteLine($"Factoriel of {N} is {factorielResult} time={stopwatch.ElapsedMilliseconds}");
            //stopwatch.Restart();
            //factorielResult = FactorielCalc.Factoriel.IterativeFactoriel(N);
            //Console.WriteLine($"Factoriel of {N} is {factorielResult} time={stopwatch.ElapsedMilliseconds}");

            #endregion Factoriel

            #region NQueens

            //NQueensSolver nQueensSolver = new NQueensSolver(8);
            //nQueensSolver.FindAllFormations();
            //nQueensSolver.DisplaySolution();

            #endregion NQueens

            #region Labirinth

            // LabirinthPath.FindExit(0, 0);
            LabirinthPath.FindPathToExit(0, 0, 'R');

            #endregion Labirinth
        }

        private static void PrintFigure(int n)
        {
            if (n == 0) // Bottom of the recursion
                return;

            // Pre-action: print n asterisks
            Console.WriteLine(new string('*', n));

            // Recursive call: print figure of size n-1
            PrintFigure(n - 1);

            // Post-action: print n hashtags
            Console.WriteLine(new string('#', n));
        }
    }
}
