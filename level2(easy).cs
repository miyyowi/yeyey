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
    public partial class Form3 : Form
    {
        public static int score = Form2.score;
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        String c = "C";
        String l = "L";
        String o = "O";
        String u = "U";
        String d = "D";

        
        int wrong = 0;
        int canswer = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "X";
            score--;
            button1.Enabled = false;
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
            }
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

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = "X";
            score--;
            button4.Enabled = false;
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

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text = "X";
            score--;
            button9.Enabled = false;
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

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.tu;
        }

        private void button11_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            label4.Text = o;
            button2.Enabled = false;
            score++;
            label1.Text = "Score: " + score;

            canswer++;

            if (canswer == 5)
            {
                MessageBox.Show("You win! Click OK then click ➡️ ", "GOODJOB!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button11.Enabled = true;
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            button4.Text = "X";
            score--;
            button4.Enabled = false;
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

        private void button9_Click_1(object sender, EventArgs e)
        {
            button9.Text = "X";
            score--;
            button9.Enabled = false;
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

        private void button10_Click_1(object sender, EventArgs e)
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

        private void button7_Click_1(object sender, EventArgs e)
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

        private void button5_Click_1(object sender, EventArgs e)
        {
            label5.Text = u;
            button5.Enabled = false;
            score++;
            label1.Text = "Score: " + score;

            canswer++;

            if (canswer == 5)
            {
                MessageBox.Show("You win! Click OK then click ➡️ ", "GOODJOB!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button11.Enabled = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            label2.Text = c;
            button1.Enabled = false;
            score++;
            label1.Text = "Score: " + score;

            canswer++;

            if (canswer == 5)
            {
                MessageBox.Show("You win! Click OK then click ➡️ ", "GOODJOB!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button11.Enabled = true;
            }

        }

        private void button6_Click_1(object sender, EventArgs e)
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

        private void button3_Click_1(object sender, EventArgs e)
        {
            label6.Text = d;
            button3.Enabled = false;
            score++;
            label1.Text = "Score: " + score;

            canswer++;

            if (canswer == 5)
            {
                MessageBox.Show("You win! Click OK then click ➡️ ", "GOODJOB!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button11.Enabled = true;
            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            label3.Text = l;
            button8.Enabled = false;
            score++;
            label1.Text = "Score: " + score;

            canswer++;

            if (canswer == 5)
            {
                MessageBox.Show("You win! Click OK then click ➡️ ", "GOODJOB!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button11.Enabled = true;
            }
        }

        private void button11_Click_2(object sender, EventArgs e)
        {

            new level3_easy_().Show();
            this.Hide();
        }

        private void label7_Click_1(object sender, EventArgs e)
        {
            Form2.score = score;
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
    }
}
