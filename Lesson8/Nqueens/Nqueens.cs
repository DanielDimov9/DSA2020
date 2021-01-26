using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson8.Nqueens
{
    public class NQueensSolver
    {
        private readonly List<int[]> _solutions = new List<int[]>();
        private readonly int[] _current;
        public int N { get; private set; }

        public NQueensSolver(int n)
        {
            N = n;
            _current = new int[N];
        }

        public IList<int[]> FindAllFormations()
        {
            PlaceQueen(0);
            return _solutions;
        }

        public void DisplaySolution()
        {
            foreach (var solution in _solutions)
            {
                foreach (var item in solution)
                {
                    Console.Write($"{item,3}");
                }
                Console.WriteLine();
            }
        }

        private void PlaceQueen(int row)
        {
            if (row == N)
            {
                _solutions.Add(_current.ToArray());
                return;
            }

            for (int col = 0; col <= N - 1; col++)
            {
                if (IsPositionSafe(row, col))
                {
                    _current[row] = col;
                    PlaceQueen(row + 1);
                }
            }
        }

        private bool IsPositionSafe(int row, int col)
        {
            for (int i = 0; i <= row - 1; i++)
            {
                if (_current[i] == col || row - i == Math.Abs(col - _current[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
