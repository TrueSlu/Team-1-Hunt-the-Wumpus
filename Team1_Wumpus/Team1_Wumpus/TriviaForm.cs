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
    public partial class TriviaForm : Form
    {
        List<Trivia> TriviaQuestions = new List<Trivia>();
        int index = 0;
        public TriviaForm()
        {
            InitializeComponent();
            labelCorrectIncorrect.Visible = false;
            Trivia q1 = new Trivia("What is 1+1?", "2", "3", "4", 1);
            Trivia q2 = new Trivia("Who was the first president of the United States?", "Thomas Jefferson", "George Washington", "Bob Marley", 2);
            Trivia q3 = new Trivia("What is 30 + 12", "24", "52", "42", 3);
            Trivia q4 = new Trivia("Who is the current president of the united States", "George Bush", "Barack Obama", "Donald Trump", 3);
            Trivia q5 = new Trivia("What year was Shrek released?", "2001", "2003", "2010", 1);

            TriviaQuestions.Add(q1);
            TriviaQuestions.Add(q2);
            TriviaQuestions.Add(q3);
            TriviaQuestions.Add(q4);
            TriviaQuestions.Add(q5);
        }

        public Trivia GetQuestion()
        {
            index++;
            if (index >= TriviaQuestions.Count) index = 0;
            return TriviaQuestions[index];
        }


        private void next_Click(object sender, EventArgs e)
        {
            labelCorrectIncorrect.Visible = false;
            Trivia question = GetQuestion();
            labelQuestion.Text = question.Question;
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
    }
}
