using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MazeGenerator
{
    public class Generation
    {
        public static void BinaryTree(Maze maze)
        {
            Random random = new Random();
            MazeCell currentCell;
            MazeCell nextCell;

            for (int row = 0; row < maze.Rows; row++)
            {
                for (int col = 0; col < maze.Cols; col++)
                {
                    // Solution in which going down and right always solves
                    // Introduces visual bug as algorithm is one step ahead

                    
                    currentCell = maze.GetCell(row, col);
                    // 50/50 chance it either goes down or right
                    if (random.Next(2) == 0)
                        nextCell = maze.GetCell(row + 1, col);
                    else
                        nextCell = maze.GetCell(row, col + 1);

                    // makes last row and column linked
                    if (row == maze.Rows - 1 && col == maze.Cols - 1)
                        nextCell = maze.GetCell(row, col);
                    else if (row == maze.Rows - 1)
                        nextCell = maze.GetCell(row, col + 1);
                    else if (col == maze.Cols - 1)
                        nextCell = maze.GetCell(row + 1, col);
                    currentCell.Link(nextCell, true);
                    


                    // Solution in which going down and right does not solve
                    // Introduces visual bug as algorithm is one step behind

                    /*
                    currentCell = maze.GetCell(row, col);
                    // 50/50 chance it either goes up or left
                    if (random.Next(2) == 0)
                        nextCell = maze.GetCell(row - 1, col);
                    else
                        nextCell = maze.GetCell(row, col - 1);

                    // makes first row and column linked
                    if (row == 0 && col == 0)
                        nextCell = maze.GetCell(row, col);

                    else if (row == 0)
                        nextCell = maze.GetCell(row, col - 1);
                    else if (col == 0)
                        nextCell = maze.GetCell(row - 1, col);
                    currentCell.Link(nextCell, true);
                    */
                }
            }
        }

        public static void IterativeBacktracking(Maze maze)
        {
            MazeCell currentCell = maze.GetCell(0, 0);
            MazeCell nextCell;
            Stack IBStack = new Stack();

            bool visited = false;

            currentCell.Visited = true;
            IBStack.Push(currentCell);
            while (!IBStack.IsEmpty())
            {
                visited = true;

                currentCell = IBStack.Peek();
                IBStack.Pop();

                foreach (MazeCell neighbour in currentCell.Neighbours()) 
                {
                    if (neighbour.Visited == false)
                    {
                        visited = false;
                    }
                }

                if (visited == false)
                {
                    IBStack.Push(currentCell);

                    nextCell = currentCell.UnvisitedNeighbour();
                    currentCell.Link(nextCell, true);
                    nextCell.Visited = true;
                    IBStack.Push(nextCell);
                }
            }
        }
    }
}