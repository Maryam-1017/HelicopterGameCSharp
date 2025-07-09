using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HelicopterGame
{
    public partial class Form1 : Form
    {
        SoundPlayer bgMusic = new SoundPlayer("bgMusic.wav");
        SoundPlayer crashSound = new SoundPlayer("Explosion.wav");

        bool up, down;
        int score;
        int highScore = 0;
        string highScoreFile = "highscore.txt";
        private Panel pnlStartScreen = new Panel();
        private Label lblStartText = new Label();
        public Form1()
        {

            
            InitializeComponent();
            if (File.Exists(highScoreFile))
            {
                int.TryParse(File.ReadAllText(highScoreFile), out highScore);
            }
            lblHighScore.Text = "High Score: " + highScore;
            lblover.Visible = false;

            // Set up Start Panel
            pnlStartScreen.Dock = DockStyle.Fill;
            pnlStartScreen.BackColor = Color.Black;
            pnlStartScreen.Click += StartGameOnClick;

            // Add label to panel
            lblStartText.Text = "Click Anywhere to Start";
            lblStartText.Font = new Font("Arial", 24, FontStyle.Bold);
            lblStartText.ForeColor = Color.White;
            lblStartText.AutoSize = false;
            lblStartText.TextAlign = ContentAlignment.MiddleCenter;
            lblStartText.Dock = DockStyle.Fill;
            lblStartText.Click += StartGameOnClick;

            // Add label to panel, panel to form
            pnlStartScreen.Controls.Add(lblStartText);
            this.Controls.Add(pnlStartScreen);
            pnlStartScreen.BringToFront();
            lblRestart.Visible = false;

            // Stop the game at start
            timer1.Stop();

        }
       

        private void StartGameOnClick(object sender, EventArgs e)
        {
            pnlStartScreen.Visible = false;
            score = 0;
            lblScore.Text = "Score: 0";
            lblHighScore.Text = "High Score: " + highScore;
            lblover.Visible = false;
            try
            {
                bgMusic.PlayLooping();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error playing sound: " + ex.Message);
            }

            timer1.Start();
        }


        void pillar_move()
        {
            foreach (Control x in this.Controls)
            {
                if(x is PictureBox && x.Tag=="pillar")
                {
                    x.Left -= 5;
                    if(x.Left<-350)
                    {
                        x.Left = 700;
                    }
                }
            }
        }

        void smoke_move()
        {
            PictureBox smoke = new PictureBox();
            smoke.BackColor = System.Drawing.Color.Aqua;
            smoke.Height = 3;
            smoke.Width = 8;
            smoke.Top = Player.Top + Player.Height / 2;
            smoke.Left = Player.Left + Player.Width - 35;
            smoke.Tag = "Smoke";
            this.Controls.Add(smoke);
            foreach (Control x in this.Controls)
            {
                if(x is PictureBox && x.Tag=="Smoke")
                {
                    x.Left -= 10;
                    if(x.Left<0)
                    {
                        this.Controls.Remove(x);
                        x.Dispose();
                    }
                }
            }
        }

        void Player_move()
        {
            if (up)
            {
                Player.Top -= 5; 
            }
            else if (down)
            {
                Player.Top += 3;
            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                up = false;
                down = true;
            }
        }

        
        void enemy_move()
        {
            Random rand = new Random();
            int x;
            foreach (Control j in this.Controls)
            {
                if (j is PictureBox && j.Tag == "enemy")
                {
                    j.Left -= 5;
                    if(j.Left<0)
                    {

                        x=rand.Next(80,300);
                        j.Location = new Point(800,x);
                        score++;
                        lblScore.Text = "Score: " + score;

                    }
                }
            }
        }
        void Game_results()
        {
            foreach(Control x in this.Controls)
            {
                if(x is PictureBox && x.Tag=="pillar")
                {
                    foreach(Control j in this.Controls)
                    {
                        if(j is PictureBox && j.Tag=="enemy")
                        {
                            if (Player.Bounds.IntersectsWith(x.Bounds) || Player.Bounds.IntersectsWith(j.Bounds))
                            {
                                Player.Image = Properties.Resources.cabine;
                                bgMusic.Stop();
                                crashSound.Play();
                                lblover.Visible = true;
                                timer1.Stop();
                                lblRestart.Visible = true;
                               


                                //High Score Logic
                                if (score > highScore)
                                {
                                    highScore = score;
                                    File.WriteAllText(highScoreFile, highScore.ToString());
                                    MessageBox.Show("New High Score: " + highScore, "Congratulations!");
                                }
                            }
                        }
                    }
                }
            }


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Space)
            {
                up = true;
                down = false;
            }

        }

        private void lblover_Click(object sender, EventArgs e)
        {

        }
        
        private void label3_Click(object sender, EventArgs e)
        {
           
            score = 0;
            lblScore.Text = "Score: 0";
            lblHighScore.Text = "High Score: " + highScore;
            lblover.Visible = false;
            lblRestart.Visible = false;
            Player.Top = this.ClientSize.Height / 2; // reset player position
            Player.Image = Properties.Resources.helicopter_1; 

           
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "pillar")
                {
                    x.Left = 700 + new Random().Next(0, 200);
                }
                if (x is PictureBox && x.Tag == "enemy")
                {
                    x.Left = 800;
                    x.Top = new Random().Next(80, 300);
                }
            }

            

            List<Control> toRemove = new List<Control>();
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "Smoke")
                {
                    toRemove.Add(x);
                }
            }
            foreach (Control x in toRemove)
            {
                this.Controls.Remove(x);
                x.Dispose();
            }

            // Start game
     
                bgMusic.PlayLooping();
         

            timer1.Start();
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            Player_move();
            pillar_move();
            enemy_move();
            smoke_move();
            Game_results();
        }
    }
}
