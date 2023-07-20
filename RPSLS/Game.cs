using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Formats.Asn1.AsnWriter;

namespace RPSLS
{
    internal class Game
    {
        //Member Variabes (HAS A)
        public Player playerOne;
        public Player playerTwo;









        //Constructor
        public Game()
        {

        }

        //Member Methods (CAN DO)
        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to RPSLS! Here are the rules:\r\n" +
                "Rock crushes Scissors\r\n" +
                "Scissors cuts Paper \r\n" +
                "Paper covers Rock\r\n" +
                "Rock crushes Lizard\r\n" +
                "Lizard poisons Spock\r\n" +
                "Spock smashes Scissors\r\n" +
                "Scissors decapitates Lizard\r\n" +
                "Lizard eats Paper\r\n" +
                "Paper disproves Spock\r\n" +
                "Spock vaporizes Rock\r\n " +
                "\r\n " +
               "The game will be the best out of 3.");

        }

        public int ChooseNumberOfHumanPlayers()
        {
            Console.WriteLine("How many human players will there be playing? 1 or 2?");
            int numberofplayers = Convert.ToInt32(Console.ReadLine());
            return numberofplayers;
        }

        public void CreatePlayerObjects(int numberOfHumanPlayers)
        { // issue is implimenting and creating the player classes and computer class
          // computer will use random.rand to randomize in the list. 


            numberOfHumanPlayers = ChooseNumberOfHumanPlayers();


            
           if (numberOfHumanPlayers == 1)
            {
                Console.WriteLine("Player one enter your name.");
                Human playerone = new Human("");
                playerOne = playerone;
                playerone.name = Console.ReadLine();

                Computer computer = new Computer("");
                playerTwo = computer;
                computer.name = "Computer";
                Console.WriteLine($"Your opponent will be {computer.name}");
            }
            else if (numberOfHumanPlayers == 2)
            {
                Console.WriteLine("Player one enter your name.");
                Human playerone = new Human("");
                playerOne = playerone;
                playerone.name = Console.ReadLine();

                Console.WriteLine("Player two enter your name.");
                Human playertwo = new Human("");
                playerTwo = playertwo;
                playertwo.name = Console.ReadLine();
            }


        }
        //if else statements using case and switch
        public void CompareGestures()
        {
            
           
            while ((playerOne.score != 3) || (playerTwo.score !=3))
            {
                if (playerOne.score == 3 || playerTwo.score == 3)
                {
                    break;
                }


                    playerOne.ChooseGesture();
                    playerTwo.ChooseGesture();
               


                if (playerOne.chosenGesture == playerTwo.chosenGesture)
                {
                    Console.WriteLine("It is a tie. Please try again.");
                }
                else
                {
                    if (playerOne.chosenGesture == "rock")
                    {
                        if (playerTwo.chosenGesture == "lizard"|| playerTwo.chosenGesture == "scissors")
                        {
                            Console.WriteLine($"{playerOne.name} you have won {playerOne.chosenGesture} crushes {playerTwo.chosenGesture}");
                            playerOne.score++;
                        }
                        else if (playerTwo.chosenGesture == "paper")
                        {
                            Console.WriteLine($"{playerOne.name} lose. Paper covers rock");
                            playerTwo.score++;
                        }
                        else if(playerTwo.chosenGesture == "spock")
                        {
                            Console.WriteLine($"{playerOne.name} you lose. Spock vaporizes rock");
                            playerTwo.score++;
                        }
                    }
                    else if (playerOne.chosenGesture == "paper")
                    {
                        if (playerTwo.chosenGesture == "spock")
                        {
                            Console.WriteLine($"{playerOne.name} wins. Paper disproves Spock");
                            playerOne.score++;
                        }
                        else if (playerTwo.chosenGesture == "rock")
                        {
                            Console.WriteLine($"{playerOne.name} wins. Paper covers rock.");
                            playerOne.score++;
                        }
                        else if  (playerTwo.chosenGesture == "lizard")
                            {
                                Console.WriteLine($"{playerOne.name} loses. Lizard eats paper.");
                                playerTwo.score++;
                            }
                        else if (playerTwo.chosenGesture == "scissors")
                        {
                            Console.WriteLine($"{playerOne.name} loses. Scissors cuts paper.");
                            playerTwo.score++;
                        }
                    }
                    else if( playerOne.chosenGesture == "lizard")
                    {
                        if(playerTwo.chosenGesture == "paper")
                        {
                            Console.WriteLine($"{playerOne.name} wins. Lizard eats paper.");
                            playerOne.score++;
                        }
                        else if (playerTwo.chosenGesture == "spock")
                        {
                            Console.WriteLine($"{playerOne.name} wins. Lizard poisons spock");
                            playerOne.score++;
                        }
                        else if(playerTwo.chosenGesture == "scissors") 
                        {
                            Console.WriteLine($"{playerOne.name} loses. Scissors decapitates lizard");
                            playerTwo.score++;
                        }
                        else if (playerTwo.chosenGesture == "rock")
                        {
                            Console.WriteLine($"{playerOne.name} loses . Rock crushes lizard");
                            playerTwo.score++;
                        }
                    }
                    else if ( playerOne.chosenGesture == "spock")
                    {
                        if (playerTwo.chosenGesture == "rock")
                        {
                            Console.WriteLine($"{playerOne.name} wins.Spock vaporizes rock");
                            playerOne.score++;
                        }
                        else if (playerTwo.chosenGesture == "scissors")
                        {
                            Console.WriteLine($"{playerOne.name} wins. Spock crushes scissors");
                            playerOne.score++;
                        }
                        else if (playerTwo.chosenGesture == "paper")
                        {
                            Console.WriteLine($"{playerOne.name} loses. Paper disproves Spock");
                            playerTwo.score++;
                        }
                        else if (playerTwo.chosenGesture == "lizard")
                        {
                            Console.WriteLine($"{playerOne.name} loses. Lizard poisons spock");
                            playerTwo.score++;
                            
                        }
                    }
                }
                







            }









        }

        public void DisplayGameWinner()
        {
            if (playerOne.score == 3)
            {
                Console.WriteLine($"{playerOne.name} has won.");
            }
            else if (playerTwo.score == 3)
            
                Console.WriteLine($"{playerTwo.name} has won.");

            

        }

        public void RunGame()
        {
            //step 1.display the rules of the game
            WelcomeMessage();
            //step 2.ask how many human players are in the game
            CreatePlayerObjects(0);
            // step3 validate the number of human players if only one player then face computer opponent  if 2 players face each other. (edited)
            CompareGestures();
            // step 4 once the numbers of human players are selected show the number of gestures that can be chosen
            //step 5 player selects  gesture
            //step 6 gesture is imputed vrs computer gesture or other human player gesture.Based on the rules decide winner.
            // step 7 add win to the player whos won score(edited)
            // step 8 repeat step 6 til a winner of 3 rounds is decided.
            // step 9 Declare the winner of the game. (edited)
            DisplayGameWinner();
        }
    }
}
