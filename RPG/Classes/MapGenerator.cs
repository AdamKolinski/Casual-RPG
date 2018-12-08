using System;
using System.IO;

namespace RPG.Classes
{
    class MapGenerator
    {
        int width = 0, height = 0, x = 0, y = 0;
        public static string[,] mapCharatcers;

        public MapGenerator()
        {
            
        }

        public void DrawMap()
        {
            FileStream fs = new FileStream("Maps/Location_1.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            int lineWidth = 0;
            string line;
            while (!sr.EndOfStream)
            {
                line = sr.ReadLine().Replace("\t", "");

                //Console.WriteLine(line);
                lineWidth = line.Length;

                if (lineWidth > width)
                {
                    width = lineWidth;
                }
                height++;
            }

            mapCharatcers = new string[width, height];

            fs.Close();
            sr.Close();

            fs = new FileStream("Maps/Location_1.txt", FileMode.Open, FileAccess.Read);
            sr = new StreamReader(fs);

            x = Console.CursorLeft;
            y = Console.CursorTop+1;
            Console.WriteLine(Player.xPos + ", " + Player.yPos);

            for (int i = 0; i < height; i++)
            {
                line = sr.ReadLine().Replace("\t", "");
                for (int j = 0; j < line.Length; j++)
                {

                    if (j == Player.xPos && i == Player.yPos)
                    {
                        mapCharatcers[j, i] = Player.characterSign;
                    } else {

                        mapCharatcers[j, i] = line[j].ToString();
                    }
                    Console.Write(mapCharatcers[j, i]);
                    //map[j, i] = line[0].ToString();
                }
                Console.WriteLine();
            }
        }
    }
}
