using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson8.Labirinth
{
    public static class LabirinthPath
    {
        private static char[,] lab =
        {
            {' ', ' ', ' ', '*', ' ', ' ', ' '},
            {'*', '*', ' ', '*', ' ', '*', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', ' '},
            {' ', '*', '*', '*', '*', '*', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', 'е'},
        };

        private static List<char> path = new List<char>();

        public static void FindExit(int row, int col)
        {
            if ((col < 0) || (row < 0) || (col >= lab.GetLength(1)) || (row >= lab.GetLength(0)))
            {
                // We are out of the labyrinth -> can't find a path
                return;
            }

            // Check if we have found the exit
            if (lab[row, col] == 'е')
            {
                Console.WriteLine("Found the exit!");
            }

            if (lab[row, col] != ' ')
            {
                // The current cell is not free -> can't find a path
                return;
            }

            // Temporaryly mark the current cell as visited
            lab[row, col] = 's';

            // Invoke recursion to explore all possible directions
            FindExit(row, col - 1); // left
            FindExit(row - 1, col); // up
            FindExit(row, col + 1); // right
            FindExit(row + 1, col); // down

            // Mark back the current cell as free
            lab[row, col] = ' ';
        }

        public static void FindPathToExit(int row, int col, char direction)
        {
            if ((col < 0) || (row < 0) || (col >= lab.GetLength(1)) || (row >= lab.GetLength(0)))
            {
                // We are out of the labyrinth -> can't find a path
                return;
            }

            path.Add(direction);

            // Check if we have found the exit
            if (lab[row, col] == 'е')
            {
                Console.Write("To find the exit follow the instructions (or the white rabbit): ");
                foreach (var item in path)
                {
                    Console.Write($"{item,2}");
                }
                Console.WriteLine();
            }

            if (lab[row, col] != ' ')
            {
                // The current cell is not free -> can't find a path
                return;
            }

            // Temporaryly mark the current cell as visited
            lab[row, col] = 's';

            // Invoke recursion to explore all possible directions
            FindPathToExit(row, col - 1, 'L'); // left
            FindPathToExit(row - 1, col, 'U'); // up
            FindPathToExit(row, col + 1, 'R'); // right
            FindPathToExit(row + 1, col, 'D'); // down

            // Mark back the current cell as free
            lab[row, col] = ' ';

            // Remove the last direction from the path
            path.RemoveAt(path.Count - 1);
        }
    }
}
