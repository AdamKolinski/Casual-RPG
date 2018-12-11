using System;
using RPG.Classes;

namespace RPG.Stages
{
    using RPG.Classes;
    public class StagePreset
    {
        public static MapGenerator mapGenerator = new MapGenerator();
        public static bool mapLoaded = false;
        public StagePreset()
        {
            
            Console.CursorVisible = false;
            if (mapLoaded == false)
            {
                Console.Clear();
                mapGenerator.GenerateMapFromFile();
                Console.SetCursorPosition(0, 5);
                //MapGenerator.prevMapCharacters = MapGenerator.mapCharacters;
                //MapGenerator.DrawMap();
                mapLoaded = true;
            }
        }
    }
}
