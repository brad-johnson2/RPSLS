using System;
using System.Collections.Generic;

namespace RockProject
{
    public class Game
    {
        Player playerOne;
        Player playerTwo;
        List<string> gestures; 

        public Game()
        {
            playerOne = new HumanPlayer();
            gestures = new List<string>() { "rock", "paper", "scissors", "lizard", "spock" };
        }

        public void RunGame()
        {
            GetPlayerTwo();
            while (playerOne.score < 3 && playerTwo.score < 3)
            {
                playerOne.ChooseGesture(gestures);
                playerTwo.ChooseGesture(gestures);
                Console.WriteLine("Player 1: " + playerOne.gesture);
                Console.WriteLine("Player 2: " + playerTwo.gesture);
                CompareGestures(playerOne.gesture, playerTwo.gesture);
            }
            if (playerOne.score == 3)
            {
                Console.WriteLine("Player 1 is the winner.");
            }
            else if (playerTwo.score == 3)
            {
                Console.WriteLine("Player 2 is the winner.");
            }
        }

       

        public void GetPlayerTwo()
        {
            Console.WriteLine("How many players? 1 or 2?");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    playerTwo = new ComputerPlayer();
                    break;
                case "2":
                    playerTwo = new HumanPlayer();
                    break;
                default:
                    GetPlayerTwo();
                    break;
            }
        }


        public void CompareGestures(string gesture, string gesture1)
        {


            if (playerOne.gesture == "rock")
            {
                switch (playerTwo.gesture)
                {
                    case "paper":
                        playerTwo.score += 1;
                        Console.WriteLine("Paper covers Rock.");
                        break;

                    case "scissors":
                        playerOne.score += 1;
                        Console.WriteLine("Rock crushes Scissors.");
                        break;

                    case "lizard":
                        playerOne.score += 1;
                        Console.WriteLine("Rock crushes Lizard.");
                        break;

                    case "spock":
                        playerTwo.score += 1;
                        Console.WriteLine("Spock vaporizes Rock.");
                        break;

                    case "rock":
                        Console.WriteLine("Draw.");
                        break;

                    default:
                        break;
                }

            }

            if (playerOne.gesture == "paper")
            {
                switch (playerTwo.gesture)
                {
                    case "paper":
                        Console.WriteLine("Draw.");
                        break;

                    case "scissors":
                        playerTwo.score += 1;
                        Console.WriteLine("Scissors cuts Paper.");
                        break;

                    case "lizard":
                        playerTwo.score += 1;
                        Console.WriteLine("Lizard eats Paper.");
                        break;

                    case "spock":
                        playerOne.score += 1;
                        Console.WriteLine("Paper disproves Spock.");
                        break;

                    case "rock":
                        playerOne.score += 1;
                        Console.WriteLine("Paper covers Rock.");
                        break;

                    default:
                        break;
                }

            }

            if (playerOne.gesture == "scissors")
            {
                switch (playerTwo.gesture)
                {
                    case "paper":
                        playerOne.score += 1;
                        Console.WriteLine("Scissors cuts Paper.");
                        break;

                    case "scissors":
                        Console.WriteLine("Draw.");
                        break;

                    case "lizard":
                        playerOne.score += 1;
                        Console.WriteLine("Scissors decapitates Lizard.");
                        break;

                    case "spock":
                        playerTwo.score += 1;
                        Console.WriteLine("Spock smashes Scissors.");
                        break;

                    case "rock":
                        playerTwo.score += 1;
                        Console.WriteLine("Rock crushes Scissors.");
                        break;

                    default:
                        break;
                }

            }

            if (playerOne.gesture == "lizard")
            {
                switch (playerTwo.gesture)
                {
                    case "paper":
                        playerOne.score += 1;
                        Console.WriteLine("Lizard eats Paper.");
                        break;

                    case "scissors":
                        playerTwo.score += 1;
                        Console.WriteLine("Scissors decapitates Lizard.");
                        break;

                    case "lizard":
                        Console.WriteLine("Draw.");
                        break;

                    case "spock":
                        playerOne.score += 1;
                        Console.WriteLine("Lizard poisons Spock.");
                        break;

                    case "rock":
                        playerTwo.score += 1;
                        Console.WriteLine("Rock crushes Lizards.");
                        break;

                    default:
                        break;
                }

            }

            if (playerOne.gesture == "spock")
            {
                switch (playerTwo.gesture)
                {
                    case "paper":
                        playerTwo.score += 1;
                        Console.WriteLine("Paper disproves Spock.");
                        break;

                    case "scissors":
                        playerOne.score += 1;
                        Console.WriteLine("Spock smashes Scissors.");
                        break;

                    case "lizard":
                        playerTwo.score += 1;
                        Console.WriteLine("Lizard poisons Spock.");
                        break;

                    case "spock":
                        Console.WriteLine("Draw.");
                        break;

                    case "rock":
                        playerOne.score += 1;
                        Console.WriteLine("Spock vaporizes Rock.");
                        break;

                    default:
                        break;
                }

            }
        }

    }















}
