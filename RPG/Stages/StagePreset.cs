using System;
using RPG.Classes;

namespace RPG.Stages
{
    using RPG.Classes;
    public class StagePreset
    {
        public MapGenerator mapGenerator = new MapGenerator();
        public static bool mapLoaded = false;
        public StagePreset()
        {
            Console.Clear();
            if (mapLoaded == false)
            {
                mapGenerator.GenerateMapFromFile();
                mapLoaded = true;
            }
        }
    }
}
