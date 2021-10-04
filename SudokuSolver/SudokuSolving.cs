using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver
{
    public static class SudokuSolving
    {
        public static bool Solve(List<List<BoxControl>> grid)
        {
            return false;
        }

        public static bool IsGridValid(List<List<BoxControl>> grid)
        {
            bool rows = CheckRowsCols(grid, true);
            bool cols = CheckRowsCols(grid, false);

            return rows & cols;
        }

        private static bool CheckRowsCols(List<List<BoxControl>> grid, bool checkRows)
        {
            int size = grid.Count;

            for (var y = 0; y < size; y++)
            {
                int expectedSum = 0;
                int currentSum = 0;

                for (var x = 0; x < grid[0].Count; x++)
                {
                    expectedSum += x + 1;
                    if (checkRows)
                    {
                        currentSum += grid[y][x].GetValue();
                    }
                    else
                    {
                        currentSum += grid[x][y].GetValue();
                    }
                    

                }
                if(expectedSum != currentSum)
                {
                    return false;
                }
            }

            return true;
        }
        
    }
}
