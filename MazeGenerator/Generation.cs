using System;
using System.CodeDom.Compiler;
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

        public static void Kruskals(Maze maze)
        {
            Random random = new Random();
            MazeCell currentCell = maze.GetCell(0, 0);
            MazeCell nextCell = maze.GetCell(0, 0);

            var walls = new List<(MazeCell, MazeCell)> { };



            // create list of walls
            for (int row = 0; row < maze.Rows; row++)
            {
                for (int col = 0; col < maze.Cols; col++)
                {
                    currentCell = maze.GetCell(row, col);

                    //if (currentCell.Up != null && !walls.Any(m => m.Item1 == currentCell.Up))
                    //    walls.Add((currentCell, currentCell.Up));

                    // checking if at edges of maze
                    // don't need to check all cells, down and right affects all walls
                    if (currentCell.Right != null)
                        walls.Add((currentCell, currentCell.Right));
                    if (currentCell.Down != null)
                        walls.Add((currentCell, currentCell.Down));
                }
            }


            // randomize list order
            // Modern version of Fischer and Yate's method
            int randNumb = random.Next(walls.Count);
            for (int i = 1; i < walls.Count - 1; i++)
            {
                randNumb = random.Next(i + 1);
                var temp = walls[randNumb];
                walls[randNumb] = walls[i];
                walls[i] = temp;
            }



            // link cells from wall list
            foreach (var wall in walls)
            {
                currentCell = wall.Item1;
                nextCell = wall.Item2;

                if (!currentCell.cellSetContains(nextCell))
                {
                    currentCell.Link(nextCell);
                    //currentCell.CellSet.UnionWith(nextCell.CellSet);
                    currentCell.MergeCellSet(nextCell);
                }
            }
        }
    }
}