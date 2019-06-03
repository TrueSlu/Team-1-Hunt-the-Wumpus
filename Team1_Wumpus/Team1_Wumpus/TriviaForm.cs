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



        private void next_Click()
        {
            //makes the correct/incorrect label invisible
            labelCorrectIncorrect.Visible = false;
            labelQuestion.Text = question.Question;
            //sets button texts to the values
            buttonAnswer1.Text = question.Answer1;
            buttonAnswer2.Text = question.Answer2;
            buttonAnswer3.Text = question.Answer3;
        }

        private void check_Click()
        {
            bool correct = checkAnswer(question);
            if (correct)
            {

            } else
            {

            }
        }

        private bool checkAnswer(Trivia Question)
        {
            //checks answer
            if (noButtonChecked.Checked)
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
                        return true;
                    }
                    else
                    {
                        labelCorrectIncorrect.Text = "Incorrect";
                        return false;
                    }
                }
                else if (Question.CorrectAnswer == 2)
                {
                    if (buttonAnswer2.Checked)
                    {
                        labelCorrectIncorrect.Text = "Correct";
                        return true;
                    }
                    else
                    {
                        labelCorrectIncorrect.Text = "Incorrect";
                        return false;
                    }
                }
                else if (Question.CorrectAnswer == 3)
                {
                    if (buttonAnswer3.Checked)
                    {
                        labelCorrectIncorrect.Text = "Correct";
                        return true;
                    }
                    else
                    {
                        labelCorrectIncorrect.Text = "Incorrect";
                        return false;
                    }
                }
            }
            return false;
        }

        private void TriviaForm_Load(object sender, EventArgs e)
        {

        }

        private void next_Click_1(object sender, EventArgs e)
        {
            check_Click();
            next_Click();
        }
    }
}
