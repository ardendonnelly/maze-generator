using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Windows.Forms;

namespace MazeGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Maze maze = new Maze(10, 10);
            int cellSize = 60;

            if (CBGenerationAlg.SelectedItem == null)
                CBGenerationAlg.SelectedIndex = 0;

            object selectedItem = CBGenerationAlg.SelectedItem;

            if (selectedItem.ToString() == "Easy")
            {
                Generation.BinaryTree(maze);
            }
            else if (selectedItem.ToString() == "Medium")
            {
                maze = new Maze(15, 15);
                cellSize = 40;
                Generation.IterativeBacktracking(maze);
            }
            else if (selectedItem.ToString() == "Hard")
            {
                maze = new Maze(20, 20);
                cellSize = 30;
                Generation.IterativeBacktracking(maze);
            }

            maze.Start = maze.GetCell(0, 0);
            maze.End = maze.GetCell(maze.Rows - 1, maze.Cols - 1);

            pictureBox2.Image = DrawMaze(maze, cellSize); // cell size is 40 for 10x10, 20 for 20x20
        }

        public Bitmap DrawMaze(Maze maze, int cellSize)
        {
            int width = maze.Cols * cellSize + 1;
            int height = maze.Rows * cellSize + 1;

            Bitmap bmp = new Bitmap(width, height);

            List<MazeCell> path = new List<MazeCell>();

            // Substitute for event handler

            if (CHPathShown.Checked)
                path = Solver.DepthFirstSearch(maze);


            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);
                Pen wallPen = Pens.Black;
                Pen pathPen = Pens.LightBlue;

                Font font = new Font("Arial", 8);
                StringFormat format = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };

                for (int row = 0; row < maze.Rows; row++)
                {
                    for (int col = 0; col < maze.Cols; col++)
                    {
                        MazeCell cell = maze.GetCell(row, col);
                        int x = col * cellSize;
                        int y = row * cellSize;


                        // Draw path down
                        if (cell.isLinked(cell.Down) && path.Contains(cell) && path.Contains(cell.Down))
                            g.DrawLine(pathPen, x + cellSize / 2, y + cellSize / 2, x + cellSize / 2, y + cellSize);

                        // Draw path right
                        if (cell.isLinked(cell.Right) && path.Contains(cell) && path.Contains(cell.Right))
                            g.DrawLine(pathPen, x + cellSize / 2, y + cellSize / 2, x + cellSize, y + cellSize / 2);

                        // Draw path left
                        if (cell.isLinked(cell.Left) && path.Contains(cell) && path.Contains(cell.Left))
                            g.DrawLine(pathPen, x, y + cellSize / 2, x + cellSize / 2, y + cellSize / 2);

                        // Draw path up
                        if (cell.isLinked(cell.Up) && path.Contains(cell) && path.Contains(cell.Up))
                            g.DrawLine(pathPen, x + cellSize / 2, y + cellSize / 2, x + cellSize / 2, y);


                        // Draw start and end
                        if (cell == maze.Start)
                            g.FillRectangle(Brushes.LimeGreen, x + cellSize / 8, y + cellSize / 8, cellSize - cellSize / 4, cellSize - cellSize / 4);

                        else if (cell == maze.End)
                            g.FillRectangle(Brushes.Red, x + cellSize / 8, y + cellSize / 8, cellSize - cellSize / 4, cellSize - cellSize / 4);


                        // Draw top wall
                        if (cell.Up == null || !cell.isLinked(cell.Up)) // checking if cell is outside maze or a wall
                            g.DrawLine(wallPen, x, y, x + cellSize, y); // top left is (x,y), top right is (x+cellSize, y)

                        // Draw left wall
                        if (cell.Left == null || !cell.isLinked(cell.Left))
                            g.DrawLine(wallPen, x, y, x, y + cellSize);

                        // Draw right wall
                        if (cell.Right == null || !cell.isLinked(cell.Right))
                            g.DrawLine(wallPen, x + cellSize, y, x + cellSize, y + cellSize);

                        // Draw bottom wall
                        if (cell.Down == null || !cell.isLinked(cell.Down))
                            g.DrawLine(wallPen, x, y + cellSize, x + cellSize, y + cellSize);
                    }
                }
            }
            return bmp;
        }
        /*
        private void CHPathShown_CheckedChanged(object sender, EventArgs e, Maze maze, List<MazeCell> path)
        {
            if (CHPathShown.Checked)
            {
                path = Solver.DepthFirstSearch(maze);
            }
        }
        */
    }
}
