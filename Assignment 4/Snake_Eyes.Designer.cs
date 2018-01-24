namespace Assignment_4 {
    partial class Snake_Eyes {
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
            this.rollDice = new System.Windows.Forms.Button();
            this.playAgain = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.dummyLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.playerScore = new System.Windows.Forms.Label();
            this.houseScore = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(122, 148);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(398, 148);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // rollDice
            // 
            this.rollDice.Location = new System.Drawing.Point(247, 175);
            this.rollDice.Name = "rollDice";
            this.rollDice.Size = new System.Drawing.Size(75, 23);
            this.rollDice.TabIndex = 2;
            this.rollDice.Text = "Roll dice";
            this.rollDice.UseVisualStyleBackColor = true;
            this.rollDice.Click += new System.EventHandler(this.roldice);
            // 
            // playAgain
            // 
            this.playAgain.Enabled = false;
            this.playAgain.Location = new System.Drawing.Point(108, 379);
            this.playAgain.Name = "playAgain";
            this.playAgain.Size = new System.Drawing.Size(96, 50);
            this.playAgain.TabIndex = 3;
            this.playAgain.Text = "Play Agian";
            this.playAgain.UseVisualStyleBackColor = true;
            this.playAgain.Click += new System.EventHandler(this.playagain);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(368, 379);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(90, 48);
            this.Cancel.TabIndex = 4;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.cancel);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(218, 65);
            this.result.Name = "result";
            this.result.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.result.Size = new System.Drawing.Size(98, 26);
            this.result.TabIndex = 5;
            this.result.Text = "First Roll";
            // 
            // dummyLabel
            // 
            this.dummyLabel.AutoSize = true;
            this.dummyLabel.Location = new System.Drawing.Point(236, 261);
            this.dummyLabel.Name = "dummyLabel";
            this.dummyLabel.Size = new System.Drawing.Size(83, 16);
            this.dummyLabel.TabIndex = 6;
            this.dummyLabel.Text = "Dummy Text";
            this.dummyLabel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Player Score";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(370, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "House score";
            // 
            // playerScore
            // 
            this.playerScore.AutoSize = true;
            this.playerScore.Location = new System.Drawing.Point(188, 327);
            this.playerScore.Name = "playerScore";
            this.playerScore.Size = new System.Drawing.Size(15, 16);
            this.playerScore.TabIndex = 9;
            this.playerScore.Text = "0";
            // 
            // houseScore
            // 
            this.houseScore.AutoSize = true;
            this.houseScore.Location = new System.Drawing.Point(464, 327);
            this.houseScore.Name = "houseScore";
            this.houseScore.Size = new System.Drawing.Size(15, 16);
            this.houseScore.TabIndex = 10;
            this.houseScore.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Snake_Eyes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 484);
            this.Controls.Add(this.houseScore);
            this.Controls.Add(this.playerScore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dummyLabel);
            this.Controls.Add(this.result);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.playAgain);
            this.Controls.Add(this.rollDice);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Snake_Eyes";
            this.Text = "Snake_Eyes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button rollDice;
        private System.Windows.Forms.Button playAgain;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label dummyLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label playerScore;
        private System.Windows.Forms.Label houseScore;
        private System.Windows.Forms.Timer timer1;
    }
}