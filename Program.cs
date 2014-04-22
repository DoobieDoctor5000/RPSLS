using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/* Rock Paper Scissors Lizard Spock
 * 
 * Rules:
 * 
 * Scissors cut Paper and decapitate Lizard.
 * Paper covers Rock and disproves Spock.
 * Rock crushes Lizard and crushes Scissors.
 * Lizard poisons Spock and eats Paper.
 * Spock smashes Scissors and vaporizes Rock.
 *
 * Assignment can be found at http://www.reddit.com/r/dailyprogrammer/comments/23lfrf/4212014_challenge_159_easy_rock_paper_scissors/
 * 
 * Quote from the site:
 * "...implement a basic game of Rock Paper Scissors Lizard Spock...
 * get the human choice...
 * randomly pick a move...
 * compare the results and display the moves and the out come"
 * 
 * BONUS:
 * The game loops and continues to play matches until the user quits or a fixed number of games is played.
 * At the end it records some basic stats:

    Total Games played
    Computer Wins (Number and percentage)
    Human Wins (Number and percentage)
    Ties (Number and Percentage)

 */


namespace RPSLS
{
    class Program
    {
        static void Main(string[] args)
        {

            Game RPSLSgame = new Game();

            RPSLSgame.Play();

        }
    }
}
