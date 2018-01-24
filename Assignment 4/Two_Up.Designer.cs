namespace Assignment_4 {
    partial class Two_Up {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.playerScore = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.computerScore = new System.Windows.Forms.Label();
            this.throwButton = new System.Windows.Forms.Button();
            this.playAgain = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(67, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 250);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(373, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(250, 250);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(629, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 2;
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Players Score";
            // 
            // playerScore
            // 
            this.playerScore.AutoSize = true;
            this.playerScore.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.playerScore.Location = new System.Drawing.Point(259, 328);
            this.playerScore.Name = "playerScore";
            this.playerScore.Size = new System.Drawing.Size(15, 16);
            this.playerScore.TabIndex = 4;
            this.playerScore.Text = "0";
            this.playerScore.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(370, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Computers Score";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // computerScore
            // 
            this.computerScore.AutoSize = true;
            this.computerScore.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.computerScore.Location = new System.Drawing.Point(493, 328);
            this.computerScore.Name = "computerScore";
            this.computerScore.Size = new System.Drawing.Size(15, 16);
            this.computerScore.TabIndex = 6;
            this.computerScore.Text = "0";
            // 
            // throwButton
            // 
            this.throwButton.Location = new System.Drawing.Point(157, 418);
            this.throwButton.Name = "throwButton";
            this.throwButton.Size = new System.Drawing.Size(97, 23);
            this.throwButton.TabIndex = 7;
            this.throwButton.Text = "Throw Coins";
            this.throwButton.UseVisualStyleBackColor = true;
            this.throwButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // playAgain
            // 
            this.playAgain.Location = new System.Drawing.Point(297, 418);
            this.playAgain.Name = "playAgain";
            this.playAgain.Size = new System.Drawing.Size(92, 23);
            this.playAgain.TabIndex = 8;
            this.playAgain.Text = "Play Again";
            this.playAgain.UseVisualStyleBackColor = true;
            this.playAgain.Visible = false;
            this.playAgain.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(435, 418);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Two_Up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 565);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.playAgain);
            this.Controls.Add(this.throwButton);
            this.Controls.Add(this.computerScore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.playerScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Two_Up";
            this.Text = "Two_Up";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label playerScore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label computerScore;
        private System.Windows.Forms.Button throwButton;
        private System.Windows.Forms.Button playAgain;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer1;
    }
}