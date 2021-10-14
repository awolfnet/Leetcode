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
                        int top = 0;
                        if (i == 0)    //first row, top boundary
                        {
                            top = 1;
                        }
                        else
                        {
                            top = Perimeter(grid[i - 1][j]);
                        }
                        total += top;

                        int bottom = 0;
                        if (i + 1 >= row)    //last row, bottom boundary
                        {
                            bottom = 1;
                        }
                        else
                        {
                            bottom = Perimeter(grid[i + 1][j]);
                        }
                        total += bottom;

                        int left = 0;
                        if (j == 0)    //most left, left boundary
                        {
                            left = 1;
                        }
                        else
                        {
                            left = Perimeter(grid[i][j - 1]);
                        }
                        total += left;

                        int right = 0;
                        if (j + 1 >= col)
                        {
                            right = 1;
                        }
                        else
                        {
                            right = Perimeter(grid[i][j + 1]);
                        }
                        total += right;

                    }

                }
            }
            return total;
        }

        static int Perimeter(int neighbor)
        {
            if (neighbor == 1)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}
