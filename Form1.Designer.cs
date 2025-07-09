namespace HelicopterGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblover = new System.Windows.Forms.Label();
            this.lblHighScore = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblRestart = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(514, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Green;
            this.lblScore.Font = new System.Drawing.Font("Imprint MT Shadow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblScore.Location = new System.Drawing.Point(713, 509);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(148, 42);
            this.lblScore.TabIndex = 11;
            this.lblScore.Text = "Score: 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "label2";
            // 
            // lblover
            // 
            this.lblover.AutoSize = true;
            this.lblover.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblover.Font = new System.Drawing.Font("Imprint MT Shadow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblover.ForeColor = System.Drawing.Color.Transparent;
            this.lblover.Location = new System.Drawing.Point(269, 236);
            this.lblover.Name = "lblover";
            this.lblover.Size = new System.Drawing.Size(413, 87);
            this.lblover.TabIndex = 13;
            this.lblover.Text = "Game-Over";
            this.lblover.Click += new System.EventHandler(this.lblover_Click);
            // 
            // lblHighScore
            // 
            this.lblHighScore.AutoSize = true;
            this.lblHighScore.BackColor = System.Drawing.Color.Green;
            this.lblHighScore.Font = new System.Drawing.Font("Imprint MT Shadow", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHighScore.Location = new System.Drawing.Point(12, 509);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(233, 38);
            this.lblHighScore.TabIndex = 14;
            this.lblHighScore.Text = "High Score:  0 ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Green;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 506);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(934, 50);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "pillar";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Green;
            this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox5.Location = new System.Drawing.Point(0, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(934, 53);
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "pillar";
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.Image = global::HelicopterGame.Properties.Resources.helicopter_1;
            this.Player.Location = new System.Drawing.Point(167, 289);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(96, 32);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::HelicopterGame.Properties.Resources.moss_obstacle_2;
            this.pictureBox2.Location = new System.Drawing.Point(708, 76);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(91, 161);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "enemy";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::HelicopterGame.Properties.Resources.moss_obstacle_1;
            this.pictureBox3.Location = new System.Drawing.Point(113, 119);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(78, 132);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "enemy";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::HelicopterGame.Properties.Resources.moss_tile;
            this.pictureBox4.Location = new System.Drawing.Point(427, 377);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 98);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "enemy";
            // 
            // lblRestart
            // 
            this.lblRestart.AutoSize = true;
            this.lblRestart.Font = new System.Drawing.Font("Imprint MT Shadow", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestart.ForeColor = System.Drawing.Color.White;
            this.lblRestart.Location = new System.Drawing.Point(322, 388);
            this.lblRestart.Name = "lblRestart";
            this.lblRestart.Size = new System.Drawing.Size(315, 38);
            this.lblRestart.TabIndex = 15;
            this.lblRestart.Text = "Click here to Restart";
            this.lblRestart.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(934, 556);
            this.Controls.Add(this.lblRestart);
            this.Controls.Add(this.lblHighScore);
            this.Controls.Add(this.lblover);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HelicopterGame";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblover;
        private System.Windows.Forms.Label lblHighScore;
        private System.Windows.Forms.Label lblRestart;
    }
}

