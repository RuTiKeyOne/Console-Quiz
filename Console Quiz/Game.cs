using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Quiz
{
    abstract class Game
    {
        internal int Score { get; set; } = 0;
        internal int Attempts { get; set; } = 1;

        internal const int Fine = 5000;

    }
    class Gamer : Game
    {
        

    }
}
