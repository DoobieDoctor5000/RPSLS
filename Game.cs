using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPSLS
{
    class Game
    {

        Prompts RPSLSprompts = new Prompts();

        public static bool validData = false;

        public static string userChoice;

        public static string computerChoice;

        public static int result;

        public static int randomNumber;
        
        public void Play() // This is where the main flow of the game takes place.
        {

            RPSLSprompts.WelcomePrompt(); // Welcome the player.
            EmptyLine();
            Stall();
            Clear();

            while (validData == false)
            {
                validData = true;
                RPSLSprompts.PromptForChoice();  // Direct the player to make a choice.
                userChoice = UserChoice(); // Store choice.

                randomNumber = GetRandomNumber(); // Stores random number between 0 and 4.
                ComputerChoice(); // Using the random number, the computer chooses.
                CompareChoices(); // Compares computer & player choices. Provides integer for result.

                Stall();
                Clear();

                RPSLSprompts.DisplayChoice(); // Show the player what he/she chose, compared to the computer's choice.

                FinalResult();

                Stall();
                Clear();

            }

        }

        public void Stall() // This is just to avoid a bunch of unexplained ReadLines everywhere.
        {

            RPSLSprompts.StallPrompt();
            Console.ReadLine();

        }

        public void EmptyLine() // Self-explanatory?
        {

            Console.WriteLine("");

        }

        public void Clear() // Just to shorten console clear command.
        {

            Console.Clear();

        }

        public string UserChoice()
        {

            string userChoice = Console.ReadLine(); // Store input into variable
            return userChoice; // Return input.

        }

        public int GetRandomNumber()
        {
            Random random = new Random ();
            int randomNumber = random.Next(0, 5);
            return randomNumber;
        }

        public void ComputerChoice()
        {

            switch (randomNumber)
            {

                case 0:
                    computerChoice = "Rock";
                    break;
                case 1:
                    computerChoice = "Paper";
                    break;
                case 2:
                    computerChoice = "Scissors";
                    break;
                case 3:
                    computerChoice = "Lizard";
                    break;
                case 4:
                    computerChoice = "Spock";
                    break;
                default:
                    RPSLSprompts.InvalidInput();
                    break;

            }

        }

        public void CompareChoices()
        {

            switch (computerChoice)
            {

                case "Rock":

                    switch (userChoice)
                    {

                        case "Rock":
                        case "rock":
                            result = 1;
                            break;

                        case "Paper":
                        case "paper":
                            result = 2;
                            break;

                        case "Scissors":
                        case "scissors":
                            result = 3;
                            break;

                        case "Lizard":
                        case "lizard":
                            result = 4;
                            break;

                        case "Spock":
                        case "spock":
                            result = 5;
                            break;

                        default:
                            RPSLSprompts.InvalidInput();
                            break;

                    }

                    break;

                case "Paper":

                    switch (userChoice)
                    {

                        case "Rock":
                        case "rock":
                            result = 6;
                            break;

                        case "Paper":
                        case "paper":
                            result = 7;
                            break;

                        case "Scissors":
                        case "scissors":
                            result = 8;
                            break;

                        case "Lizard":
                        case "lizard":
                            result = 9;
                            break;

                        case "Spock":
                        case "spock":
                            result = 10;
                            break;

                        default:
                            RPSLSprompts.InvalidInput();
                            break;
                    }

                    break;

                case "Scissors":

                    switch (userChoice)
                    {

                        case "Rock":
                        case "rock":
                            result = 11;
                            break;

                        case "Paper":
                        case "paper":
                            result = 12;
                            break;

                        case "Scissors":
                        case "scissors":
                            result = 13;
                            break;

                        case "Lizard":
                        case "lizard":
                            result = 14;
                            break;

                        case "Spock":
                        case "spock":
                            result = 15;
                            break;

                        default:
                            RPSLSprompts.InvalidInput();
                            break;
                    }

                    break;

                case "Lizard":

                    switch (userChoice)
                    {

                        case "Rock":
                        case "rock":
                            result = 16;
                            break;

                        case "Paper":
                        case "paper":
                            result = 17;
                            break;

                        case "Scissors":
                        case "scissors":
                            result = 18;
                            break;

                        case "Lizard":
                        case "lizard":
                            result = 19;
                            break;

                        case "Spock":
                        case "spock":
                            result = 20;
                            break;

                        default:
                            RPSLSprompts.InvalidInput();
                            break;
                    }

                    break;

                case "Spock":

                    switch (userChoice)
                    {

                        case "Rock":
                        case "rock":
                            result = 21;
                            break;

                        case "Paper":
                        case "paper":
                            result = 22;
                            break;

                        case "Scissors":
                        case "scissors":
                            result = 23;
                            break;

                        case "Lizard":
                        case "lizard":
                            result = 24;
                            break;

                        case "Spock":
                        case "spock":
                            result = 25;
                            break;

                        default:
                            RPSLSprompts.InvalidInput();
                            break;
                    }

                    break;

                default:
                    RPSLSprompts.InvalidInput();
                    break;

            }

        }

        public void FinalResult()
        {

            switch (result)
            {

                case 1:
                case 7:
                case 13:
                case 19:
                case 25:
                    RPSLSprompts.tiePrompt();
                    break;

                case 2:
                    RPSLSprompts.winPaperCoversRock();
                    break;

                case 3:
                    RPSLSprompts.loseRockCrushesScissors();
                    break;

                case 4:
                    RPSLSprompts.loseRockCrushesLizard();
                    break;

                case 5:
                    RPSLSprompts.winSpockVaporizesRock();
                    break;

                case 6:
                    RPSLSprompts.losePaperCoversRock();
                    break;

                case 8:
                    RPSLSprompts.winScissorsCutPaper();
                    break;

                case 9:
                    RPSLSprompts.winLizardEatsPaper();
                    break;

                case 10:
                    RPSLSprompts.losePaperDisprovesSpock();
                    break;

                case 11:
                    RPSLSprompts.winRockCrushesScissors();
                    break;

                case 12:
                    RPSLSprompts.loseScissorsCutPaper();
                    break;

                case 14:
                    RPSLSprompts.loseScissorsDecapitateLizard();
                    break;

                case 15:
                    RPSLSprompts.winSpockSmashesScissors();
                    break;

                case 16:
                    RPSLSprompts.winRockCrushesLizard();
                    break;

                case 17:
                    RPSLSprompts.loseLizardEatsPaper();
                    break;

                case 18:
                    RPSLSprompts.winScissorsDecapitateLizard();
                    break;

                case 20:
                    RPSLSprompts.loseLizardPoisonsSpock();
                    break;

                case 21:
                    RPSLSprompts.loseSpockVaporizesRock();
                    break;

                case 22:
                    RPSLSprompts.winPaperDisprovesSpock();
                    break;

                case 23:
                    RPSLSprompts.loseSpockSmashesScissors();
                    break;

                case 24:
                    RPSLSprompts.winLizardPoisonsSpock();
                    break;

            }

        }
    }
}
