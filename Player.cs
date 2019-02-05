using System;
using System.Collections.Generic;

namespace RockProject
{
    public abstract class Player
    {
        public int score;
        public string gesture;

        public Player()
        {
            score = 0;
        }
        public abstract void ChooseGesture(List<string> gestures);
        
    }
}
