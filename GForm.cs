using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gomoku
{
    public partial class GForm : Form
    {
        int dim;
        Cell[,] Cs;
        int WC = 5;
        Cell cc;
        COLOR Turn = COLOR.RED;
        public GForm()
        {
            InitializeComponent();
        }

        void TURNCHANGE()
        {
            if(Turn == COLOR.RED)
            {
                Turn = COLOR.BLUE;
            }
            else
            {
                Turn = COLOR.RED;
            }
        }

        private void Init()
        {
            Grid.Controls.Clear();
            Cs = new Cell[dim, dim];

            for(int ri = 0; ri < dim; ri++)
            {
                for(int ci = 0; ci < dim; ci++)
                {
                    int H = Grid.Height / dim - 10;
                    int W = Grid.Width / dim - 10;

                    Cell c = new Cell(H, W);
                    Grid.Controls.Add(c);
                    if (HumanVsHuman.Checked == true)
                    {
                        c.Click += new System.EventHandler(WhenCellSelectedHumanVsHuman);
                    }
                    else if (HumanVsMachine.Checked == true)
                    {
                        c.Click += new System.EventHandler(WhenCellSelectedHumanVsMachine);
                    }
                    else
                    {
                        MessageBox.Show("Select Game Mode!");
                        return;
                    }
                    Cs[ri, ci] = c;
                }
            }
        }

        bool IsHoriontalWin(int ri, int ci, COLOR Turn)
        {
            if(ci + WC > dim)
            {
                return false;
            }

            for (int i = 0; i < WC; i++)
            {
                if(Cs[ri, ci + i].Occupier != Turn)
                {
                    return false;
                }
            }
            return true;
        }

        bool IsVerticalWin(int ri, int ci, COLOR Turn)
        {
            if (ri + WC > dim)
            {
                return false;
            }

            for (int i = 0; i < WC; i++)
            {
                if (Cs[ri + i, ci].Occupier != Turn)
                {
                    return false;
                }
            }
            return true;
        }

        bool IsDiagonalL2R(int ri, int ci, COLOR Turn)
        {
            if (ri + WC > dim || ci + WC > dim)
            {
                return false;
            }

            for (int i = 0; i < WC; i++)
            {
                if (Cs[ri + i, ci + i].Occupier != Turn)
                {
                    return false;
                }
            }
            return true;
        }

        bool IsDiagonalR2L(int ri, int ci, COLOR Turn)
        {
            if (ri + WC > dim || ci - WC < 0)
            {
                return false;
            }

            for (int i = 0; i < WC; i++)
            {
                if (Cs[ri + i, ci - i].Occupier != Turn)
                {
                    return false;
                }
            }
            return true;
        }

        bool IsWin(COLOR Turn)            
        {
            for(int ri = 0; ri < dim; ri++)
            {
                for (int ci = 0; ci < dim; ci++)
                {
                    if(DoIWinHere(ri, ci, Turn))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        bool DoIWinHere(int ri, int ci, COLOR Turn)
        {
            return IsHoriontalWin(ri, ci, Turn) || IsVerticalWin(ri, ci, Turn) || IsDiagonalL2R(ri, ci, Turn) || IsDiagonalR2L(ri, ci, Turn);
        }

        void WhenCellSelectedHumanVsHuman(object sender, EventArgs e)
        {
            cc = (Cell)sender;
            if(cc.Occupier != COLOR.WHITE)
            {
                MessageBox.Show("Invalid Move!");
                return;
            }
            UpdateBoard();
            
            if(IsWin(Turn))
            {
                MessageBox.Show(Turn.ToString() + " Wins!");
                Grid.Controls.Clear();
            }

            TURNCHANGE();
        }

        void ComputerMove()
        {
            int ri;
            int ci;
            int DWC = WC;
            do
            {
                Random rnd = new Random();
                ri = rnd.Next(0, dim - 1);
                ci = rnd.Next(0, dim - 1);
                cc = Cs[ri, ci];
            } while (Cs[ri, ci].Occupier != COLOR.WHITE);

            while(WC != 0)
            {
                for (ri = 0; ri < dim; ri++)
                {
                    for (ci = 0; ci < dim; ci++)
                    {
                        if (Cs[ri, ci].Occupier == COLOR.WHITE)
                        {
                            Cs[ri, ci].Occupier = Turn;
                            if (IsWin(Turn))
                            {
                                Cs[ri, ci].Occupier = COLOR.WHITE;
                                cc = Cs[ri, ci];
                                WC = DWC;
                                return;
                            }
                            else
                            {
                                Cs[ri, ci].Occupier = COLOR.WHITE;
                            }
                        }
                    }
                }

                TURNCHANGE();

                for (ri = 0; ri < dim; ri++)
                {
                    for (ci = 0; ci < dim; ci++)
                    {
                        if (Cs[ri, ci].Occupier == COLOR.WHITE)
                        {
                            Cs[ri, ci].Occupier = Turn;
                            if (IsWin(Turn))
                            {
                                Cs[ri, ci].Occupier = COLOR.WHITE;
                                TURNCHANGE();
                                cc = Cs[ri, ci];
                                WC = DWC;
                                return;
                            }
                            else
                            {
                                Cs[ri, ci].Occupier = COLOR.WHITE;
                            }
                        }
                    }
                }
                TURNCHANGE();
                WC--;
            }
            WC = DWC;
        }

        void WhenCellSelectedHumanVsMachine(object sender, EventArgs e)
        {
            cc = (Cell)sender;

            for (int i = 0; i < 2; i++)
            {
                if (i == 0)
                {
                    if (cc.Occupier != COLOR.WHITE)
                    {
                        MessageBox.Show("Invalid Move!");
                        return;
                    }
                }
                else
                {
                    ComputerMove();
                }

                UpdateBoard();

                if (IsWin(Turn))
                {
                    MessageBox.Show(Turn.ToString() + " Wins!");
                    Grid.Controls.Clear();
                }

                TURNCHANGE();
            }
        }

        void UpdateBoard()
        {
            cc.Occupier = Turn;
            if(Turn == COLOR.BLUE)
            {
                cc.BackColor = Color.Blue;
            }
            else
            {
                cc.BackColor = Color.Red;
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if(Fivex5.Checked == true)
            {
                dim = 5;
            }
            else if(Tenx10.Checked == true)
            {
                dim = 10;
            }
            else if(Fifteenx15.Checked == true)
            {
                dim = 15;
            }
            else
            {
                MessageBox.Show("Select Dimension!");
                return;
            }
            Init();
        }

        private void Fivex5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Tenx10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Fifteenx15_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void Grid_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GForm_Load(object sender, EventArgs e)
        {

        }

        private void HumanVsHuman_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void HumanVsMachine_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Gamemode_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
