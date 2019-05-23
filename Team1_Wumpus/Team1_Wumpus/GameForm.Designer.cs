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
            this.label7 = new System.Windows.Forms.Label();
            this.playerInfoBox.SuspendLayout();
            this.movementBox.SuspendLayout();
            this.shopBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(28, 71);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 84);
            this.button1.TabIndex = 0;
            this.button1.Text = "Buy Arrow";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(211, 124);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 84);
            this.button2.TabIndex = 1;
            this.button2.Text = "Fire Arrow";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(0, 356);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 90);
            this.button3.TabIndex = 2;
            this.button3.Text = "Move";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
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
            this.playerInfoBox.Font = new System.Drawing.Font("Old English Text MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerInfoBox.Location = new System.Drawing.Point(18, 18);
            this.playerInfoBox.Margin = new System.Windows.Forms.Padding(4);
            this.playerInfoBox.Name = "playerInfoBox";
            this.playerInfoBox.Padding = new System.Windows.Forms.Padding(4);
            this.playerInfoBox.Size = new System.Drawing.Size(376, 297);
            this.playerInfoBox.TabIndex = 4;
            this.playerInfoBox.TabStop = false;
            this.playerInfoBox.Text = "Player Info";
            // 
            // playerInfoScoreBox
            // 
            this.playerInfoScoreBox.Enabled = false;
            this.playerInfoScoreBox.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerInfoScoreBox.Location = new System.Drawing.Point(187, 249);
            this.playerInfoScoreBox.Margin = new System.Windows.Forms.Padding(4);
            this.playerInfoScoreBox.Name = "playerInfoScoreBox";
            this.playerInfoScoreBox.Size = new System.Drawing.Size(148, 28);
            this.playerInfoScoreBox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 252);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Score";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // playerInfoTurnsBox
            // 
            this.playerInfoTurnsBox.Enabled = false;
            this.playerInfoTurnsBox.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerInfoTurnsBox.Location = new System.Drawing.Point(187, 201);
            this.playerInfoTurnsBox.Margin = new System.Windows.Forms.Padding(4);
            this.playerInfoTurnsBox.Name = "playerInfoTurnsBox";
            this.playerInfoTurnsBox.Size = new System.Drawing.Size(148, 28);
            this.playerInfoTurnsBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 204);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Turns Taken";
            // 
            // playerInfoArrowsBox
            // 
            this.playerInfoArrowsBox.Enabled = false;
            this.playerInfoArrowsBox.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerInfoArrowsBox.Location = new System.Drawing.Point(190, 153);
            this.playerInfoArrowsBox.Margin = new System.Windows.Forms.Padding(4);
            this.playerInfoArrowsBox.Name = "playerInfoArrowsBox";
            this.playerInfoArrowsBox.Size = new System.Drawing.Size(148, 28);
            this.playerInfoArrowsBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Arrows";
            // 
            // playerInfoNameBox
            // 
            this.playerInfoNameBox.Enabled = false;
            this.playerInfoNameBox.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerInfoNameBox.Location = new System.Drawing.Point(190, 51);
            this.playerInfoNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.playerInfoNameBox.Name = "playerInfoNameBox";
            this.playerInfoNameBox.Size = new System.Drawing.Size(148, 28);
            this.playerInfoNameBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // playerInfoCoinsBox
            // 
            this.playerInfoCoinsBox.Enabled = false;
            this.playerInfoCoinsBox.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerInfoCoinsBox.Location = new System.Drawing.Point(190, 100);
            this.playerInfoCoinsBox.Margin = new System.Windows.Forms.Padding(4);
            this.playerInfoCoinsBox.Name = "playerInfoCoinsBox";
            this.playerInfoCoinsBox.Size = new System.Drawing.Size(148, 28);
            this.playerInfoCoinsBox.TabIndex = 5;
            // 
            // availableCaveMoves
            // 
            this.availableCaveMoves.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableCaveMoves.FormattingEnabled = true;
            this.availableCaveMoves.ItemHeight = 20;
            this.availableCaveMoves.Location = new System.Drawing.Point(18, 75);
            this.availableCaveMoves.Margin = new System.Windows.Forms.Padding(4);
            this.availableCaveMoves.Name = "availableCaveMoves";
            this.availableCaveMoves.Size = new System.Drawing.Size(178, 184);
            this.availableCaveMoves.TabIndex = 5;
            // 
            // movementBox
            // 
            this.movementBox.Controls.Add(this.availableCaveMoves);
            this.movementBox.Controls.Add(this.button3);
            this.movementBox.Controls.Add(this.button2);
            this.movementBox.Font = new System.Drawing.Font("Old English Text MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movementBox.Location = new System.Drawing.Point(404, 18);
            this.movementBox.Margin = new System.Windows.Forms.Padding(4);
            this.movementBox.Name = "movementBox";
            this.movementBox.Padding = new System.Windows.Forms.Padding(4);
            this.movementBox.Size = new System.Drawing.Size(340, 297);
            this.movementBox.TabIndex = 6;
            this.movementBox.TabStop = false;
            this.movementBox.Text = "Hunt! (The Wumpus)";
            // 
            // shopBox
            // 
            this.shopBox.Controls.Add(this.buySecret);
            this.shopBox.Controls.Add(this.button1);
            this.shopBox.Font = new System.Drawing.Font("Old English Text MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shopBox.Location = new System.Drawing.Point(752, 18);
            this.shopBox.Margin = new System.Windows.Forms.Padding(4);
            this.shopBox.Name = "shopBox";
            this.shopBox.Padding = new System.Windows.Forms.Padding(4);
            this.shopBox.Size = new System.Drawing.Size(168, 297);
            this.shopBox.TabIndex = 0;
            this.shopBox.TabStop = false;
            this.shopBox.Text = "Shop";
            // 
            // buySecret
            // 
            this.buySecret.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buySecret.Location = new System.Drawing.Point(28, 177);
            this.buySecret.Margin = new System.Windows.Forms.Padding(4);
            this.buySecret.Name = "buySecret";
            this.buySecret.Size = new System.Drawing.Size(112, 84);
            this.buySecret.TabIndex = 1;
            this.buySecret.Text = "Buy Secret";
            this.buySecret.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(221, 357);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Room Number:";
            // 
            // roomNumber
            // 
            this.roomNumber.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomNumber.Location = new System.Drawing.Point(368, 357);
            this.roomNumber.Margin = new System.Windows.Forms.Padding(4);
            this.roomNumber.Name = "roomNumber";
            this.roomNumber.Size = new System.Drawing.Size(148, 28);
            this.roomNumber.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(587, 357);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "messagelabel";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 410);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.roomNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.shopBox);
            this.Controls.Add(this.movementBox);
            this.Controls.Add(this.playerInfoBox);
            this.Font = new System.Drawing.Font("Old English Text MT", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GameForm";
            this.Text = "Hunt the Wumpus";
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
        private System.Windows.Forms.Label label7;
    }
}