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
    public partial class level3_easy_ : Form
    {
        public level3_easy_()
        {
            InitializeComponent();
        }

        String c = "C";
        String h = "H";
        String a = "A";
        String i = "I";
        String r = "R";

        int score = Form3.score;
        int wrong = 0;
        int canswer = 0;
        private void level3_easy__Load(object sender, EventArgs e)
        {
            label1.Text = "Score: " + Form3.score;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = c;
            button1.Enabled = false;
            score++;
            label1.Text = "Score: " + score;

            canswer++;

            if (canswer == 5)
            {
                MessageBox.Show("Congrats! You win, with a score of" + score + "!" + "\nClick OK then click ➡️ ", "GOODJOB!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button11.Enabled = true;
            }

        
    }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = "X";
            score--;
            button2.Enabled = false;
            wrong++;

            if (wrong == 1)
            {
                pictureBox1.Image = Resources.tri;
            }
            if (wrong == 2)
            {
                pictureBox1.Image = Resources.payb;
            }
            if (wrong == 3)
            {
                pictureBox1.Image = Resources.seben;
            }
            if (wrong == 4)
            {
                pictureBox1.Image = Resources.nayn;
            }
            if (wrong == 5)
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
                pictureBox1.Image = Resources.tri;
            }
            if (wrong == 2)
            {
                pictureBox1.Image = Resources.payb;
            }
            if (wrong == 3)
            {
                pictureBox1.Image = Resources.seben;
            }
            if (wrong == 4)
            {
                pictureBox1.Image = Resources.nayn;
            }
            if (wrong == 5)
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

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Text = h;
            button3.Enabled = false;
            score++;
            label1.Text = "Score: " + score;

            canswer++;

            if (canswer == 5)
            {
                MessageBox.Show("Congrats! You win, with a score of" + score + "!" + "\nClick OK then click ➡️ ", "GOODJOB!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button11.Enabled = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label4.Text = a;
            button8.Enabled = false;
            score++;
            label1.Text = "Score: " + score;

            canswer++;

            if (canswer == 5)
            {
                MessageBox.Show("Congrats! You win, with a score of" + score + "!" + "\nClick OK then click ➡️ ", "GOODJOB!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button11.Enabled = true;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label5.Text = i;
            button9.Enabled = false;
            score++;
            label1.Text = "Score: " + score;

            canswer++;

            if (canswer == 5)
            {
                MessageBox.Show("Congrats! You win, with a score of" + score + "!" + "\nClick OK then click ➡️ ", "GOODJOB!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button11.Enabled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label6.Text = r;
            button5.Enabled = false;
            score++;
            label1.Text = "Score: " + score;

            canswer++;

            if (canswer == 5)
            {
                MessageBox.Show("Congrats! You win, with a score of" + score + "!" + "\nClick OK then click ➡️ ", "GOODJOB!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button11.Enabled = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = "X";
            score--;
            button7.Enabled = false;
            wrong++;

            if (wrong == 1)
            {
                pictureBox1.Image = Resources.tri;
            }
            if (wrong == 2)
            {
                pictureBox1.Image = Resources.payb;
            }
            if (wrong == 3)
            {
                pictureBox1.Image = Resources.seben;
            }
            if (wrong == 4)
            {
                pictureBox1.Image = Resources.nayn;
            }
            if (wrong == 5)
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
                pictureBox1.Image = Resources.tri;
            }
            if (wrong == 2)
            {
                pictureBox1.Image = Resources.payb;
            }
            if (wrong == 3)
            {
                pictureBox1.Image = Resources.seben;
            }
            if (wrong == 4)
            {
                pictureBox1.Image = Resources.nayn;
            }
            if (wrong == 5)
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
                pictureBox1.Image = Resources.tri;
            }
            if (wrong == 2)
            {
                pictureBox1.Image = Resources.payb;
            }
            if (wrong == 3)
            {
                pictureBox1.Image = Resources.seben;
            }
            if (wrong == 4)
            {
                pictureBox1.Image = Resources.nayn;
            }
            if (wrong == 5)
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

        private void button11_Click(object sender, EventArgs e)
        {
            
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
}
