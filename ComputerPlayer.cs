using System;
using System.Collections.Generic;

namespace RockProject
{
    public class ComputerPlayer : Player
    {

        public ComputerPlayer()
        {
        }

        public override void ChooseGesture(List<string> gestures)
        {
            Random rnd = new Random();
            int compRand = rnd.Next(1, 6);

            switch (compRand)
            {
                case 1:
                    gesture = gestures[0];
                    break;
                case 2:
                    gesture = gestures[1];
                    break;
                case 3:
                    gesture = gestures[2];
                    break;
                case 4:
                    gesture = gestures[3];
                    break;
                case 5:
                    gesture = gestures[4];
                    break;
                default:
                    ChooseGesture(gestures);
                    break;
            }

        }
    }
}