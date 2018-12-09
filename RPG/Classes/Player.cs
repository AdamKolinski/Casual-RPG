using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Classes
{
    class Player
    {
        public enum CharacterClasses { Wojownik, Mag, Brak }
        public static CharacterClasses characterClass = CharacterClasses.Brak;
        public static string characterSign = "×";
        public static int xPos = 2, yPos = 2;
        public static string name = "John";
        public static int playerLvl = 1, currentXP = 0, nextLvlXP = 100;
        public static int maxHP = 10, currentHP = 10;
        public static int Strength = 3;
        public static int maxStamina = 20, currentStamina = 20;
        public static int Power = 3;
        public static int maxMana = 20, currentMana = 20;


        public static void Movement(ConsoleKey key)
        {
            switch(key){
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

        public static void ShowStats()
        {
            Console.SetCursorPosition(0, 31);
            Console.Write("HP: {0}/{1}, Strength: {2}, Power: {3}, Stamina: {4}/{5}, Mana: {6}/{7}", currentHP, maxHP, Strength, Power, currentStamina, maxStamina, currentMana, maxMana);
        }

        public static void ShowStatsDetailed()
        {
            Console.Clear();
            Console.WriteLine(name);
            Console.WriteLine();
            Console.WriteLine("Klasa: {0}", characterClass);
            Console.WriteLine("Poziom: {0}", playerLvl);
            Console.WriteLine("XP: {0}/{1}", currentXP, nextLvlXP);
            Console.WriteLine("HP: {0}/{1}", currentHP, maxHP);
            Console.WriteLine("Strength: {0}", Strength);
            Console.WriteLine("Power: {0}", Power);
            Console.WriteLine("Stamina: {0}/{1}", currentStamina, maxStamina);
            Console.WriteLine("Mana: {0}/{1}", currentMana, maxMana);
            Console.ReadKey(true);
        }
    }
}
