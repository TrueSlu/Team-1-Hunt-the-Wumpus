namespace Team1_Wumpus
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
            this.label1 = new System.Windows.Forms.Label();
            this.startGame = new System.Windows.Forms.Button();
            this.highScores = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.caveSystemBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hunt the Wumpus";
            // 
            // startGame
            // 
            this.startGame.Location = new System.Drawing.Point(277, 256);
            this.startGame.Name = "startGame";
            this.startGame.Size = new System.Drawing.Size(75, 58);
            this.startGame.TabIndex = 1;
            this.startGame.Text = "Start Game";
            this.startGame.UseVisualStyleBackColor = true;
            this.startGame.Click += new System.EventHandler(this.Start_Game_Button);
            // 
            // highScores
            // 
            this.highScores.Location = new System.Drawing.Point(480, 256);
            this.highScores.Name = "highScores";
            this.highScores.Size = new System.Drawing.Size(75, 58);
            this.highScores.TabIndex = 2;
            this.highScores.Text = "View High Scores";
            this.highScores.UseVisualStyleBackColor = true;
            this.highScores.Click += new System.EventHandler(this.Show_High_Scores_Button);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(381, 89);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 3;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(317, 96);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Name";
            // 
            // caveSystemBox
            // 
            this.caveSystemBox.FormattingEnabled = true;
            this.caveSystemBox.Location = new System.Drawing.Point(320, 132);
            this.caveSystemBox.Name = "caveSystemBox";
            this.caveSystemBox.Size = new System.Drawing.Size(161, 95);
            this.caveSystemBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.caveSystemBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.highScores);
            this.Controls.Add(this.startGame);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Hunt the Wumpus - Team 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startGame;
        private System.Windows.Forms.Button highScores;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.ListBox caveSystemBox;
    }
}

