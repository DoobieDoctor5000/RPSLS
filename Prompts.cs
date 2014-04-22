using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPSLS
{
    class Prompts
    {

        public void WelcomePrompt()
        {
            
            Console.WriteLine(@"    Welcome to Rock, Paper, Scissors, Lizard, Spock!
    Let's play a game!");

        }

        public void StallPrompt()
        {

            Console.WriteLine(@"    Press enter to continue.");

        }

        public void PromptForChoice()
        {

            Console.WriteLine(@"    Please enter your selection (Rock/Paper/Scissors/Lizard/Spock):");

        }

        public void DisplayChoice()
        {

            Console.WriteLine("You chose {0}.  I chose {1}!", Game.userChoice, Game.computerChoice);

        }


        public void InvalidInput()
        {

            Console.WriteLine(@"    Why would a Wookiee, an 8-foot-tall Wookiee, want to live on Endor,
    with a bunch of 2-foot-tall Ewoks? That does not make sense!
    
    Please enter valid data.");

            Game.validData = false;

        }

        public void tiePrompt()
        {

            Console.WriteLine(@"    I'm afraid it's a tie-game!");

        }

        public void winPaperCoversRock()
        {

            Console.WriteLine(@"    Paper covers Rock, so it looks like you win!");

        }

        public void loseRockCrushesScissors()
        {

            Console.WriteLine(@"    BOOYAKASHA!  My Rock CRUSHES your Scissors!  I WIN!");

        }

        public void loseRockCrushesLizard()
        {

            Console.WriteLine(@"    Get that outta here!  Your Lizard is no match for my Rock!  I WIN!");

        }

        public void winSpockVaporizesRock()
        {

            Console.WriteLine(@"    So... Spock vaporizes Rock.  You win... whatever...");

        }

        public void losePaperCoversRock()
        {

            Console.WriteLine(@"    Looks like my Paper covers your Rock.  I WIN!");

        }

        public void winScissorsCutPaper()
        {

            Console.WriteLine(@"    You cut my Paper with your Scissors!  Aww man.  You win!");

        }

        public void winLizardEatsPaper()
        {

            Console.WriteLine(@"    Your Lizard ate my Paper!  Looks like you win!");

        }

        public void losePaperDisprovesSpock()
        {

            Console.WriteLine(@"    Ha!  My Paper disproves your Spock!  I WIN!");

        }

        public void winRockCrushesScissors()
        {

            Console.WriteLine(@"    You crushed my Scissors with your Rock!  That's messed-up, man!
    Looks like you win.  Good for you!");

        }

        public void loseScissorsCutPaper()
        {

            Console.WriteLine(@"    Why're you bringing Paper to a Scissor-fight?  I WIN!");

        }

        public void loseScissorsDecapitateLizard()
        {

            Console.WriteLine(@"    Sploosh!  That's a lot of blood.  Looks like I decapitated
    your Lizard with my Scissors!  I WIN!");

        }

        public void winSpockSmashesScissors()
        {

            Console.WriteLine(@"    Hey!  Those Scissors cost me a lot of money!  Your stupid Spock
    smashed them!  I guess you win, but you owe me a pair of Scissors!");

        }

        public void winRockCrushesLizard()
        {

            Console.WriteLine(@"    MY BABY!  YOU KILLED MY BABY!  How COULD you!?  What did
    my Lizard do to you to make you crush it with your Rock!?
    I guess you win, despite killing my best friend!");

        }

        public void loseLizardEatsPaper()
        {

            Console.WriteLine(@"    My Lizard thinks your Paper is tasty.  I WIN!");

        }

        public void winScissorsDecapitateLizard()
        {

            Console.WriteLine(@"    LIZARD-KILLER!  YOU MONSTER!  You decapitated my best-
    friend in the whole-wide world!  You win, for now!");

        }

        public void loseLizardPoisonsSpock()
        {

            Console.WriteLine(@"    Your Spock is no match for my Lizard's deadly poison!  I WIN!");

        }

        public void loseSpockVaporizesRock()
        {

            Console.WriteLine(@"    What happened to your Rock?  Oh yeah, my Spock VAPORIZED it!  I WIN!");

        }

        public void winPaperDisprovesSpock()
        {

            Console.WriteLine(@"    So you think you're smart?  Oooh your Paper disproved my Spock.
    Soooo impressive... You win for now...");

        }

        public void loseSpockSmashesScissors()
        {

            Console.WriteLine(@"    BOOM!  My Spock just smashed your Scissors!  I WIN!");

        }

        public void winLizardPoisonsSpock()
        {

            Console.WriteLine(@"    Your Lizard poisoned a great man, today.  My poor Spock!  You win...");

        }
    }
}
