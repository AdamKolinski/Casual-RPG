using System;
using RPG.Classes;

namespace RPG.Stages
{
    public class StageOne : StagePreset
    {
        //MapGenerator f = new MapGenerator();
        public StageOne()
        {
            Player.ShowStats(0, 0, true);
            Console.WriteLine("Bramy Khaletris, wieczór");
            Console.WriteLine(new string(' ', Console.WindowWidth - 1));
            //MapGenerator mapGenerator = new MapGenerator(1);
            //mapGenerator.DrawMap(1);
            //f.GenerateMapFromFile();
            //mapGenerator.DrawMap();
            MapGenerator.DrawMap();
            GameLoop.GetKeyboardInput();


            //Console.WriteLine(MapGenerator.mapCharacters[0, 0]);
            

            if (Player.playerLvl == 1 && Player.xPos > 24 && Player.yPos > 3 && Player.yPos < MapGenerator.height - 4)
            {
                Console.SetCursorPosition(0, 29);
                Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("N");
                Console.ResetColor(); Console.Write(": Taki słabeusz jak ty ma wejść do miasta!? Wróć jak trochę poćwiczysz!");
            } else
            {
                Console.SetCursorPosition(0, 29);
                Console.Write(new string(' ', Console.WindowWidth-1)); 
            }
            if(Player.playerLvl > 1)
            {
                for (int i = 0; i < MapGenerator.height; i++)
                {
                    for (int j = 0; j < MapGenerator.width; j++)
                    {
                        if (MapGenerator.mapCharacters[j, i] == "|") MapGenerator.mapCharacters[j, i]=" ";
                    }
                }
            }
            // MapGenerator.prevMapCharacters = MapGenerator.mapCharacters;

            if (Player.xPos == MapGenerator.width - 1 && (Player.yPos == 7 || Player.yPos == 8))
            {
                StageManager.currentStage = StageManager.Stages.Khaletris_Entrance;
                StagePreset.mapLoaded = false;
            }
            //Player.Movement();
            //Console.ReadKey(true);
            //GameLoop.gameState = GameLoop.GameStates.Exit;
        }
    }
}
