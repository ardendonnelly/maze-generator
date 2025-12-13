namespace MazeGenerator
{
    public class Maze
    {
        public int Rows { get; private set; }
        public int Cols { get; private set; }
        public MazeCell Start { get; set; }
        public MazeCell End { get; set; }

        private MazeCell[,] grid;

        // Constructor: creates the maze with the given number of rows and columns
        public Maze(int rows, int cols)
        {
            Rows = rows;
            Cols = cols;
            grid = new MazeCell[rows, cols];
            // Set default start and end cells
            Start = grid[0, 0]; // Top-left corner
            End = grid[rows - 1, cols - 1]; // Bottom-right corner
            Random random = new Random();

            PrepareGrid();       // Create all the cells
            ConfigureCells();    // Set up neighbors for each cell
        }

        // Step 1: Create a MazeCell object for each position in the grid
        private void PrepareGrid()
        {
            for (int row = 0; row < Rows; row++)
            {
                for (int col = 0; col < Cols; col++)
                {
                    grid[row, col] = new MazeCell(row, col, false);
                }
            }
        }

        // Step 2: Assign neighbors (Up, Down, Left, Right) for each cell
        private void ConfigureCells()
        {
            for (int row = 0; row < Rows; row++)
            {
                for (int col = 0; col < Cols; col++)
                {
                    MazeCell cell = grid[row, col];

                    // Set the Up neighbor if not on the top row
                    if (row > 0)
                    {
                        cell.Up = grid[row - 1, col];
                    }
                    else
                    {
                        cell.Up = null;
                    }

                    // Set the Down neighbor if not on the bottom row
                    if (row < Rows - 1)
                    {
                        cell.Down = grid[row + 1, col];
                    }
                    else
                    {
                        cell.Down = null;
                    }

                    // Set the Left neighbor if not on the first column
                    if (col > 0)
                    {
                        cell.Left = grid[row, col - 1];
                    }
                    else
                    {
                        cell.Left = null;
                    }

                    // Set the Right neighbor if not on the last column
                    if (col < Cols - 1)
                    {
                        cell.Right = grid[row, col + 1];
                    }
                    else
                    {
                        cell.Right = null;
                    }
                }
            }
        }

        // Returns a specific cell from the grid, or null if the position is invalid
        public MazeCell GetCell(int row, int col)
        {
            if (row < 0 || row >= Rows || col < 0 || col >= Cols)
            {
                return null;
            }

            return grid[row, col];
        }

        // Returns the entire grid of cells
        public MazeCell[,] GetGrid()
        {
            return grid;
        }
    }
}