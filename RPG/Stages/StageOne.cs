using System;
using RPG.Classes;

namespace RPG.Stages
{
    public class StageOne : StagePreset
    {
        //MapGenerator f = new MapGenerator();
        public StageOne()
        {
            Player.ShowStats();
            Console.WriteLine("Czas i miejsce akcji: Wieczór, karczma");
            Console.WriteLine("Siedzisz przy stole popijając kufel grzańca.");
            Console.WriteLine("Kończysz pić grzańca, co robisz?");
            Console.WriteLine("Mapa:");
            //MapGenerator mapGenerator = new MapGenerator(1);
            //mapGenerator.DrawMap(1);
            //f.GenerateMapFromFile();
            //mapGenerator.DrawMap();
            MapGenerator.DrawMap();
            //Console.WriteLine(MapGenerator.mapCharacters[0, 0]);

            GameLoop.GetKeyboardInput();
            //Player.Movement();
            //Console.ReadKey(true);
            //GameLoop.gameState = GameLoop.GameStates.Exit;
        }
    }
}
