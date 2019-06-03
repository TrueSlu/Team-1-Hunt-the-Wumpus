using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team1_Wumpus
{
    public class TriviaManager
    {
        List<Trivia> TriviaQuestions = new List<Trivia>();
        List<string> TriviaSecrets = new List<string>();
        List<int> ShownQuestionIDs = new List<int>();
        TriviaForm TriviaDialog = new TriviaForm();
        Random rnd = new Random();

        public TriviaManager()
        {
            InitializeTrivia();
        }

        public void InitializeTrivia()
        {
            Trivia q1 = new Trivia("What is 1+1?", "2", "3", "4", 1, 1);
            Trivia q2 = new Trivia("Who was the first president of the United States?", "Thomas Jefferson", "George Washington", "Bob Marley", 2, 2);
            Trivia q3 = new Trivia("What is 30 + 12", "24", "52", "42", 3, 3);
            Trivia q4 = new Trivia("Who is the current president of the united States", "George Bush", "Barack Obama", "Donald Trump", 3, 4);
            Trivia q5 = new Trivia("What year was Shrek released?", "2001", "2003", "2010", 1, 5);
            Trivia q6 = new Trivia("What is the capital of China?", "Shanghai", "Nanjing", "Beijing", 3, 6);
            Trivia q7 = new Trivia("What is the capital of Australia?", "Sydney", "Canberra", "Melbourne", 2, 7);
            Trivia q8 = new Trivia("What is the capital of New Zealand?", "Auckland", "Napier-Hastings", "Wellington", 3, 8);
            Trivia q9 = new Trivia("What is the capital of Tennessee?", "Memphis", "Nashville", "Knoxville", 2, 9);
            Trivia q10 = new Trivia("Who was the first leader of the Ottoman Empire?", "Selim I", "Mehmed Vahideddin", "Osman I", 3, 10);
            Trivia q11 = new Trivia("What is the capital of Chad?", "Moundou", "Sarh", "N'Djamena", 3, 11);
            Trivia q12 = new Trivia("What is the capital of Canada?", "Ottawa", "Montreal", "Toronto", 1, 12);
            Trivia q13 = new Trivia("What is the capital of Turkey?", "Istanbul", "Ankara", "Izmir", 2, 13);
            Trivia q14 = new Trivia("What year were the Oscars first introduced?", "1929", "1923", "1953", 1, 14);
            Trivia q15 = new Trivia("What year was Tom & Jerry created?", "1958", "1994", "1940", 3, 15);
            Trivia q16 = new Trivia("What year was Bill Gates born?", "1955", "1951", "1952", 1, 16);
            Trivia q17 = new Trivia("What month was Windows 10 released?", "June", "December", "July", 3, 17);
            Trivia q18 = new Trivia("What year was Internet Explorer released?", "1994", "1995", "1996", 2, 18);
            Trivia q19 = new Trivia("What is the most commonly spoken language in the world?", "English", "Chinese", "Spanish", 2, 19);
            Trivia q20 = new Trivia("What year was slavery abolished in the United States?", "1865", "1874", "1867", 1, 20);
            Trivia q21 = new Trivia("What year was the Space Needle built?", "1976", "1961", "1994", 2, 21);




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


            TriviaSecrets.Add("If you have 3 quarters, 4 dimes, and 4 pennies, you have $1.19. You also have the largest amount of money in coins without being able to make change for a dollar.");
            TriviaSecrets.Add("The numbers '172' can be found on the back of the U.S. $5 dollar bill in the bushes at the base of the Lincoln Memorial.");
            TriviaSecrets.Add("President Kennedy was the fastest random speaker in the world with upwards of 350 words per minute.");
            TriviaSecrets.Add("In the average lifetime, a person will walk the equivalent of 5 times around the equator.");
            TriviaSecrets.Add("Odontophobia is the fear of teeth.");
            TriviaSecrets.Add("The 57 on Heinz ketchup bottles represents the number of varieties of pickles the company once had.");
            TriviaSecrets.Add("In the early days of the telephone, operators would pick up a call and use the phrase, 'Well, are you there?'. It wasn't until 1895 that someone suggested answering the phone with the phrase 'number please?'");
            TriviaSecrets.Add("The surface area of an average-sized brick is 79 cm squared.");
            TriviaSecrets.Add("According to suicide statistics, Monday is the favored day for self-destruction.");
            TriviaSecrets.Add("Cats sleep 16 to 18 hours per day.");
            TriviaSecrets.Add("The most common name in the world is Mohammed.");
            TriviaSecrets.Add("It is believed that Shakespeare was 46 around the time that the King James Version of the Bible was written. In Psalms 46, the 46th word from the first word is shake and the 46th word from the last word is spear.");
            TriviaSecrets.Add("Karoke means 'empty orchestra' in Japanese.");
            TriviaSecrets.Add("The Eisenhower interstate system requires that one mile in every five must be straight. These straight sections are usable as airstrips in times of war or other emergencies.");
            TriviaSecrets.Add("The first known contraceptive was crocodile dung, used by Egyptians in 2000 B.C.");
            TriviaSecrets.Add("Rhode Island is the smallest state with the longest name. The official name, used on all state documents, is 'Rhode Island and Providence Plantations.'");
            TriviaSecrets.Add("When you die your hair still grows for a couple of months.");
            TriviaSecrets.Add("There are two credit cards for every person in the United States.");
            TriviaSecrets.Add("Isaac Asimov is the only author to have a book in every Dewey-decimal category.");
            TriviaSecrets.Add("The newspaper serving Frostbite Falls, Minnesota, the home of Rocky and Bullwinkle, is the Picayune Intellegence.");
            TriviaSecrets.Add("It would take 11 Empire State Buildings, stacked one on top of the other, to measure the Gulf of Mexico at its deepest point.");
            TriviaSecrets.Add("The first person selected as the Time Magazine Man of the Year - Charles Lindbergh in 1927.");
            TriviaSecrets.Add("The most money ever paid for a cow in an auction was $1.3 million.");
            TriviaSecrets.Add("It took Leo Tolstoy six years to write 'War & Peace'.");
            TriviaSecrets.Add("The Neanderthal's brain was bigger than yours is.");
            TriviaSecrets.Add("On the new hundred dollar bill the time on the clock tower of Independence Hall is 4:10.");
            TriviaSecrets.Add("Each of the suits on a deck of cards represents the four major pillars of the economy in the middle ages: heart represented the Church, spades represented the military, clubs represented agriculture, and diamonds represented the merchant class.");
            TriviaSecrets.Add("The names of the two stone lions in front of the New York Public Library are Patience and Fortitude. They were named by then-mayor Fiorello LaGuardia.");
            TriviaSecrets.Add("The Main Library at Indiana University sinks over an inch every year because when it was built, engineers failed to take into account the weight of all the books that would occupy the building.");
            TriviaSecrets.Add("The sound of E.T. walking was made by someone squishing her hands in jelly.");
            TriviaSecrets.Add("Lucy and Linus (who where brother and sister) had another little brother named Rerun. (He sometimes played left-field on Charlie Brown's baseball team, [when he could find it!]).");
            TriviaSecrets.Add("The pancreas produces Insulin.");
            TriviaSecrets.Add("1 in 5,000 north Atlantic lobsters are born bright blue.");
            TriviaSecrets.Add("There are 10 human body parts that are only 3 letters long (eye hip arm leg ear toe jaw rib lip gum).");
            TriviaSecrets.Add("A skunk's smell can be detected by a human a mile away.");
            TriviaSecrets.Add("The word 'lethologica' describes the state of not being able to remember the word you want.");
            TriviaSecrets.Add("The king of hearts is the only king without a moustache.");
            TriviaSecrets.Add("Henry Ford produced the model T only in black because the black paint available at the time was the fastest to dry.");
            TriviaSecrets.Add("Mario, of Super Mario Bros. fame, appeared in the 1981 arcade game, Donkey Kong. His original name was Jumpman, but was changed to Mario to honor the Nintendo of America's landlord, Mario Segali.");
            TriviaSecrets.Add("The three best-known western names in China: Jesus Christ, Richard Nixon, and Elvis Presley.");
            TriviaSecrets.Add("Every year about 98% of the atoms in your body are replaced.");
            TriviaSecrets.Add("Elephants are the only mammals that can't jump.");
            TriviaSecrets.Add("The international telephone dialing code for Antarctica is 672.");
            TriviaSecrets.Add("World Tourist day is observed on September 27.");
            TriviaSecrets.Add("Women are 37% more likely to go to a psychiatrist than men are.");
            TriviaSecrets.Add("The human heart creates enough pressure to squirt blood 30 feet (9 m).");
            TriviaSecrets.Add("Diet Coke was only invented in 1982.");
            TriviaSecrets.Add("There are more than 1,700 references to gems and precious stones in the King James translation of the Bible.");
            TriviaSecrets.Add("When snakes are born with two heads, they fight each other for food.");
            TriviaSecrets.Add("American car horns beep in the tone of F.");
            TriviaSecrets.Add("Turning a clock's hands counterclockwise while setting it is not necessarily harmful. It is only damaging when the timepiece contains a chiming mechanism.");
            TriviaSecrets.Add("There are twice as many kangaroos in Australia as there are people. The kangaroo population is estimated at about 40 million.");
            TriviaSecrets.Add("Police dogs are trained to react to commands in a foreign language; commonly German but more recently Hungarian.");
            TriviaSecrets.Add("The Australian $5 to $100 notes are made of plastic.");
            TriviaSecrets.Add("St. Stephen is the patron saint of bricklayers.");
            TriviaSecrets.Add("The average person makes about 1,140 telephone calls each year.");
            TriviaSecrets.Add("Stressed is Desserts spelled backwards.");
            TriviaSecrets.Add("If you had enough water to fill one million goldfish bowls, you could fill an entire stadium.");
            TriviaSecrets.Add("Mary Stuart became Queen of Scotland when she was only six days old.");
            TriviaSecrets.Add("Charlie Brown's father was a barber.");
            TriviaSecrets.Add("Flying from London to New York by Concord, due to the time zones crossed, you can arrive 2 hours before you leave.");
            TriviaSecrets.Add("Dentists have recommended that a toothbrush be kept at least 6 feet (2 m) away from a toilet to avoid airborne particles resulting from the flush.");
            TriviaSecrets.Add("You burn more calories sleeping than you do watching TV.");
            TriviaSecrets.Add("A lion's roar can be heard from five miles away.");
            TriviaSecrets.Add("The citrus soda 7-UP was created in 1929; '7' was selected because the original containers were 7 ounces. 'UP' indicated the direction of the bubbles.");
            TriviaSecrets.Add("Canadian researchers have found that Einstein's brain was 15% wider than normal.");
            TriviaSecrets.Add("The average person spends about 2 years on the phone in a lifetime.");
            TriviaSecrets.Add("The fist product to have a bar code was Wrigleys gum.");
            TriviaSecrets.Add("The largest number of children born to one woman is recorded at 69. From 1725-1765, a Russian peasant woman gave birth to 16 sets of twins, 7 sets of triplets, and 4 sets of quadruplets.");
            TriviaSecrets.Add("Beatrix Potter created the first of her legendary 'Peter Rabbit' children's stories in 1902.");
            TriviaSecrets.Add("In ancient Rome, it was considered a sign of leadership to be born with a crooked nose.");
            TriviaSecrets.Add("The word 'nerd' was first coined by Dr. Seuss in 'If I Ran the Zoo.'");
            TriviaSecrets.Add("A 41-gun salute is the traditional salute to a royal birth in Great Britain.");
            TriviaSecrets.Add("The bagpipe was originally made from the whole skin of a dead sheep.");
            TriviaSecrets.Add("The roar that we hear when we place a seashell next to our ear is not the ocean, but rather the sound of blood surging through the veins in the ear. Any cup-shaped object placed over the ear produces the same effect.");
            TriviaSecrets.Add("Revolvers cannot be silenced because of all the noisy gasses which escape the cylinder gap at the rear of the barrel.");
            TriviaSecrets.Add("Liberace Museum has a mirror-plated Rolls Royce; jewel-encrusted capes, and the largest rhinestone in the world, weighing 59 pounds and almost a foot in diameter.");
            TriviaSecrets.Add("A car that shifts manually gets 2 miles more per gallon of gas than a car with automatic shift.");
            TriviaSecrets.Add("Cats can hear ultrasound.");
            TriviaSecrets.Add("Dueling is legal in Paraguay as long as both parties are registered blood donors.");
            TriviaSecrets.Add("The highest point in Pennsylvania is lower than the lowest point in Colorado.");
            TriviaSecrets.Add("The United States has never lost a war in which mules were used.");
            TriviaSecrets.Add("Children grow faster in the springtime.");
            TriviaSecrets.Add("On average, there are 178 sesame seeds on each McDonalds BigMac bun.");
            TriviaSecrets.Add("Paul Revere rode on a horse that belonged to Deacon Larkin.");
            TriviaSecrets.Add("The Baby Ruth candy bar was actually named after Grover Cleveland's baby daughter, Ruth.");
            TriviaSecrets.Add("Minus 40 degrees Celsius is exactly the same as minus 40 degrees Fahrenheit.");
            TriviaSecrets.Add("Clans of long ago that wanted to get rid of unwanted people without killing them used to burn their houses down -- hence the expression 'to get fired'");
            TriviaSecrets.Add("Nobody knows who built the Taj Mahal. The names of the architects, masons, and designers that have come down to us have all proved to be latter-day inventions, and there is no evidence to indicate who the real creators were.");
            TriviaSecrets.Add("Every human spent about half an hour as a single cell.");
            TriviaSecrets.Add("7.5 million toothpicks can be created from a cord of wood.");
            TriviaSecrets.Add("The plastic things on the end of shoelaces are called aglets.");
            TriviaSecrets.Add("A 41-gun salute is the traditional salute to a royal birth in Great Britain.");
            TriviaSecrets.Add("The earliest recorded case of a man giving up smoking was on April 5, 1679, when Johan Katsu, Sheriff of Turku, Finland, wrote in his diary 'I quit smoking tobacco.' He died one month later.");
            TriviaSecrets.Add("'Goodbye' came from 'God bye' which came from 'God be with you.'");
            TriviaSecrets.Add("February is Black History Month.");
            TriviaSecrets.Add("Jane Barbie was the woman who did the voice recordings for the Bell System.");
            TriviaSecrets.Add("The first drive-in service station in the United States was opened by Gulf Oil Company - on December 1, 1913, in Pittsburgh, Pennsylvania.");
            TriviaSecrets.Add("The elephant is the only animal with 4 knees.");
            TriviaSecrets.Add("Kansas state law requires pedestrians crossing the highways at night to wear tail lights.");

        }

        public string GetSecret()
        {
            return TriviaSecrets[rnd.Next(0, TriviaSecrets.Count)];
        }

        private Trivia GetQuestion()
        {
            Random r = new Random();

            int index = r.Next(0, TriviaQuestions.Count);
            while (ShownQuestionIDs.IndexOf(TriviaQuestions[index].UUID) != -1)
            {
                index = r.Next(0, TriviaQuestions.Count);
            }
            ShownQuestionIDs.Add(TriviaQuestions[index].UUID);
            return TriviaQuestions[index];
        }

        public bool TriviaBattle(int NumberToAsk, int NumberToWin)
        {
            List<Trivia> NewQuestions = new List<Trivia>();
            for (int i = 0; i < NumberToAsk; i++)
            {
                NewQuestions.Add(GetQuestion());
            }

            TriviaForm TriviaDialog = new TriviaForm();
            TriviaDialog.Questions = NewQuestions;
            TriviaDialog.ShowDialog();

            if (TriviaDialog.NumberCorrect < NumberToWin)
            {
                return false;
            } else
            {
                return true;
            }
        }

    }
    
}
