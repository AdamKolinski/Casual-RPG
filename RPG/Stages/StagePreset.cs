using System;
using RPG.Classes;

namespace RPG.Stages
{
    using RPG.Classes;
    public class StagePreset
    {
        public static MapGenerator mapGenerator = new MapGenerator();
        public static bool mapLoaded = false;
        public  string mapName;

        public StagePreset()
        {
            
            Console.CursorVisible = false;
            if (mapLoaded == false)
            {
                Player.xPos = -10;
                Player.yPos = -10;
                Console.Clear();
                mapGenerator.GenerateMapFromFile(StageManager.currentStage);
                //Console.SetCursorPosition(0, 5);
                //MapGenerator.prevMapCharacters = MapGenerator.mapCharacters;
                //MapGenerator.DrawMap();
                mapLoaded = true;
            }
        }
    }
}
