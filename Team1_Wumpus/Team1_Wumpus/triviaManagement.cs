using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team1_Wumpus
{
    public class triviaManagement
    {
        public List<Trivia> Questions { get; private set; } = new List<Trivia>();

        public triviaManagement()
        {

        }

        public Trivia GetSelectedQuestion(int index)
        {
            return Questions[index];
        }


    }
}
