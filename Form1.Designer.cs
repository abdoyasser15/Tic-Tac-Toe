namespace Tic_Tac_Toe_Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbTac = new System.Windows.Forms.Label();
            this.lbTurn = new System.Windows.Forms.Label();
            this.lbGameOver = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbProgress = new System.Windows.Forms.Label();
            this.btResartGame = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.btPlayer = new System.Windows.Forms.Button();
            this.btComputer = new System.Windows.Forms.Button();
            this.rdEasy = new System.Windows.Forms.RadioButton();
            this.rdHard = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lbTac
            // 
            this.lbTac.AutoSize = true;
            this.lbTac.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTac.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTac.ForeColor = System.Drawing.Color.White;
            this.lbTac.Location = new System.Drawing.Point(658, 9);
            this.lbTac.Name = "lbTac";
            this.lbTac.Size = new System.Drawing.Size(386, 50);
            this.lbTac.TabIndex = 0;
            this.lbTac.Text = "Tic-Tac-Toe Game";
            // 
            // lbTurn
            // 
            this.lbTurn.AutoSize = true;
            this.lbTurn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTurn.Font = new System.Drawing.Font("Britannic Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTurn.ForeColor = System.Drawing.Color.Yellow;
            this.lbTurn.Location = new System.Drawing.Point(95, 88);
            this.lbTurn.Name = "lbTurn";
            this.lbTurn.Size = new System.Drawing.Size(95, 41);
            this.lbTurn.TabIndex = 1;
            this.lbTurn.Text = "Turn";
            // 
            // lbGameOver
            // 
            this.lbGameOver.AutoSize = true;
            this.lbGameOver.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbGameOver.Font = new System.Drawing.Font("Britannic Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGameOver.ForeColor = System.Drawing.Color.White;
            this.lbGameOver.Location = new System.Drawing.Point(78, 171);
            this.lbGameOver.Name = "lbGameOver";
            this.lbGameOver.Size = new System.Drawing.Size(144, 41);
            this.lbGameOver.TabIndex = 2;
            this.lbGameOver.Text = "Player1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(78, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "Winner";
            // 
            // lbProgress
            // 
            this.lbProgress.AutoSize = true;
            this.lbProgress.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbProgress.Font = new System.Drawing.Font("Britannic Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProgress.ForeColor = System.Drawing.Color.White;
            this.lbProgress.Location = new System.Drawing.Point(47, 337);
            this.lbProgress.Name = "lbProgress";
            this.lbProgress.Size = new System.Drawing.Size(198, 41);
            this.lbProgress.TabIndex = 4;
            this.lbProgress.Text = "InProgress";
            // 
            // btResartGame
            // 
            this.btResartGame.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btResartGame.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btResartGame.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btResartGame.Location = new System.Drawing.Point(42, 420);
            this.btResartGame.Name = "btResartGame";
            this.btResartGame.Size = new System.Drawing.Size(222, 70);
            this.btResartGame.TabIndex = 5;
            this.btResartGame.Text = "Restart Game";
            this.btResartGame.UseVisualStyleBackColor = false;
            this.btResartGame.Click += new System.EventHandler(this.btResartGame_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(504, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 113);
            this.button1.TabIndex = 6;
            this.button1.Tag = "?";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(760, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 113);
            this.button2.TabIndex = 7;
            this.button2.Tag = "?";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(1036, 144);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 113);
            this.button3.TabIndex = 8;
            this.button3.Tag = "?";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(504, 337);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 113);
            this.button4.TabIndex = 9;
            this.button4.Tag = "?";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(760, 337);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(113, 113);
            this.button5.TabIndex = 10;
            this.button5.Tag = "?";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(1036, 337);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(113, 113);
            this.button6.TabIndex = 11;
            this.button6.Tag = "?";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(504, 531);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(113, 113);
            this.button7.TabIndex = 12;
            this.button7.Tag = "?";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.Location = new System.Drawing.Point(760, 531);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(113, 113);
            this.button8.TabIndex = 13;
            this.button8.Tag = "?";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.Location = new System.Drawing.Point(1036, 531);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(113, 113);
            this.button9.TabIndex = 14;
            this.button9.Tag = "?";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button_Click);
            // 
            // btPlayer
            // 
            this.btPlayer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPlayer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btPlayer.Location = new System.Drawing.Point(1281, 171);
            this.btPlayer.Name = "btPlayer";
            this.btPlayer.Size = new System.Drawing.Size(132, 64);
            this.btPlayer.TabIndex = 15;
            this.btPlayer.Text = "Player";
            this.btPlayer.UseVisualStyleBackColor = false;
            this.btPlayer.Click += new System.EventHandler(this.btPlayer_Click);
            // 
            // btComputer
            // 
            this.btComputer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btComputer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btComputer.Location = new System.Drawing.Point(1281, 279);
            this.btComputer.Name = "btComputer";
            this.btComputer.Size = new System.Drawing.Size(132, 64);
            this.btComputer.TabIndex = 16;
            this.btComputer.Text = "Computer";
            this.btComputer.UseVisualStyleBackColor = false;
            this.btComputer.Click += new System.EventHandler(this.btComputer_Click);
            // 
            // rdEasy
            // 
            this.rdEasy.AutoSize = true;
            this.rdEasy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdEasy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdEasy.Location = new System.Drawing.Point(1265, 374);
            this.rdEasy.Name = "rdEasy";
            this.rdEasy.Size = new System.Drawing.Size(67, 24);
            this.rdEasy.TabIndex = 17;
            this.rdEasy.TabStop = true;
            this.rdEasy.Text = "Easy";
            this.rdEasy.UseVisualStyleBackColor = true;
            // 
            // rdHard
            // 
            this.rdHard.AutoSize = true;
            this.rdHard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdHard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdHard.Location = new System.Drawing.Point(1379, 374);
            this.rdHard.Name = "rdHard";
            this.rdHard.Size = new System.Drawing.Size(67, 24);
            this.rdHard.TabIndex = 18;
            this.rdHard.TabStop = true;
            this.rdHard.Text = "Hard";
            this.rdHard.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1500, 768);
            this.Controls.Add(this.rdHard);
            this.Controls.Add(this.rdEasy);
            this.Controls.Add(this.btComputer);
            this.Controls.Add(this.btPlayer);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btResartGame);
            this.Controls.Add(this.lbProgress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbGameOver);
            this.Controls.Add(this.lbTurn);
            this.Controls.Add(this.lbTac);
            this.Name = "Form1";
            this.Text = "Tic-Tac-Toe";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTac;
        private System.Windows.Forms.Label lbTurn;
        private System.Windows.Forms.Label lbGameOver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbProgress;
        private System.Windows.Forms.Button btResartGame;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button btPlayer;
        private System.Windows.Forms.Button btComputer;
        private System.Windows.Forms.RadioButton rdEasy;
        private System.Windows.Forms.RadioButton rdHard;
    }
}

