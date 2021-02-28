using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AskAPirate
{
    class Magic8Ball
    {
        static void Main(string[] args)
        {
            /* Requirements:
             * -Ask the user for their yes/no question
             * -respond with a random answer from your set (collection) of answers
             * -Set the program to loop based on user choice (option to leave after asking a question)
             * -Use at least one custom method
             */


            Console.Title = "Ask a Pirate Application";


            bool exit = false;
            bool stopPlaying = false;
            do
            {
                Console.WriteLine("Welcome to Ask A Pirate! \nThe best (and only) place to get advice from real pirates!" +
                    "\nWhat are ye waitin' for? Ask away, landubber! Then press [ENTER] to ask your very own pirate!");
                string userQuestion = Console.ReadLine();
                Console.Clear();

                Console.WriteLine($"{userQuestion}\nWhat a good question! We'll ask one of our pirates!" +
                    $"\nSending Question via secure time travel loop......." +
                    $"\n%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%" +
                    $"\n \nOur pirate had this to say:" +
                    $"\n" + AskAPirate() +
                    "\n \nHopefully that clears things right up!" +
                    "\nWould you like to ask another question? Press [Y]/[N]:");
                ConsoleKey userChoice = Console.ReadKey(true).Key;
                do
                {
                    switch (userChoice)
                    {
                        case ConsoleKey.Y:
                            Console.WriteLine("Great, we've got many more pirates waiting for questions! Press any key to return to the questioning!");
                            Console.ReadKey();
                            Console.Clear();
                            stopPlaying = true;
                            break;

                        case ConsoleKey.N:
                            Console.Clear();
                            Console.WriteLine("Well it was nice while it lasted!");
                            exit = true;
                            break;


                        default:
                            Console.WriteLine($"{userChoice} doesn't translate well to pirate... \nYou ought to choose either [Y] or [N]:");
                            userChoice = Console.ReadKey(true).Key;
                            Console.Clear();
                            break;
                    }

                } while (!stopPlaying && !exit);// end stopPlaying dowhile

            } while (!exit); // end program do while

            Console.WriteLine("\nWe must sail away on different tides for now, though we look forward to seeing you on our horizons again!");
            Console.WriteLine(@"
    __|__ __|__ |\
    |o__| |___| | \
    |___| |___| |o \
   _|___| |___| |__o\   /
  /...\_____|___|____\_/
  \   o * o * * o o  /
~~~~~~~~~~~~~~~~~~~~~~~~~~
");

        }//end Main()

        private static string AskAPirate()
        {
            //10 Affirmative, 5 Non-Comittal, 5 Negative
            string[] responses = new string[20];
            responses[0] = "Aye, 'tis certain";
            responses[1] = "I asked the first mate and she thinks so";
            responses[2] = "*squack* Aye aye! *squack*";
            responses[3] = "There ain't a doubt in me mind";
            responses[4] = "Sure as steel, landlubber";
            responses[5] = "Rely on it like it's dry land in a storm";
            responses[6] = "I may only have one eye, but I says aye!";
            responses[7] = "I checked with me spyglass and it looks good to me!";
            responses[8] = "All the omens point to aye";
            responses[9] = "I'd bet me next haul on it";
            responses[10] = "Wha-? Ask me after I sleep this hangover off";
            responses[11] = @"""What's that, Ol' Greg?"" Sorry, landlubber, I've got to go hoist the mains";
            responses[12] = "Ain't got no time for jawin'";
            responses[13] = "Arr, the tides of fate be fickle beasts";
            responses[14] = "I ain't known for me dependability.. best ask someone else ";
            responses[15] = "Hmm, I have me doubts about it";
            responses[16] = "Limpy Pete says nay. And he's usually spot on";
            responses[17] = "We voted and the nays have it.";
            responses[18] = "'Tis surely ill-advised";
            responses[19] = "Seems about as likely as a dry boot in a monsoon";

            Random randomNbrGen = new Random();
            return responses[(randomNbrGen.Next(responses.Length))];
        }

    }//end class
}
