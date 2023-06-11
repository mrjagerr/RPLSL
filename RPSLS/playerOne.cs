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
       


        public Human(string name)
        {
            this.name = name;
            gestures = new List<string> { "rock", "paper", "scissors", "lizard", "spock" };
            chosenGesture = "";
            
            score = 0;
        }
       
        

        public override void ChooseGesture() 
        {
            Console.WriteLine("Please choose rock,paper,scissors,lizard, or spock");
            chosenGesture = Console.ReadLine();
            Console.WriteLine($"{name} chooses {chosenGesture}");
        }
    }    

    }
   