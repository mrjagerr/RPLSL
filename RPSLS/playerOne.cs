using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace RPSLS
{
    internal class  Human : Player
    {
        public Player playerOne;
        public Player playerTwo;


        public Human(string name)
        {
            this.name = name;
            gestures = new List<string> { "rock", "paper", "scissors", "lizard", "Spock" };
            chosenGesture = "";
            score = 0;
        }
       
        

        public override void ChooseGesture() 
        {
            Console.WriteLine($"{name} {chosenGesture}");
        }
    }    

    }
   