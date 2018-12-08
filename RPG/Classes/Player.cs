using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Classes
{
    class Player
    {
        public enum CharacterClasses { WARRIOR, MAGE, NONE }
        public static CharacterClasses characterClass = CharacterClasses.NONE;
        public static string characterSign = "×";
        public static int xPos = 2, yPos = 2;
        public static string name = "John";
        public static int maxHP = 10, currentHP = 10;
        public static int Strength = 3;
        public static int maxStamina = 20, currentStamina = 20;
        public static int Power = 3;
        public static int maxMana = 20, currentMana = 20;


        public static void Movement()
        {
            switch(Console.ReadKey().Key){
                case ConsoleKey.D:
                    if (MapGenerator.mapCharatcers[xPos + 1, yPos] == " ") {
                        MapGenerator.mapCharatcers[xPos, yPos] = " ";
                        MapGenerator.mapCharatcers[xPos + 1, yPos] = characterSign;
                        xPos++;
                    }
                    break;
                case ConsoleKey.A:
                    if (MapGenerator.mapCharatcers[xPos - 1, yPos] == " ")
                    {
                        MapGenerator.mapCharatcers[xPos, yPos] = " ";
                        MapGenerator.mapCharatcers[xPos - 1, yPos] = characterSign;
                        xPos--;
                    }
                    break;
                case ConsoleKey.W:
                    if (MapGenerator.mapCharatcers[xPos, yPos - 1] == " ")
                    {
                        MapGenerator.mapCharatcers[xPos, yPos] = " ";
                        MapGenerator.mapCharatcers[xPos, yPos - 1] = characterSign;
                        yPos--;
                    }
                    break;
                case ConsoleKey.S:
                    if (MapGenerator.mapCharatcers[xPos, yPos + 1] == " ")
                    {
                        MapGenerator.mapCharatcers[xPos, yPos] = " ";
                        MapGenerator.mapCharatcers[xPos, yPos + 1] = characterSign;
                        yPos++;
                    }
                    break;
            }
        }
    }
}
