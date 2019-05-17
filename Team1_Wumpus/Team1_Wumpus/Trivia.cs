using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team1_Wumpus
{
    public class Trivia
    {
        public string Question { get; set; }
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public int CorrectAnswer { get; set; }



        public Trivia(string q, string a1, string a2, string a3, int ca)
        {
            Question = q;
            Answer1 = a1;
            Answer2 = a2;
            Answer3 = a3;
            CorrectAnswer = ca;
        }
    }
}
