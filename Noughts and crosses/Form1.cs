using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public bool fl;
        public Form1()
        {
            InitializeComponent();
            fl = true;
        }

        public void clearbtns()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
        }

        public void check()
        {
            int i;
            string x_won = "X выиграл. ";
            string o_won = "O выиграл. ";
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                if (MessageBox.Show(x_won+"Выйти из игры?(Да) Начать заново?(Нет)", "Крестики-нолики", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    clearbtns();
                }
                return;
            }
                
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                if (MessageBox.Show(o_won + "Выйти из игры?(Да) Начать заново?(Нет)", "Крестики-нолики", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    clearbtns();
                }
                return;
            }
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                if (MessageBox.Show(x_won + "Выйти из игры?(Да) Начать заново?(Нет)", "Крестики-нолики", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    clearbtns();
                }
                return;
            }
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                if (MessageBox.Show(o_won + "Выйти из игры?(Да) Начать заново?(Нет)", "Крестики-нолики", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    clearbtns();
                }
                return;
            }
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                if (MessageBox.Show(x_won + "Выйти из игры?(Да) Начать заново?(Нет)", "Крестики-нолики", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    clearbtns();
                }
                return;
            }
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                if (MessageBox.Show(o_won + "Выйти из игры?(Да) Начать заново?(Нет)", "Крестики-нолики", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    clearbtns();
                }
                return;
            }
            if (button1.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                if (MessageBox.Show(x_won + "Выйти из игры?(Да) Начать заново?(Нет)", "Крестики-нолики", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    clearbtns();
                }
                return;
            }
            if (button1.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                if (MessageBox.Show(o_won + "Выйти из игры?(Да) Начать заново?(Нет)", "Крестики-нолики", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    clearbtns();
                }
                return;
            }
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                if (MessageBox.Show(x_won + "Выйти из игры?(Да) Начать заново?(Нет)", "Крестики-нолики", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    clearbtns();
                }
                return;
            }
            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                if (MessageBox.Show(o_won + "Выйти из игры?(Да) Начать заново?(Нет)", "Крестики-нолики", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    clearbtns();
                }
                return;
            }
            if (button3.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                if (MessageBox.Show(x_won + "Выйти из игры?(Да) Начать заново?(Нет)", "Крестики-нолики", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    clearbtns();
                }
                return;
            }
            if (button3.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                if (MessageBox.Show(o_won + "Выйти из игры?(Да) Начать заново?(Нет)", "Крестики-нолики", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    clearbtns();
                }
                return;
            }
            if (button1.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                if (MessageBox.Show(x_won + "Выйти из игры?(Да) Начать заново?(Нет)", "Крестики-нолики", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    clearbtns();
                }
                return;
            }
            if (button1.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                if (MessageBox.Show(o_won + "Выйти из игры?(Да) Начать заново?(Нет)", "Крестики-нолики", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    clearbtns();
                }
                return;
            }
            if (button3.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                if (MessageBox.Show(x_won + "Выйти из игры?(Да) Начать заново?(Нет)", "Крестики-нолики", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    clearbtns();
                }
                return;
            }
            if (button3.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                if (MessageBox.Show(o_won + "Выйти из игры?(Да) Начать заново?(Нет)", "Крестики-нолики", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    clearbtns();
                }
                return;
            }
            if (button1.Text.Length != 0 && button2.Text.Length != 0 && button3.Text.Length != 0 && button4.Text.Length != 0 && button5.Text.Length != 0 && button6.Text.Length != 0 && button7.Text.Length != 0 && button8.Text.Length != 0 && button9.Text.Length != 0)
            {
                if (MessageBox.Show("Ничья. Хотите начать игру заново? Выход(Нет). Заново(Да)", "Крестики-нолики", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                      == DialogResult.No)
                {
                    Application.Exit();
                }
                else
                {
                    clearbtns();
                }
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(fl==true)
            {
                button1.Text = "X";
                fl = false;
                check();
            }
            else
            {
                button1.Text = "O";
                fl = true;
                check();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (fl == true)
            {
                button2.Text = "X";
                fl = false;
                check();
            }
            else
            {
                button2.Text = "O";
                fl = true;
                check();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (fl == true)
            {
                button3.Text = "X";
                fl = false;
                check();
            }
            else
            {
                button3.Text = "O";
                fl = true;
                check();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (fl == true)
            {
                button6.Text = "X";
                fl = false;
                check();
            }
            else
            {
                button6.Text = "O";
                fl = true;
                check();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (fl == true)
            {
                button5.Text = "X";
                fl = false;
                check();
            }
            else
            {
                button5.Text = "O";
                fl = true;
                check();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (fl == true)
            {
                button4.Text = "X";
                fl = false;
                check();
            }
            else
            {
                button4.Text = "O";
                fl = true;
                check();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (fl == true)
            {
                button9.Text = "X";
                fl = false;
                check();
            }
            else
            {
                button9.Text = "O";
                fl = true;
                check();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (fl == true)
            {
                button8.Text = "X";
                fl = false;
                check();
            }
            else
            {
                button8.Text = "O";
                fl = true;
                check();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (fl == true)
            {
                button7.Text = "X";
                fl = false;
                check();
            }
            else
            {
                button7.Text = "O";
                fl = true;
                check();
            }
        }
    }
}
