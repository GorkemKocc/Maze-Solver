﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using maze_form;

namespace WinFormsApp3
{
    internal class Wall : Cell
    {
        public Wall()
        {
            Button.Text = "";
            Button.BackColor = Color.Black;
            Wall = true;
        }
    }
}
