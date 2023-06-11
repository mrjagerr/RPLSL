﻿using System;
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
            Console.WriteLine("How many human players will there be playing? One or two?");
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
            
           
            while ((playerOne.score != 3) || (playerTwo.score != 3))
            {
                playerOne.ChooseGesture();
                playerTwo.ChooseGesture();


                if (playerOne.ChooseGesture == playerTwo.ChooseGesture)
                {
                    Console.WriteLine("It is a tie.");
                    



                }











            }









        }

        public void DisplayGameWinner()
        {
            if (playerOne.score == 3)
            {
                Console.WriteLine("Player One has won.");
            }
            else if (playerTwo.score == 3)
            
                Console.WriteLine("Player two has won.");

            

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
