using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.Properties;

namespace WindowsFormsApp3
{
    public partial class level1_mmedium_ : Form
    {
        public static int score;
        public level1_mmedium_() 
        {
            InitializeComponent();
        }

        private void level1_mmedium__Load(object sender, EventArgs e)
        {

        }
        String j = "J";
        String u= "U";
        String n = "N";
        String g = "G";
        String l = "L";
        String e1 = "E";

        
        int wrong = 0;
        int canswer = 0;

        private void button7_Click(object sender, EventArgs e)
        {
            label2.Text = j;
            button7.Enabled = false;
            score++;
            label1.Text = "Score: " + score;

            canswer++;

            if (canswer == 6)
            {
                MessageBox.Show("Congrats! You win, with a score of" + score + "!" + "\nClick OK then click ➡️ ", "GOODJOB!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button11.Enabled = true;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label3.Text = u;
            button9.Enabled = false;
            score++;
            label1.Text = "Score: " + score;

            canswer++;

            if (canswer == 6)
            {
                MessageBox.Show("Congrats! You win, with a score of" + score + "!" + "\nClick OK then click ➡️ ", "GOODJOB!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button11.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label4.Text = n;
            button4.Enabled = false;
            score++;
            label1.Text = "Score: " + score;

            canswer++;

            if (canswer == 6)
            {
                MessageBox.Show("Congrats! You win, with a score of" + score + "!" + "\nClick OK then click ➡️ ", "GOODJOB!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button11.Enabled = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label5.Text = g;
            button8.Enabled = false;
            score++;
            label1.Text = "Score: " + score;

            canswer++;

            if (canswer == 6)
            {
                MessageBox.Show("Congrats! You win, with a score of" + score + "!" + "\nClick OK then click ➡️ ", "GOODJOB!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button11.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label6.Text = l;
            button2.Enabled = false;
            score++;
            label1.Text = "Score: " + score;

            canswer++;

            if (canswer == 6)
            {
                MessageBox.Show("Congrats! You win, with a score of" + score + "!" + "\nClick OK then click ➡️ ", "GOODJOB!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button11.Enabled = true;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            label7.Text = e1;
            button14.Enabled = false;
            score++;
            label1.Text = "Score: " + score;

            canswer++;

            if (canswer == 6)
            {
                MessageBox.Show("Congrats! You win, with a score of" + score + "!" + "\nClick OK then click ➡️ ", "GOODJOB!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button11.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "X";
            score--;
            button1.Enabled = false;
            wrong++;

            if (wrong == 1)
            {
                pictureBox1.Image = Resources.por;
            }
            if (wrong == 2)
            {
                pictureBox1.Image = Resources.seben;
            }
            if (wrong == 3)
            {
                pictureBox1.Image = Resources.nayn;
            }
            if (wrong == 4)
            {
                pictureBox1.Image = Resources.patay;
                MessageBox.Show("Game Over! You lost.", "Hangman", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult result = MessageBox.Show("Game Over!\nDo you want to play again?", "Hangman", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    new Form1().Show();
                    this.Hide();
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button13.Text = "X";
            score--;
            button13.Enabled = false;
            wrong++;

            if (wrong == 1)
            {
                pictureBox1.Image = Resources.por;
            }
            if (wrong == 2)
            {
                pictureBox1.Image = Resources.seben;
            }
            if (wrong == 3)
            {
                pictureBox1.Image = Resources.nayn;
            }
            if (wrong == 4)
            {
                pictureBox1.Image = Resources.patay;
                MessageBox.Show("Game Over! You lost.", "Hangman", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult result = MessageBox.Show("Game Over!\nDo you want to play again?", "Hangman", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    new Form1().Show();
                    this.Hide();
                }
                else
                {
                    Application.Exit();
                }
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = "X";
            score--;
            button3.Enabled = false;
            wrong++;

            if (wrong == 1)
            {
                pictureBox1.Image = Resources.por;
            }
            if (wrong == 2)
            {
                pictureBox1.Image = Resources.seben;
            }
            if (wrong == 3)
            {
                pictureBox1.Image = Resources.nayn;
            }
            if (wrong == 4)
            {
                pictureBox1.Image = Resources.patay;
                MessageBox.Show("Game Over! You lost.", "Hangman", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult result = MessageBox.Show("Game Over!\nDo you want to play again?", "Hangman", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    new Form1().Show();
                    this.Hide();
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = "X";
            score--;
            button5.Enabled = false;
            wrong++;

            if (wrong == 1)
            {
                pictureBox1.Image = Resources.por;
            }
            if (wrong == 2)
            {
                pictureBox1.Image = Resources.seben;
            }
            if (wrong == 3)
            {
                pictureBox1.Image = Resources.nayn;
            }
            if (wrong == 4)
            {
                pictureBox1.Image = Resources.patay;
                MessageBox.Show("Game Over! You lost.", "Hangman", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult result = MessageBox.Show("Game Over!\nDo you want to play again?", "Hangman", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    new Form1().Show();
                    this.Hide();
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.Text = "X";
            score--;
            button10.Enabled = false;
            wrong++;

            if (wrong == 1)
            {
                pictureBox1.Image = Resources.por;
            }
            if (wrong == 2)
            {
                pictureBox1.Image = Resources.seben;
            }
            if (wrong == 3)
            {
                pictureBox1.Image = Resources.nayn;
            }
            if (wrong == 4)
            {
                pictureBox1.Image = Resources.patay;
                MessageBox.Show("Game Over! You lost.", "Hangman", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult result = MessageBox.Show("Game Over!\nDo you want to play again?", "Hangman", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    new Form1().Show();
                    this.Hide();
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = "X";
            score--;
            button6.Enabled = false;
            wrong++;

            if (wrong == 1)
            {
                pictureBox1.Image = Resources.por;
            }
            if (wrong == 2)
            {
                pictureBox1.Image = Resources.seben;
            }
            if (wrong == 3)
            {
                pictureBox1.Image = Resources.nayn;
            }
            if (wrong == 4)
            {
                pictureBox1.Image = Resources.patay;
                MessageBox.Show("Game Over! You lost.", "Hangman", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult result = MessageBox.Show("Game Over!\nDo you want to play again?", "Hangman", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    new Form1().Show();
                    this.Hide();
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Press OK to continue, press NO to go to main menu", "Do you want to continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

            }
            else
            {

                new Form1().Show();
                this.Hide();
            }
        }
    }
}
