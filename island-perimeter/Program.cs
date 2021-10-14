using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace island_perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[,] grid= new int[4,4] { { 0, 1, 0, 0 }, { 1, 1, 1, 0 }, { 0, 1, 0, 0 }, { 1, 1, 0, 0 } };

            int[][] grid = new int[4][];

            grid[0] = new int[4] { 0, 1, 0, 0 };
            grid[1] = new int[4] { 1, 1, 1, 0 };
            grid[2] = new int[4] { 0, 1, 0, 0 };
            grid[3] = new int[4] { 1, 1, 0, 0 };

            Console.WriteLine(IslandPerimeter(grid));
            Console.ReadKey();
        }

        static int IslandPerimeter(int[][] grid)
        {
            int total = 0;

            int row = grid.Length;
            for (int i = 0; i < row; i++)
            {
                int col = grid[i].Length;
                for (int j = 0; j < col; j++)
                {
                    int v = grid[i][j];
                    if (v == 1)
                    {
                        int top = Perimeter(grid, i - 1, j, i == 0);
                        total += top;

                        int bottom = Perimeter(grid, i + 1, j, i + 1 >= row);
                        total += bottom;

                        int left = Perimeter(grid, i, j - 1, j == 0);
                        total += left;

                        int right = Perimeter(grid, i, j + 1, j + 1 >= col);
                        total += right;

                    }

                }
            }
            return total;
        }

        /// <summary>
        /// Calc cell perimeter 
        /// </summary>
        /// <param name="grid">grid</param>
        /// <param name="row">neighbor cell row</param>
        /// <param name="col">neighbor cell col</param>
        /// <param name="boundary">boundar condition</param>
        /// <returns></returns>
        static int Perimeter(int[][] grid, int row, int col, bool boundary)
        {
            if (boundary)
            {
                return 1;
            }
            else if (grid[row][col] == 0)  //if neighbor is water
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
