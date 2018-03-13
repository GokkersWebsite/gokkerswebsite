using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gokkers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        PictureBox[] moles = new PictureBox[6];
        bool[] Winners = new bool[6];

        public int balance1 = 50;
        public int balance2 = 50;
        public int balance3 = 50;

        public int inzet1 = 0;
        public int inzet2 = 0;
        public int inzet3 = 0;

        public bool winner1 = false;
        public bool winner2 = false;
        public bool winner3 = false;
        public bool winner4 = false;
        public bool winner5 = false;
        public bool winner6 = false;

        public bool check = true;

        public int wed1;
        public int wed2;
        public int wed3;

        public int reward1;
        public int reward2;
        public int reward3;

        public int time;

        private void Form1_Load(object sender, EventArgs e)
        {
            moles[0] = img_mol1;
            moles[1] = img_mol2;
            moles[2] = img_mol3;
            moles[3] = img_mol4;
            moles[4] = img_mol5;
            moles[5] = img_mol6;

            Winners[0] = winner1;
            Winners[1] = winner2;
            Winners[2] = winner3;
            Winners[3] = winner4;
            Winners[4] = winner5;
            Winners[5] = winner6;
        }

        private void rbtn_player1_CheckedChanged(object sender, EventArgs e)
        {
            lbl_playerselect.Text = "Speler 1 geselecteerd";
        }

        private void rbtn_player2_CheckedChanged(object sender, EventArgs e)
        {
            lbl_playerselect.Text = "Speler 2 geselecteerd";
        }

        private void rbtn_player3_CheckedChanged(object sender, EventArgs e)
        {
            lbl_playerselect.Text = "Speler 3 geselecteerd";
        }

        private void lbl_playerselect_Click(object sender, EventArgs e)
        {

        }

        private void lbl_amount_Click(object sender, EventArgs e)
        {

        }

        private void btn_wed_Click(object sender, EventArgs e)
        {
            if(rbtn_player1.Checked)
            {
                inzet1 = (int)nmr_inzet.Value;
                wed1 = Convert.ToInt32(nmr_mol.Value);
                lbl_wed1.Text = "Speler 1 heeft €" + inzet1 + " op mol nummer " + wed1 + " ingezet";
                btn_start.Enabled = true;
            }
            else if(rbtn_player2.Checked)
            {
                inzet2 = (int)nmr_inzet.Value;
                wed2 = Convert.ToInt32(nmr_mol.Value);
                lbl_wed2.Text = "Speler 2 heeft €" + inzet2 + " op mol nummer " + wed2 + " ingezet";
                btn_start.Enabled = true;
            }
            else if (rbtn_player3.Checked)
            {
                inzet3 = (int)nmr_inzet.Value;
                wed3 = Convert.ToInt32(nmr_mol.Value);
                lbl_wed3.Text = "Speler 3 heeft €" + inzet3 + " op mol nummer " + wed3 + " ingezet";
                btn_start.Enabled = true;
            }
            if(inzet1 >= 5 || inzet2 >= 5 || inzet3 >= 5)
            {
                btn_start.Enabled = true;
            }
            else
            {

            }

        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            btn_start.Enabled = false;
            btn_restart.Enabled = false;
            btn_wed.Enabled = false;
            btn_cancel1.Enabled = false;
            btn_cancel2.Enabled = false;
            btn_cancel3.Enabled = false;

            if (balance1 >= inzet1 && balance2 >= inzet2 && balance3 >= inzet3)
                {
                    balance1 = (balance1 - inzet1);
                    balance2 = (balance2 - inzet2);
                    balance3 = (balance3 - inzet3);
                    lbl_balance1.Text = "Geld: " + balance1;
                    lbl_balance2.Text = "Geld: " + balance2;
                    lbl_balance3.Text = "Geld: " + balance3;
                    timer1.Start();
                    timer2.Start();
            }
                else
                {
                    if (balance1 <= inzet1)
                    {
                        MessageBox.Show("Speler 1 komt geld tekort");
                        btn_restart.Enabled = true;
                    }
                    else if (balance2 <= inzet2)
                    {
                        MessageBox.Show("Speler 2 komt geld tekort");
                        btn_restart.Enabled = true;
                    }
                    else if (balance3 <= inzet3)
                    {
                        MessageBox.Show("Speler 3 komt geld tekort");
                        btn_restart.Enabled = true;
                    }
                }
            
            
        }

        private void btn_cancel1_Click(object sender, EventArgs e)
        {
            lbl_wed1.Text = "Speler 1 Heeft nog niks geboden ";
            inzet1 = 0;
            btn_start.Enabled = false;
        }

        private void btn_cancel2_Click(object sender, EventArgs e)
        {
            lbl_wed2.Text = "Speler 2 Heeft nog niks geboden ";
            inzet2 = 0;
            btn_start.Enabled = false;
        }

        private void btn_cancel3_Click(object sender, EventArgs e)
        {
            lbl_wed3.Text = "Speler 3 Heeft nog niks geboden ";
            inzet3 = 0;
            btn_start.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int move;
            move = 0;

            if (moles[0].Location.X <= 830 & moles[1].Location.X <= 830 & moles[2].Location.X <= 830 & moles[3].Location.X <= 830 & moles[4].Location.X <= 830 & moles[5].Location.X <= 830)
            {
                move = rnd.Next(0, 25);
                moles[0].Location = new Point(img_mol1.Location.X + move, img_mol1.Location.Y);
                move = rnd.Next(0, 25);
                moles[1].Location = new Point(img_mol2.Location.X + move, img_mol2.Location.Y);
                move = rnd.Next(0, 25);
                moles[2].Location = new Point(img_mol3.Location.X + move, img_mol3.Location.Y);
                move = rnd.Next(0, 25);
                moles[3].Location = new Point(img_mol4.Location.X + move, img_mol4.Location.Y);
                move = rnd.Next(0, 25);
                moles[4].Location = new Point(img_mol5.Location.X + move, img_mol5.Location.Y);
                move = rnd.Next(0, 25);
                moles[5].Location = new Point(img_mol6.Location.X + move, img_mol6.Location.Y);
                if (moles[0].Location.X >= 830 && check)
                {
                    timer2.Stop();
                    MessageBox.Show("Mol 1 heeft gewonnen! Tijd: " + time);
                    if (inzet1 >= 0 && wed1 == 1)
                    {
                        reward1 = inzet1 * 2;
                    }
                    if(inzet2 >= 0 && wed2 == 1)
                    {
                        reward2 = inzet2 * 2;
                    }
                    if (inzet3 >= 0 && wed3 == 1)
                    {
                        reward3 = inzet3 * 2;
                    }
                    Winners[0] = true;
                    check = false;
                    
                }
                if (moles[1].Location.X >= 830 && check)
                {
                    timer2.Stop();
                    MessageBox.Show("Mol 2 heeft gewonnen! Tijd: " + time);
                    if (inzet1 >= 0 && wed1 == 2)
                    {
                        reward1 = inzet1 * 2;
                    }
                    else if (inzet2 >= 0 && wed2 == 2)
                    {
                        reward2 = inzet2 * 2;
                    }
                    else if (inzet3 >= 0 && wed3 == 2)
                    {
                        reward3 = inzet3 * 2;
                    }
                    Winners[1] = true;
                    check = false;
                }
                if (moles[2].Location.X >= 830 && check)
                {
                    timer2.Stop();
                    MessageBox.Show("Mol 3 heeft gewonnen! Tijd: " + time);
                    if (inzet1 >= 0 && wed1 == 3)
                    {
                        reward1 = inzet1 * 2;
                    }
                    if (inzet2 >= 0 && wed2 == 3)
                    {
                        reward2 = inzet2 * 2;
                    }
                    if (inzet3 >= 0 && wed3 == 3)
                    {
                        reward3 = inzet3 * 2;
                    }
                    Winners[2] = true;
                    check = false;
                }
                if (moles[3].Location.X >= 830 && check)
                {
                    timer2.Stop();
                    MessageBox.Show("Mol 4 heeft gewonnen! Tijd: " + time);
                    if (inzet1 >= 0 && wed1 == 4)
                    {
                        reward1 = inzet1 * 2;
                    }
                    if (inzet2 >= 0 && wed2 == 4)
                    {
                        reward2 = inzet2 * 2;
                    }
                    if (inzet3 >= 0 && wed3 == 4)
                    {
                        reward3 = inzet3 * 2;
                    }
                    Winners[3] = true;
                    check = false;
                }
                if (moles[4].Location.X >= 830 && check)
                {
                    timer2.Stop();
                    MessageBox.Show("Mol 5 heeft gewonnen! Tijd: " + time);

                    if (inzet1 >= 0 && wed1 == 5)
                    {
                        reward1 = inzet1 * 2;
                    }
                    if (inzet2 >= 0 && wed2 == 5)
                    {
                        reward2 = inzet2 * 2;
                    }
                    if (inzet3 >= 0 && wed3 == 5)
                    {
                        reward3 = inzet3 * 2;
                    }
                    Winners[4] = true;
                    check = false;
                }
                if (moles[5].Location.X >= 830 && check)
                {
                    timer2.Stop();
                    MessageBox.Show("Mol 6 heeft gewonnen! Tijd: " + time);
                    if (inzet1 >= 0 && wed1 == 6)
                    {
                        reward1 = inzet1 * 2;
                    }
                    if (inzet2 >= 0 && wed2 == 6)
                    {
                        reward2 = inzet2 * 2;
                    }
                    if (inzet3 >= 0 && wed3 == 6)
                    {
                        reward3 = inzet3 * 2;
                    }
                    Winners[5] = true;
                    check = false;
                }
            }
            if (Winners[0] == true || Winners[1] == true || Winners[2] == true || Winners[3] == true || Winners[4] == true || Winners[5] == true)
            {
                lbl_balance1.Text = "Geld: " + (balance1 = balance1 + reward1);
                lbl_balance2.Text = "Geld: " + (balance2 = balance2 + reward2);
                lbl_balance3.Text = "Geld: " + (balance3 = balance3 + reward3);
                timer1.Stop();
                timer2.Stop();
                
                btn_restart.Enabled = true;
                Winners[0] = false;
                Winners[1] = false;
                Winners[2] = false;
                Winners[3] = false;
                Winners[4] = false;
                Winners[5] = false;
    }
        }

        private void btn_restart_Click(object sender, EventArgs e)
        {
            Winners[0] = false;
            Winners[1] = false;
            Winners[2] = false;
            Winners[3] = false;
            Winners[4] = false;
            Winners[5] = false;
            reward1 = 0;
            reward2 = 0;
            reward3 = 0;
            inzet1 = 0;
            inzet2 = 0;
            inzet3 = 0;
            time = 0;
            check = true;
            lbl_timer.Text = "Timer: 0";
            moles[0].Location = new Point(46, 17);
            moles[1].Location = new Point(46, 83);
            moles[2].Location = new Point(46, 145);
            moles[3].Location = new Point(46, 212);
            moles[4].Location = new Point(46, 273);
            moles[5].Location = new Point(46, 332);
            btn_start.Enabled = false;
            btn_restart.Enabled = false;
            btn_wed.Enabled = true;
            btn_cancel1.Enabled = true;
            btn_cancel2.Enabled = true;
            btn_cancel3.Enabled = true;

            lbl_wed1.Text = "Speler 1 Heeft nog niks geboden ";
            
            lbl_wed2.Text = "Speler 2 Heeft nog niks geboden ";
            
            lbl_wed3.Text = "Speler 3 Heeft nog niks geboden ";
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            
            time++;
            lbl_timer.Text = "Timer: " + time;
            
        }

    }
}
