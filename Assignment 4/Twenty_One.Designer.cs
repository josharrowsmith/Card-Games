namespace Assignment_4 {
    partial class Twenty_One {
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.busted1 = new System.Windows.Forms.Label();
            this.house = new System.Windows.Forms.Label();
            this.hpoints = new System.Windows.Forms.Label();
            this.hwon = new System.Windows.Forms.Label();
            this.busted2 = new System.Windows.Forms.Label();
            this.player = new System.Windows.Forms.Label();
            this.ppoints = new System.Windows.Forms.Label();
            this.pwon = new System.Windows.Forms.Label();
            this.deal = new System.Windows.Forms.Button();
            this.hit = new System.Windows.Forms.Button();
            this.stand = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.endScoreH = new System.Windows.Forms.Label();
            this.endScoreP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(22, 65);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(576, 96);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 8;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(22, 212);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(576, 96);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // busted1
            // 
            this.busted1.AutoSize = true;
            this.busted1.ForeColor = System.Drawing.Color.Red;
            this.busted1.Location = new System.Drawing.Point(91, 18);
            this.busted1.Name = "busted1";
            this.busted1.Size = new System.Drawing.Size(50, 16);
            this.busted1.TabIndex = 2;
            this.busted1.Text = "Busted";
            this.busted1.Visible = false;
            // 
            // house
            // 
            this.house.AutoSize = true;
            this.house.Location = new System.Drawing.Point(247, 27);
            this.house.Name = "house";
            this.house.Size = new System.Drawing.Size(47, 16);
            this.house.TabIndex = 3;
            this.house.Text = "dealer";
            // 
            // hpoints
            // 
            this.hpoints.AutoSize = true;
            this.hpoints.Location = new System.Drawing.Point(386, 27);
            this.hpoints.Name = "hpoints";
            this.hpoints.Size = new System.Drawing.Size(45, 16);
            this.hpoints.TabIndex = 4;
            this.hpoints.Text = "Points";
            // 
            // hwon
            // 
            this.hwon.AutoSize = true;
            this.hwon.Location = new System.Drawing.Point(489, 27);
            this.hwon.Name = "hwon";
            this.hwon.Size = new System.Drawing.Size(72, 16);
            this.hwon.TabIndex = 5;
            this.hwon.Text = "Game won";
            // 
            // busted2
            // 
            this.busted2.AutoSize = true;
            this.busted2.ForeColor = System.Drawing.Color.Red;
            this.busted2.Location = new System.Drawing.Point(91, 329);
            this.busted2.Name = "busted2";
            this.busted2.Size = new System.Drawing.Size(50, 16);
            this.busted2.TabIndex = 6;
            this.busted2.Text = "Busted";
            this.busted2.Visible = false;
            // 
            // player
            // 
            this.player.AutoSize = true;
            this.player.Location = new System.Drawing.Point(248, 329);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(46, 16);
            this.player.TabIndex = 7;
            this.player.Text = "player";
            // 
            // ppoints
            // 
            this.ppoints.AutoSize = true;
            this.ppoints.Location = new System.Drawing.Point(386, 329);
            this.ppoints.Name = "ppoints";
            this.ppoints.Size = new System.Drawing.Size(45, 16);
            this.ppoints.TabIndex = 8;
            this.ppoints.Text = "Points";
            // 
            // pwon
            // 
            this.pwon.AutoSize = true;
            this.pwon.Location = new System.Drawing.Point(489, 329);
            this.pwon.Name = "pwon";
            this.pwon.Size = new System.Drawing.Size(72, 16);
            this.pwon.TabIndex = 9;
            this.pwon.Text = "Game won";
            // 
            // deal
            // 
            this.deal.Location = new System.Drawing.Point(55, 378);
            this.deal.Name = "deal";
            this.deal.Size = new System.Drawing.Size(75, 23);
            this.deal.TabIndex = 10;
            this.deal.Text = "deal";
            this.deal.UseVisualStyleBackColor = true;
            this.deal.Click += new System.EventHandler(this.button1_Click);
            // 
            // hit
            // 
            this.hit.Enabled = false;
            this.hit.Location = new System.Drawing.Point(194, 378);
            this.hit.Name = "hit";
            this.hit.Size = new System.Drawing.Size(75, 23);
            this.hit.TabIndex = 11;
            this.hit.Text = "hit";
            this.hit.UseVisualStyleBackColor = true;
            this.hit.Click += new System.EventHandler(this.button2_Click);
            // 
            // stand
            // 
            this.stand.Enabled = false;
            this.stand.Location = new System.Drawing.Point(356, 378);
            this.stand.Name = "stand";
            this.stand.Size = new System.Drawing.Size(75, 23);
            this.stand.TabIndex = 12;
            this.stand.Text = "stand";
            this.stand.UseVisualStyleBackColor = true;
            this.stand.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(486, 378);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "Cancel";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(523, 378);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 14;
            this.button5.Text = "test";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            // 
            // endScoreH
            // 
            this.endScoreH.AutoSize = true;
            this.endScoreH.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.endScoreH.Location = new System.Drawing.Point(570, 27);
            this.endScoreH.Name = "endScoreH";
            this.endScoreH.Size = new System.Drawing.Size(15, 16);
            this.endScoreH.TabIndex = 15;
            this.endScoreH.Text = "0";
            // 
            // endScoreP
            // 
            this.endScoreP.AutoSize = true;
            this.endScoreP.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.endScoreP.Location = new System.Drawing.Point(570, 329);
            this.endScoreP.Name = "endScoreP";
            this.endScoreP.Size = new System.Drawing.Size(15, 16);
            this.endScoreP.TabIndex = 16;
            this.endScoreP.Text = "0";
            // 
            // Twenty_One
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 413);
            this.Controls.Add(this.endScoreP);
            this.Controls.Add(this.endScoreH);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.stand);
            this.Controls.Add(this.hit);
            this.Controls.Add(this.deal);
            this.Controls.Add(this.pwon);
            this.Controls.Add(this.ppoints);
            this.Controls.Add(this.player);
            this.Controls.Add(this.busted2);
            this.Controls.Add(this.hwon);
            this.Controls.Add(this.hpoints);
            this.Controls.Add(this.house);
            this.Controls.Add(this.busted1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Twenty_One";
            this.Text = "Twenty_One";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label busted1;
        private System.Windows.Forms.Label house;
        private System.Windows.Forms.Label hpoints;
        private System.Windows.Forms.Label hwon;
        private System.Windows.Forms.Label busted2;
        private System.Windows.Forms.Label player;
        private System.Windows.Forms.Label ppoints;
        private System.Windows.Forms.Label pwon;
        private System.Windows.Forms.Button deal;
        private System.Windows.Forms.Button hit;
        private System.Windows.Forms.Button stand;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label endScoreH;
        private System.Windows.Forms.Label endScoreP;
    }
}