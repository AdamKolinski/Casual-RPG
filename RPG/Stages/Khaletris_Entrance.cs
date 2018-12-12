using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Classes;

namespace RPG.Stages
{
    class Khaletris_Entrance : StagePreset
    {

        public Khaletris_Entrance()
        {
            Player.ShowStats(0, 0, true);
            Console.WriteLine("Khaletris");
            Console.WriteLine(new string(' ', Console.WindowWidth - 1));
            MapGenerator.DrawMap();
            GameLoop.GetKeyboardInput();
        }
    }
}
