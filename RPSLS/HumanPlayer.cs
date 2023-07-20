using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace RPSLS
{
    internal class Human : Player
    {



        public Human(string name)
        {
           
        }



        public override void ChooseGesture()
        {

            Console.WriteLine($"{name} please choose rock,paper,scissors,lizard, or spock ");
            chosenGesture = Console.ReadLine().ToLower();
           
           while(!gestures.Contains(chosenGesture))
            {
                
                    Console.WriteLine($"{name} please choose rock,paper,scissors,lizard, or spock");
                    chosenGesture = Console.ReadLine().ToLower();
            }

                
           

                Console.WriteLine($"{name} chooses {chosenGesture}");

            }
        }
    }

   
   