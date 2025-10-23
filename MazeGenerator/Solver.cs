using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGenerator
{
    internal class Solver
    {
        public static List<MazeCell> DepthFirstSearch(Maze maze)
        {
            List<MazeCell> path = new List<MazeCell>();

            MazeCell currentCell = maze.GetCell(0, 0);
            MazeCell nextCell;
            Stack DFSStack = new Stack();    

            bool visited;

            currentCell.Visited = true;
            DFSStack.Push(currentCell);

            for (int i = 0; i < maze.Rows; i++)
            {
                for (int j = 0; j < maze.Cols; j++)
                {
                    maze.GetCell(i,j).Visited = false;
                }
            }

            while (!DFSStack.IsEmpty())
            {
                visited = true;

                currentCell = DFSStack.Peek();
                DFSStack.Pop();

                if (currentCell == maze.End)
                    break;

                //checks if cell is linked, not just to specified cell
                foreach (MazeCell neighbour in currentCell.Neighbours())
                {
                    if (neighbour.Visited == false && neighbour.isLinked(currentCell))
                        visited = false;
                }

                if (visited == false)
                {
                    DFSStack.Push(currentCell);

                    nextCell = currentCell.UnvisitedNeighbour();

                    nextCell.Visited = true;
                    DFSStack.Push(nextCell);
                }
            }

            while (!DFSStack.IsEmpty())
            {
                path.Add(currentCell);
                currentCell = DFSStack.Peek();
                DFSStack.Pop();
            }

            return path;
        }
    }
}
