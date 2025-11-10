using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGenerator
{
    public class MazeCell
    {
        // properties
        public int Row { get; set; }
        public int Col { get; set; }
        public MazeCell Up { get; set; } // UP is a pointer to the MazeCell above
        public MazeCell Down { get; set; }
        public MazeCell Left { get; set; }
        public MazeCell Right { get; set; }
        public bool Visited { get; set; }


        // This HashSet stores references to other MazeCell objects that are linked to the current cell
        // meaning there is a passage between them (i.e., no wall).
        private HashSet<MazeCell> links = new HashSet<MazeCell>();

        private HashSet<MazeCell> connected = new HashSet<MazeCell>();

        // constructor
        public MazeCell(int row, int col, bool visited)
        {
            Row = row;
            Col = col;
            Up = null;
            Down = null;
            Left = null;
            Right = null;
            links = new HashSet<MazeCell>();
            connected = new HashSet<MazeCell>();
            Visited = visited;
        }

        public void Link(MazeCell cell, bool bidirectional = true)
        {
            links.Add(cell); // adds the specified cell to the links HashSet

            if (bidirectional)
            {
                cell.Link(this, false); // if bidirectional is true, it also links the specified cell
                                        // back to the current cell. It passes false to avoid infinite recursion.
            }
        }
        public bool isLinked(MazeCell cell)
        {
            return links.Contains(cell); // checks if the specified cell is in the links HashSet
        }

        public IEnumerable<MazeCell> Links // property to access the linked cells
        {
            get
            {
                return links;
            }
        }

        public List<MazeCell> Neighbours()
        // It returns only the valid neighbors — meaning it skips any direction that
        // doesn’t exist (e.g., if the cell is on the edge of the maze,
        // it won’t have an Up or Left neighbor).

        {
            List<MazeCell> neighbours = new List<MazeCell>();

            if (Up != null)
                neighbours.Add(Up);

            if (Down != null)
                neighbours.Add(Down);

            if (Left != null)
                neighbours.Add(Left);

            if (Right != null)
                neighbours.Add(Right);

            return neighbours;
        }

        public MazeCell UnvisitedNeighbour()
        {
            Random random = new Random();
            List<MazeCell> neighbours = new List<MazeCell>();

            if (Up != null && Up.Visited == false)
                neighbours.Add(Up);

            if (Down != null && Down.Visited == false)
                neighbours.Add(Down);

            if (Left != null && Left.Visited == false)
                neighbours.Add(Left);

            if (Right != null && Right.Visited == false)
                neighbours.Add(Right);

            int randNumb = random.Next(neighbours.Count);
            return neighbours[randNumb];
        }

        public MazeCell LinkedNeighbour(MazeCell currentCell)
        {
            Random random = new Random();
            List<MazeCell> neighbours = new List<MazeCell>();

            if (Up != null && Up.Visited == false && Up.isLinked(currentCell))
                neighbours.Add(Up);

            if (Down != null && Down.Visited == false && Down.isLinked(currentCell))
                neighbours.Add(Down);

            if (Left != null && Left.Visited == false && Left.isLinked(currentCell))
                neighbours.Add(Left);

            if (Right != null && Right.Visited == false && Right.isLinked(currentCell))
                neighbours.Add(Right);

            int randNumb = random.Next(neighbours.Count);
            return neighbours[randNumb];
        }
    }
}
