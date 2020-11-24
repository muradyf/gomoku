﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gomoku
{
    enum COLOR { WHITE, RED, BLUE };
    class Cell : Button
    {
        public COLOR Occupier;

        public Cell(int H, int W)
        {
            this.Height = H;
            this.Width = W;
            Occupier = COLOR.WHITE;
        }
    }
}
