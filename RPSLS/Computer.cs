using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class Computer : Player
    {
        



        
        public Computer(string name)
            {
            
            Random random = new Random();
            this.name = name;
            gestures = new List<string> { "rock", "paper", "scissors", "lizard", "spock" };
            chosenGesture = "";
            score = 0;
            }



            public override void ChooseGesture()
            {
            Random random = new Random();
            chosenGesture = gestures[random.Next(0, gestures.Count)];
            Console.WriteLine($"{name}  chooses {chosenGesture}");
            }
        }

    }


