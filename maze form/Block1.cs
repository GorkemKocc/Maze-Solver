using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maze_form
{
    internal class Block1 : Cell
    {
        public Block1()
        {
            main = false;
        }

        public Block1(int row, int col) : base(row, col)
        {
            Wall = true;
            Button.BackColor = Color.Black;
        }
    }
}
