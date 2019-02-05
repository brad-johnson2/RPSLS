using System;
using System.Collections.Generic;

namespace RockProject
{
    public class HumanPlayer : Player
    {
        public HumanPlayer()
        {
        }

        public override void ChooseGesture(List<string> gestures)
        {
            Console.WriteLine($"Choose Gesture: 1){gestures[0]} 2){gestures[1]} 3){gestures[2]} 4){gestures[3]} 5){gestures[4]}");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    gesture = gestures[0];
                    break;
                case "2":
                    gesture = gestures[1];
                    break;
                case "3":
                    gesture = gestures[2];
                    break;
                case "4":
                    gesture = gestures[3];
                    break;
                case "5":
                    gesture = gestures[4];
                    break;
                default:
                    ChooseGesture(gestures);
                    break;

            }
        }
    }
}
