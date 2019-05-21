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
            noButtonChecked.Visible = false;
            //creates questions
            Trivia q1 = new Trivia("What is 1+1?", "2", "3", "4", 1);
            Trivia q2 = new Trivia("Who was the first president of the United States?", "Thomas Jefferson", "George Washington", "Bob Marley", 2);
            Trivia q3 = new Trivia("What is 30 + 12", "24", "52", "42", 3);
            Trivia q4 = new Trivia("Who is the current president of the united States", "George Bush", "Barack Obama", "Donald Trump", 3);
            Trivia q5 = new Trivia("What year was Shrek released?", "2001", "2003", "2010", 1);
            Trivia q6 = new Trivia("What is the capital of China?", "Shanghai", "Nanjing", "Beijing", 3);
            Trivia q7 = new Trivia("What is the capital of Australia?", "Sydney", "Canberra", "Melbourne", 2);
            Trivia q8 = new Trivia("What is the capital of New Zealand?", "Auckland", "Napier-Hastings", "Wellington", 3);
            Trivia q9 = new Trivia("What is the capital of Tennessee?", "Memphis", "Nashville", "Knoxville", 2);
            Trivia q10 = new Trivia("Who was the first leader of the Ottoman Empire?", "Selim I", "Mehmed Vahideddin", "Osman I", 3);
            Trivia q11 = new Trivia("What is the capital of Chad?", "Moundou", "Sarh", "N'Djamena", 3);
            Trivia q12 = new Trivia("What is the capital of Canada?", "Ottawa", "Montreal", "Toronto", 1);
            Trivia q13 = new Trivia("What is the capital of Turkey?", "Istanbul", "Ankara", "Izmir", 2);
            Trivia q14 = new Trivia("What year were the Oscars first introduced?", "1929", "1923", "1953", 1);
            Trivia q15 = new Trivia("What year was Tom & Jerry created?", "1958", "1994", "1940", 3);
            //adds questions to list
            TriviaQuestions.Add(q1);
            TriviaQuestions.Add(q2);
            TriviaQuestions.Add(q3);
            TriviaQuestions.Add(q4);
            TriviaQuestions.Add(q5);
            TriviaQuestions.Add(q6);
            TriviaQuestions.Add(q7);
            TriviaQuestions.Add(q8);
            TriviaQuestions.Add(q9);
            TriviaQuestions.Add(q10);
            TriviaQuestions.Add(q11);
            TriviaQuestions.Add(q12);
            TriviaQuestions.Add(q13);
            TriviaQuestions.Add(q14);
            TriviaQuestions.Add(q15);
        }

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
    }
}
