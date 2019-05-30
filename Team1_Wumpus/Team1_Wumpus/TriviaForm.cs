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

        public Trivia question { get; set; }



        public Trivia GetQuestion()
        {
            //recycles questions
            index++;
            if (index >= TriviaQuestions.Count) index = 0;
            return TriviaQuestions[index];
        }


        private void next_Click(object sender, EventArgs e)
        {
            //makes the correct/incorrect label invisible
            labelCorrectIncorrect.Visible = false;
            Trivia question = GetQuestion();
            labelQuestion.Text = question.Question;
            //sets button texts to the values
            buttonAnswer1.Text = question.Answer1;
            buttonAnswer2.Text = question.Answer2;
            buttonAnswer3.Text = question.Answer3;
        }

        private void check_Click(object sender, EventArgs e)
        {
            checkAnswer();
        }

        private void checkAnswer()
        {
            //checks answer
            if (noButtonChecked.Checked)
            {
                MessageBox.Show("Please select an answer", "Error");
            }
            else
            {
                labelCorrectIncorrect.Visible = true;
                if (index == 0 || index == 4 || index == 11 || index == 13)
                { 
                    if (buttonAnswer1.Checked)
                    {
                        labelCorrectIncorrect.Text = "Correct";
                    }
                    else
                    {
                        labelCorrectIncorrect.Text = "Incorrect";
                    }
                }
                else if (index == 1 || index == 6 || index == 8 || index == 13)
                {
                    if (buttonAnswer2.Checked)
                    {
                        labelCorrectIncorrect.Text = "Correct";
                    }
                    else
                    {
                        labelCorrectIncorrect.Text = "Incorrect";
                    }
                }
                else if (index == 2 || index == 3 || index == 5 || index == 7 || index == 9 || index == 10 || index == 14)
                {
                    if (buttonAnswer3.Checked)
                    {
                        labelCorrectIncorrect.Text = "Correct";
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

        }
    }
}
