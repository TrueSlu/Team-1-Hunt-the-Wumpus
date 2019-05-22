namespace Team1_Wumpus
{
    partial class GameForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.playerInfoBox = new System.Windows.Forms.GroupBox();
            this.playerInfoScoreBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.playerInfoTurnsBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.playerInfoArrowsBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.playerInfoNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.playerInfoCoinsBox = new System.Windows.Forms.TextBox();
            this.availableCaveMoves = new System.Windows.Forms.ListBox();
            this.movementBox = new System.Windows.Forms.GroupBox();
            this.shopBox = new System.Windows.Forms.GroupBox();
            this.buySecret = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.roomNumber = new System.Windows.Forms.TextBox();
            this.playerInfoBox.SuspendLayout();
            this.movementBox.SuspendLayout();
            this.shopBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "Buy Arrow";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(141, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 58);
            this.button2.TabIndex = 1;
            this.button2.Text = "Fire Arrow";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(141, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 61);
            this.button3.TabIndex = 2;
            this.button3.Text = "Move";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Coins";
            // 
            // playerInfoBox
            // 
            this.playerInfoBox.Controls.Add(this.playerInfoScoreBox);
            this.playerInfoBox.Controls.Add(this.label5);
            this.playerInfoBox.Controls.Add(this.playerInfoTurnsBox);
            this.playerInfoBox.Controls.Add(this.label4);
            this.playerInfoBox.Controls.Add(this.playerInfoArrowsBox);
            this.playerInfoBox.Controls.Add(this.label3);
            this.playerInfoBox.Controls.Add(this.playerInfoNameBox);
            this.playerInfoBox.Controls.Add(this.label2);
            this.playerInfoBox.Controls.Add(this.playerInfoCoinsBox);
            this.playerInfoBox.Controls.Add(this.label1);
            this.playerInfoBox.Location = new System.Drawing.Point(12, 12);
            this.playerInfoBox.Name = "playerInfoBox";
            this.playerInfoBox.Size = new System.Drawing.Size(200, 164);
            this.playerInfoBox.TabIndex = 4;
            this.playerInfoBox.TabStop = false;
            this.playerInfoBox.Text = "Player Info";
            // 
            // playerInfoScoreBox
            // 
            this.playerInfoScoreBox.Enabled = false;
            this.playerInfoScoreBox.Location = new System.Drawing.Point(87, 130);
            this.playerInfoScoreBox.Name = "playerInfoScoreBox";
            this.playerInfoScoreBox.Size = new System.Drawing.Size(100, 20);
            this.playerInfoScoreBox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Score";
            // 
            // playerInfoTurnsBox
            // 
            this.playerInfoTurnsBox.Enabled = false;
            this.playerInfoTurnsBox.Location = new System.Drawing.Point(87, 104);
            this.playerInfoTurnsBox.Name = "playerInfoTurnsBox";
            this.playerInfoTurnsBox.Size = new System.Drawing.Size(100, 20);
            this.playerInfoTurnsBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Turns Taken";
            // 
            // playerInfoArrowsBox
            // 
            this.playerInfoArrowsBox.Enabled = false;
            this.playerInfoArrowsBox.Location = new System.Drawing.Point(87, 78);
            this.playerInfoArrowsBox.Name = "playerInfoArrowsBox";
            this.playerInfoArrowsBox.Size = new System.Drawing.Size(100, 20);
            this.playerInfoArrowsBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Arrows";
            // 
            // playerInfoNameBox
            // 
            this.playerInfoNameBox.Enabled = false;
            this.playerInfoNameBox.Location = new System.Drawing.Point(87, 24);
            this.playerInfoNameBox.Name = "playerInfoNameBox";
            this.playerInfoNameBox.Size = new System.Drawing.Size(100, 20);
            this.playerInfoNameBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // playerInfoCoinsBox
            // 
            this.playerInfoCoinsBox.Enabled = false;
            this.playerInfoCoinsBox.Location = new System.Drawing.Point(87, 50);
            this.playerInfoCoinsBox.Name = "playerInfoCoinsBox";
            this.playerInfoCoinsBox.Size = new System.Drawing.Size(100, 20);
            this.playerInfoCoinsBox.TabIndex = 5;
            // 
            // availableCaveMoves
            // 
            this.availableCaveMoves.FormattingEnabled = true;
            this.availableCaveMoves.Location = new System.Drawing.Point(15, 19);
            this.availableCaveMoves.Name = "availableCaveMoves";
            this.availableCaveMoves.Size = new System.Drawing.Size(120, 134);
            this.availableCaveMoves.TabIndex = 5;
            // 
            // movementBox
            // 
            this.movementBox.Controls.Add(this.availableCaveMoves);
            this.movementBox.Controls.Add(this.button3);
            this.movementBox.Controls.Add(this.button2);
            this.movementBox.Location = new System.Drawing.Point(218, 12);
            this.movementBox.Name = "movementBox";
            this.movementBox.Size = new System.Drawing.Size(227, 164);
            this.movementBox.TabIndex = 6;
            this.movementBox.TabStop = false;
            this.movementBox.Text = "Hunt! (The Wumpus)";
            // 
            // shopBox
            // 
            this.shopBox.Controls.Add(this.buySecret);
            this.shopBox.Controls.Add(this.button1);
            this.shopBox.Location = new System.Drawing.Point(451, 12);
            this.shopBox.Name = "shopBox";
            this.shopBox.Size = new System.Drawing.Size(112, 164);
            this.shopBox.TabIndex = 0;
            this.shopBox.TabStop = false;
            this.shopBox.Text = "Shop";
            // 
            // buySecret
            // 
            this.buySecret.Location = new System.Drawing.Point(19, 84);
            this.buySecret.Name = "buySecret";
            this.buySecret.Size = new System.Drawing.Size(75, 58);
            this.buySecret.TabIndex = 1;
            this.buySecret.Text = "Buy Secret";
            this.buySecret.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(135, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Room Number:";
            // 
            // roomNumber
            // 
            this.roomNumber.Location = new System.Drawing.Point(233, 218);
            this.roomNumber.Name = "roomNumber";
            this.roomNumber.Size = new System.Drawing.Size(100, 20);
            this.roomNumber.TabIndex = 8;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 288);
            this.Controls.Add(this.roomNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.shopBox);
            this.Controls.Add(this.movementBox);
            this.Controls.Add(this.playerInfoBox);
            this.Name = "GameForm";
            this.Text = "Hunt That Wumpus";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.playerInfoBox.ResumeLayout(false);
            this.playerInfoBox.PerformLayout();
            this.movementBox.ResumeLayout(false);
            this.shopBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox playerInfoBox;
        private System.Windows.Forms.TextBox playerInfoCoinsBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox playerInfoNameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox playerInfoScoreBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox playerInfoTurnsBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox playerInfoArrowsBox;
        private System.Windows.Forms.ListBox availableCaveMoves;
        private System.Windows.Forms.GroupBox movementBox;
        private System.Windows.Forms.GroupBox shopBox;
        private System.Windows.Forms.Button buySecret;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox roomNumber;
    }
}