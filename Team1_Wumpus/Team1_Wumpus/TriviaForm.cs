using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team1_Wumpus
{
    public partial class TriviaForm : System.Windows.Forms.Form
    {

        public List<Trivia> Questions { get; set; }
        public int NumberCorrect { get; set; }
        int index = 0;

        public TriviaForm()
        {
            InitializeComponent();
        }



        private void LoadQuestion()
        {
            //makes the correct/incorrect label invisible
            labelCorrectIncorrect.Visible = false;
            labelQuestion.Text = Questions[index].Question;
            //sets button texts to the values
            buttonAnswer1.Text = Questions[index].Answer1;
            buttonAnswer2.Text = Questions[index].Answer2;
            buttonAnswer3.Text = Questions[index].Answer3;
        }


        private void checkAnswer(Trivia Question)
        {
            //checks answer
            if (!buttonAnswer1.Checked && !buttonAnswer2.Checked && !buttonAnswer3.Checked)
            {
                MessageBox.Show("Please select an answer", "Error");
            }
            else
            {
                labelCorrectIncorrect.Visible = true;
                if (Question.CorrectAnswer == 1)
                { 
                    if (buttonAnswer1.Checked)
                    {
                        labelCorrectIncorrect.Text = "Correct";
                        NumberCorrect++;
                    }
                    else
                    {
                        labelCorrectIncorrect.Text = "Incorrect";
                    }
                }
                else if (Question.CorrectAnswer == 2)
                {
                    if (buttonAnswer2.Checked)
                    {
                        labelCorrectIncorrect.Text = "Correct";
                        NumberCorrect++;
                    }
                    else
                    {
                        labelCorrectIncorrect.Text = "Incorrect";
                    }
                }
                else if (Question.CorrectAnswer == 3)
                {
                    if (buttonAnswer3.Checked)
                    {
                        labelCorrectIncorrect.Text = "Correct";
                        NumberCorrect++;
                    }
                    else
                    {
                        labelCorrectIncorrect.Text = "Incorrect";
                    }
                }
            }
        }

        private void TriviaForm_Load(object sender, EventArgs e)
        {
            LoadQuestion();
        }



        private void next_Click_1(object sender, EventArgs e)
        {
            try
            {
                index++;
                LoadQuestion();
                next.Enabled = false;
                button1.Enabled = true;
            } catch
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkAnswer(Questions[index]);
            button1.Enabled = false;
            next.Enabled = true;
        }
    }
}
