using System;
using System.IO;
using RPG.Enemies;

namespace RPG.Classes
{
    public class MapGenerator
    {
        public static int width = 0, height = 0, x = 0, y = 0;
        public static string[,] mapCharacters;
        public static string[,] prevMapCharacters;
        public static bool spawnedPlayer = false;

        public MapGenerator()
        {

        }

        public void GenerateMapFromFile()
        {
            FileStream fs = new FileStream("Maps/Location_2.txt", FileMode.Open, FileAccess.Read);
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

            mapCharacters = new string[width, height];

            fs.Close();
            sr.Close();

            fs = new FileStream("Maps/Location_2.txt", FileMode.Open, FileAccess.Read);
            sr = new StreamReader(fs);

            x = Console.CursorLeft;
            y = Console.CursorTop + 1;
            //Console.WriteLine(Player.xPos + ", " + Player.yPos);

            for (int i = 0; i < height; i++)
            {
                line = sr.ReadLine().Replace("\t", "");
                for (int j = 0; j < line.Length; j++)
                {

                    if (line[j].ToString().Equals("s"))
                    {
                        if (spawnedPlayer == false)
                        {
                            mapCharacters[j, i] = Player.characterSign;
                            Player.xPos = j;
                            Player.yPos = i;
                            spawnedPlayer = true;
                        }
                        else
                        {
                            if (j != Player.xPos || i != Player.yPos)
                                mapCharacters[j, i] = line[j].ToString().Replace("s", " ");
                            if ((j == Player.xPos && i == Player.yPos))
                                mapCharacters[j, i] = Player.characterSign;
                        }
                    }
                    else
                    {
                        if (j == Player.xPos && i == Player.yPos)
                        {
                            mapCharacters[j, i] = Player.characterSign;
                        }
                        else
                        {
                            mapCharacters[j, i] = line[j].ToString();
                        }
                    }
                    //map[j, i] = line[0].ToString();
                }
            }
        }

        public static void DrawMap()
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    foreach (string x in EnemyPreset.EnemySigns)
                    {
                        if (x.Equals(mapCharacters[j, i]))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                    }
                    if (mapCharacters[j, i] == "N") Console.ForegroundColor = ConsoleColor.Yellow;
                    if (mapCharacters[j, i] == Player.characterSign) Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(mapCharacters[j, i]);
                    Console.ResetColor();
                }
                Console.WriteLine();
            }

            
        }

        public static void UpdateMap()
        {

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (prevMapCharacters[j, i] != mapCharacters[j, i])
                    {
                        Console.SetCursorPosition(j, 5+i);
                        Console.Write(mapCharacters[j, i]);
                    }
                }
            }
        }
    }
}
