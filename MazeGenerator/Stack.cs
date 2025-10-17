using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MazeGenerator
{
    public  class Stack
    {
        // Iterative Backtrack Stack
        MazeCell[] StackArray = new MazeCell[0];
        public int topPointer;

        public Stack()
        {
            StackArray = new MazeCell[1000];
            topPointer = -1;
        }

        public void Push(MazeCell cell)
        {
            topPointer += 1;
            StackArray[topPointer] = cell;
        }
        public void Pop()
        {
            StackArray[topPointer] = null;
            topPointer -= 1;
        }
        public MazeCell Peek()
        {
            return StackArray[topPointer];
        }
        public bool IsEmpty()
        {
            if (topPointer == -1)
                return true;
            else
                return false;
        }
    }
}
