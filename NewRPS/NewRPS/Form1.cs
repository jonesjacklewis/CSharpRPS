using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewRPS
{
    public partial class Form1 : Form
    {
        string choice1;
        string choice2;
        bool oneplayer = false;
        int chosen1 = 0;
        string winner;

        public Form1()
        {
            InitializeComponent();

        }
       private void togglecolor(PictureBox pb)
        {
            if (pb.BackColor == System.Drawing.Color.Gray)
            {
                pb.BackColor = Form1.DefaultBackColor;
            }
            else
            {
                pb.BackColor = System.Drawing.Color.Gray;
            }
        }

       

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            choice1 = "Scissors";
            chosen1 += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Location = new Point((Form1.ActiveForm.Width / 2) - 50, 10);
            pictureBox1.Location = new Point((Form1.ActiveForm.Width / 2) - 50, pictureBox1.Location.Y);
            pictureBox2.Location = new Point((Form1.ActiveForm.Width / 2) - 50, pictureBox2.Location.Y);
            pictureBox3.Location = new Point((Form1.ActiveForm.Width / 2) - 50, pictureBox3.Location.Y);
            button2.Hide();
            pictureBox4.Hide();
            pictureBox5.Hide();
            pictureBox6.Hide();
            oneplayer = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (oneplayer == true || choice2 == null)
            {
                var list = new List<string> { "Rock", "Paper", "Scissors" };
                Random rnd = new Random();
                int r = rnd.Next(list.Count);
                choice2 = list[r];
               
            }
            if (choice1 == choice2)
            {
                winner = "It's a draw";
            }
            else if (choice1 == "Rock" && choice2 == "Paper")
            {
                winner = "Player 2 Wins";
            }
            else if (choice1 == "Rock" && choice2 == "Scissors")
            {
                winner = "Player 1 Wins";
            }
            else if (choice1 == "Paper" && choice2 == "Rock")
            {
                winner = "Player 1 Wins";
            }
            else if (choice1 == "Paper" && choice2 == "Scissors")
            {
                winner = "Player 2 Wins";
            }
            else if (choice1 == "Scissors" && choice2 == "Rock")
            {
                winner = "Player 2 Wins";
            }
            else if (choice1 == "Scissors" && choice2 == "Paper")
            {
                winner = "Player 1 Wins";
            }
            else
            {
                winner = "Sorry something has gone wrong. Please reload";
            }

            P1.Text = choice1;
            P2.Text = choice2;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            choice1 = "Paper";
            chosen1 += 1;
            togglecolor(pictureBox2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            choice1 = "Rock";
            chosen1 += 1;
            togglecolor(pictureBox1);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            button1.Location = new Point((Form1.ActiveForm.Width / 2) - 50, 10);
            pictureBox1.Location = new Point((Form1.ActiveForm.Width / 2) - 50, pictureBox1.Location.Y);
            pictureBox2.Location = new Point((Form1.ActiveForm.Width / 2) - 50, pictureBox2.Location.Y);
            pictureBox3.Location = new Point((Form1.ActiveForm.Width / 2) - 50, pictureBox3.Location.Y);
            button2.Hide();
            pictureBox4.Hide();
            pictureBox5.Hide();
            pictureBox6.Hide();
            oneplayer = true;
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            button1.Location = new Point((Form1.ActiveForm.Width / 2) - 50, 10);
            pictureBox1.Location = new Point((Form1.ActiveForm.Width / 2) - 50, pictureBox1.Location.Y);
            pictureBox2.Location = new Point((Form1.ActiveForm.Width / 2) - 50, pictureBox2.Location.Y);
            pictureBox3.Location = new Point((Form1.ActiveForm.Width / 2) - 50, pictureBox3.Location.Y);
            button2.Hide();
            pictureBox4.Hide();
            pictureBox5.Hide();
            pictureBox6.Hide();
            oneplayer = true;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            choice2 = "Rock";
            togglecolor(pictureBox6);

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            togglecolor(pictureBox5);
            choice2 = "Paper";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            togglecolor(pictureBox4);
            choice2 = "Scissors";
        }

        private void P1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (oneplayer == true || choice2 == null)
            {
                var list = new List<string> { "Rock", "Paper", "Scissors" };
                Random rnd = new Random();
                int r = rnd.Next(list.Count);
                choice2 = list[r];

            }
            if (choice1 == choice2)
            {
                winner = "It's a draw";
            }
            else if (choice1 == "Rock" && choice2 == "Paper")
            {
                winner = "Player 2 Wins";
            }
            else if (choice1 == "Rock" && choice2 == "Scissors")
            {
                winner = "Player 1 Wins";
            }
            else if (choice1 == "Paper" && choice2 == "Rock")
            {
                winner = "Player 1 Wins";
            }
            else if (choice1 == "Paper" && choice2 == "Scissors")
            {
                winner = "Player 2 Wins";
            }
            else if (choice1 == "Scissors" && choice2 == "Rock")
            {
                winner = "Player 2 Wins";
            }
            else if (choice1 == "Scissors" && choice2 == "Paper")
            {
                winner = "Player 1 Wins";
            }
            else
            {
                winner = "Sorry something has gone wrong. Please reload";
            }

            P1.Text = choice1;
            P2.Text = choice2;
            Message.Text = winner;

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            choice1 = "Scissors";
            chosen1 += 1;
            togglecolor(pictureBox3);
        }

        
    }
}
