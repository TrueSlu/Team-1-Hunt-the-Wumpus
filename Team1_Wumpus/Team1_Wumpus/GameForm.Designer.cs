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
            this.buyArrowButtonClick = new System.Windows.Forms.Button();
            this.fireArrowButtonClick = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.playerInfoBox = new System.Windows.Forms.GroupBox();
            this.playerInfoTurnsBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.playerInfoArrowsBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.playerInfoNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.playerInfoCoinsBox = new System.Windows.Forms.TextBox();
            this.availableCaveMoves = new System.Windows.Forms.ListBox();
            this.movementBox = new System.Windows.Forms.GroupBox();
            this.movePlayerButton = new System.Windows.Forms.Button();
            this.shopBox = new System.Windows.Forms.GroupBox();
            this.buySecretButtonClick = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.roomNumber = new System.Windows.Forms.TextBox();
            this.WumpusLabel = new System.Windows.Forms.Label();
            this.BatsLabel = new System.Windows.Forms.Label();
            this.PitsLabel = new System.Windows.Forms.Label();
            this.WumpusBox = new System.Windows.Forms.TextBox();
            this.PitsBox = new System.Windows.Forms.TextBox();
            this.BatsBox = new System.Windows.Forms.TextBox();
            this.playerInfoBox.SuspendLayout();
            this.movementBox.SuspendLayout();
            this.shopBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // buyArrowButtonClick
            // 
            this.buyArrowButtonClick.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyArrowButtonClick.Location = new System.Drawing.Point(28, 71);
            this.buyArrowButtonClick.Margin = new System.Windows.Forms.Padding(4);
            this.buyArrowButtonClick.Name = "buyArrowButtonClick";
            this.buyArrowButtonClick.Size = new System.Drawing.Size(112, 84);
            this.buyArrowButtonClick.TabIndex = 0;
            this.buyArrowButtonClick.Text = "Buy Arrow  (1 gold)";
            this.buyArrowButtonClick.UseVisualStyleBackColor = true;
            this.buyArrowButtonClick.Click += new System.EventHandler(this.buyArrowButtonClick_Click);
            // 
            // fireArrowButtonClick
            // 
            this.fireArrowButtonClick.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fireArrowButtonClick.Location = new System.Drawing.Point(204, 75);
            this.fireArrowButtonClick.Margin = new System.Windows.Forms.Padding(4);
            this.fireArrowButtonClick.Name = "fireArrowButtonClick";
            this.fireArrowButtonClick.Size = new System.Drawing.Size(112, 84);
            this.fireArrowButtonClick.TabIndex = 1;
            this.fireArrowButtonClick.Text = "Fire Arrow";
            this.fireArrowButtonClick.UseVisualStyleBackColor = true;
            this.fireArrowButtonClick.Click += new System.EventHandler(this.fireArrowButtonClick_Click);
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
            this.playerInfoBox.Controls.Add(this.playerInfoTurnsBox);
            this.playerInfoBox.Controls.Add(this.label4);
            this.playerInfoBox.Controls.Add(this.playerInfoArrowsBox);
            this.playerInfoBox.Controls.Add(this.label3);
            this.playerInfoBox.Controls.Add(this.playerInfoNameBox);
            this.playerInfoBox.Controls.Add(this.label2);
            this.playerInfoBox.Controls.Add(this.playerInfoCoinsBox);
            this.playerInfoBox.Controls.Add(this.label1);
            this.playerInfoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerInfoBox.Location = new System.Drawing.Point(18, 18);
            this.playerInfoBox.Margin = new System.Windows.Forms.Padding(4);
            this.playerInfoBox.Name = "playerInfoBox";
            this.playerInfoBox.Padding = new System.Windows.Forms.Padding(4);
            this.playerInfoBox.Size = new System.Drawing.Size(376, 297);
            this.playerInfoBox.TabIndex = 4;
            this.playerInfoBox.TabStop = false;
            this.playerInfoBox.Text = "Player Info";
            // 
            // playerInfoTurnsBox
            // 
            this.playerInfoTurnsBox.Enabled = false;
            this.playerInfoTurnsBox.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerInfoTurnsBox.Location = new System.Drawing.Point(190, 201);
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
            this.movementBox.Controls.Add(this.movePlayerButton);
            this.movementBox.Controls.Add(this.availableCaveMoves);
            this.movementBox.Controls.Add(this.button3);
            this.movementBox.Controls.Add(this.fireArrowButtonClick);
            this.movementBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movementBox.Location = new System.Drawing.Point(404, 18);
            this.movementBox.Margin = new System.Windows.Forms.Padding(4);
            this.movementBox.Name = "movementBox";
            this.movementBox.Padding = new System.Windows.Forms.Padding(4);
            this.movementBox.Size = new System.Drawing.Size(340, 297);
            this.movementBox.TabIndex = 6;
            this.movementBox.TabStop = false;
            this.movementBox.Text = "Hunt! (The Wumpus)";
            // 
            // movePlayerButton
            // 
            this.movePlayerButton.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movePlayerButton.Location = new System.Drawing.Point(204, 177);
            this.movePlayerButton.Margin = new System.Windows.Forms.Padding(4);
            this.movePlayerButton.Name = "movePlayerButton";
            this.movePlayerButton.Size = new System.Drawing.Size(112, 84);
            this.movePlayerButton.TabIndex = 6;
            this.movePlayerButton.Text = "Move Here";
            this.movePlayerButton.UseVisualStyleBackColor = true;
            this.movePlayerButton.Click += new System.EventHandler(this.movePlayerButton_Click);
            // 
            // shopBox
            // 
            this.shopBox.Controls.Add(this.buySecretButtonClick);
            this.shopBox.Controls.Add(this.buyArrowButtonClick);
            this.shopBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shopBox.Location = new System.Drawing.Point(752, 18);
            this.shopBox.Margin = new System.Windows.Forms.Padding(4);
            this.shopBox.Name = "shopBox";
            this.shopBox.Padding = new System.Windows.Forms.Padding(4);
            this.shopBox.Size = new System.Drawing.Size(168, 297);
            this.shopBox.TabIndex = 0;
            this.shopBox.TabStop = false;
            this.shopBox.Text = "Shop";
            // 
            // buySecretButtonClick
            // 
            this.buySecretButtonClick.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buySecretButtonClick.Location = new System.Drawing.Point(28, 177);
            this.buySecretButtonClick.Margin = new System.Windows.Forms.Padding(4);
            this.buySecretButtonClick.Name = "buySecretButtonClick";
            this.buySecretButtonClick.Size = new System.Drawing.Size(112, 84);
            this.buySecretButtonClick.TabIndex = 1;
            this.buySecretButtonClick.Text = "Buy Secret (2 gold)";
            this.buySecretButtonClick.UseVisualStyleBackColor = true;
            this.buySecretButtonClick.Click += new System.EventHandler(this.buySecretButtonClick_Click);
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
            this.roomNumber.Enabled = false;
            this.roomNumber.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomNumber.Location = new System.Drawing.Point(368, 357);
            this.roomNumber.Margin = new System.Windows.Forms.Padding(4);
            this.roomNumber.Name = "roomNumber";
            this.roomNumber.Size = new System.Drawing.Size(148, 28);
            this.roomNumber.TabIndex = 8;
            // 
            // WumpusLabel
            // 
            this.WumpusLabel.AutoSize = true;
            this.WumpusLabel.Location = new System.Drawing.Point(29, 410);
            this.WumpusLabel.Name = "WumpusLabel";
            this.WumpusLabel.Size = new System.Drawing.Size(72, 18);
            this.WumpusLabel.TabIndex = 9;
            this.WumpusLabel.Text = "Wumpus:";
            this.WumpusLabel.Visible = false;
            // 
            // BatsLabel
            // 
            this.BatsLabel.AutoSize = true;
            this.BatsLabel.Location = new System.Drawing.Point(222, 410);
            this.BatsLabel.Name = "BatsLabel";
            this.BatsLabel.Size = new System.Drawing.Size(42, 18);
            this.BatsLabel.TabIndex = 10;
            this.BatsLabel.Text = "Bats:";
            this.BatsLabel.Visible = false;
            // 
            // PitsLabel
            // 
            this.PitsLabel.AutoSize = true;
            this.PitsLabel.Location = new System.Drawing.Point(385, 410);
            this.PitsLabel.Name = "PitsLabel";
            this.PitsLabel.Size = new System.Drawing.Size(37, 18);
            this.PitsLabel.TabIndex = 11;
            this.PitsLabel.Text = "Pits:";
            this.PitsLabel.Visible = false;
            // 
            // WumpusBox
            // 
            this.WumpusBox.Location = new System.Drawing.Point(107, 407);
            this.WumpusBox.Name = "WumpusBox";
            this.WumpusBox.Size = new System.Drawing.Size(100, 24);
            this.WumpusBox.TabIndex = 12;
            this.WumpusBox.Visible = false;
            // 
            // PitsBox
            // 
            this.PitsBox.Location = new System.Drawing.Point(428, 410);
            this.PitsBox.Name = "PitsBox";
            this.PitsBox.Size = new System.Drawing.Size(100, 24);
            this.PitsBox.TabIndex = 13;
            this.PitsBox.Visible = false;
            // 
            // BatsBox
            // 
            this.BatsBox.Location = new System.Drawing.Point(270, 407);
            this.BatsBox.Name = "BatsBox";
            this.BatsBox.Size = new System.Drawing.Size(100, 24);
            this.BatsBox.TabIndex = 14;
            this.BatsBox.Visible = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 460);
            this.Controls.Add(this.BatsBox);
            this.Controls.Add(this.PitsBox);
            this.Controls.Add(this.WumpusBox);
            this.Controls.Add(this.PitsLabel);
            this.Controls.Add(this.BatsLabel);
            this.Controls.Add(this.WumpusLabel);
            this.Controls.Add(this.roomNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.shopBox);
            this.Controls.Add(this.movementBox);
            this.Controls.Add(this.playerInfoBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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

        private System.Windows.Forms.Button buyArrowButtonClick;
        private System.Windows.Forms.Button fireArrowButtonClick;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox playerInfoBox;
        private System.Windows.Forms.TextBox playerInfoCoinsBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox playerInfoNameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox playerInfoTurnsBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox playerInfoArrowsBox;
        private System.Windows.Forms.ListBox availableCaveMoves;
        private System.Windows.Forms.GroupBox movementBox;
        private System.Windows.Forms.GroupBox shopBox;
        private System.Windows.Forms.Button buySecretButtonClick;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox roomNumber;
        private System.Windows.Forms.Button movePlayerButton;
        private System.Windows.Forms.Label WumpusLabel;
        private System.Windows.Forms.Label BatsLabel;
        private System.Windows.Forms.Label PitsLabel;
        private System.Windows.Forms.TextBox WumpusBox;
        private System.Windows.Forms.TextBox PitsBox;
        private System.Windows.Forms.TextBox BatsBox;
    }
}