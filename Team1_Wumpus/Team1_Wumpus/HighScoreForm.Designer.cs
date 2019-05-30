namespace Team1_Wumpus
{
    partial class FormHighScore
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
            this.labelScore = new System.Windows.Forms.Label();
            this.textBoxScore = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.listBoxScores = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(76, 181);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(35, 13);
            this.labelScore.TabIndex = 13;
            this.labelScore.Text = "Score";
            // 
            // textBoxScore
            // 
            this.textBoxScore.Location = new System.Drawing.Point(117, 178);
            this.textBoxScore.Name = "textBoxScore";
            this.textBoxScore.Size = new System.Drawing.Size(100, 20);
            this.textBoxScore.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cave";
            // 
            // textBoxCave
            // 
            this.textBoxCave.Location = new System.Drawing.Point(117, 121);
            this.textBoxCave.Name = "textBoxCave";
            this.textBoxCave.Size = new System.Drawing.Size(100, 20);
            this.textBoxCave.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(117, 68);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 8;
            // 
            // listBoxScores
            // 
            this.listBoxScores.FormattingEnabled = true;
            this.listBoxScores.Location = new System.Drawing.Point(389, 68);
            this.listBoxScores.Name = "listBoxScores";
            this.listBoxScores.Size = new System.Drawing.Size(234, 264);
            this.listBoxScores.TabIndex = 15;
            this.listBoxScores.SelectedIndexChanged += new System.EventHandler(this.listBoxScores_SelectedIndexChanged);
            // 
            // FormHighScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxScores);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.textBoxScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxName);
            this.Name = "FormHighScore";
            this.Text = "High Scores";
            this.Load += new System.EventHandler(this.FormHighScore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.TextBox textBoxScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ListBox listBoxScores;
    }
}