using System;
using RPG.Classes;

namespace RPG.Stages
{
    public class StageOne : StagePreset
    {
        
        public StageOne()
        {
            Console.WriteLine("Czas i miejsce akcji: Wieczór, karczma");
            Console.WriteLine("Siedzisz przy stole popijając kufel grzańca.");
            Console.WriteLine("Kończysz pić grzańca, co robisz?");
            Console.WriteLine("Mapa:");
            //MapGenerator mapGenerator = new MapGenerator(1);
            //mapGenerator.DrawMap(1);
            MapGenerator f = new MapGenerator();
            f.DrawMap();

            Player.Movement();
            //Console.ReadKey(true);
            //GameLoop.gameState = GameLoop.GameStates.Exit;
        }
    }
}
