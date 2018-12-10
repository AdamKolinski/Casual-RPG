using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Enemies;
using RPG.Skills;
using RPG.Skills.Magical;
using RPG.Skills.Physical;

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
        public static int strength = 3;
        public static int maxStamina = 20, currentStamina = 20;
        public static int power = 3;
        public static int maxMana = 20, currentMana = 20;
        public static SkillPreset[] learnedSkills = new SkillPreset[4];


        public static void InitializeCharacterClass(CharacterClasses c)
        {
            switch (c)
            {
                case CharacterClasses.Wojownik:
                    characterClass = Player.CharacterClasses.Wojownik;
                    power = 1;
                    learnedSkills[2] = new PS_Stomp();
                    break;
                case CharacterClasses.Mag:
                    characterClass = Player.CharacterClasses.Mag;
                    strength = 1;
                    learnedSkills[1] = new MS_FreezingShot();
                    learnedSkills[2] = new MS_FireBall();
                    learnedSkills[3] = new MS_HealingSalve();
                    //Console.ReadKey();
                    break;
            }
        }

        public static void Movement(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.D:
                    if (MapGenerator.mapCharacters[xPos + 1, yPos] == " ")
                    {
                        MapGenerator.mapCharacters[xPos, yPos] = " ";
                        MapGenerator.mapCharacters[xPos + 1, yPos] = characterSign;
                        xPos++;
                    }
                    else if (MapGenerator.mapCharacters[xPos + 1, yPos] == "W" || MapGenerator.mapCharacters[xPos + 1, yPos] == "w")
                    {
                        CombatManager combat = new CombatManager();
                        combat.Fight(new WolfEnemy(), xPos + 1, yPos);
                    }
                    break;
                case ConsoleKey.A:
                    if (MapGenerator.mapCharacters[xPos - 1, yPos] == " ")
                    {
                        MapGenerator.mapCharacters[xPos, yPos] = " ";
                        MapGenerator.mapCharacters[xPos - 1, yPos] = characterSign;
                        xPos--;
                    }
                    else if (MapGenerator.mapCharacters[xPos - 1, yPos] == "W" || MapGenerator.mapCharacters[xPos - 1, yPos] == "w")
                    {
                        CombatManager combat = new CombatManager();
                        combat.Fight(new WolfEnemy(), xPos - 1, yPos);
                    }
                    break;
                case ConsoleKey.W:
                    if (MapGenerator.mapCharacters[xPos, yPos - 1] == " ")
                    {
                        MapGenerator.mapCharacters[xPos, yPos] = " ";
                        MapGenerator.mapCharacters[xPos, yPos - 1] = characterSign;
                        yPos--;
                    }
                    else if (MapGenerator.mapCharacters[xPos, yPos - 1] == "W" || MapGenerator.mapCharacters[xPos, yPos - 1] == "w")
                    {
                        CombatManager combat = new CombatManager();
                        combat.Fight(new WolfEnemy(), xPos, yPos - 1);
                    }
                    break;
                case ConsoleKey.S:
                    if (MapGenerator.mapCharacters[xPos, yPos + 1] == " ")
                    {
                        MapGenerator.mapCharacters[xPos, yPos] = " ";
                        MapGenerator.mapCharacters[xPos, yPos + 1] = characterSign;
                        yPos++;
                    }
                    else if (MapGenerator.mapCharacters[xPos, yPos + 1] == "W" || MapGenerator.mapCharacters[xPos, yPos + 1] == "w")
                    {
                        CombatManager combat = new CombatManager();
                        combat.Fight(new WolfEnemy(), xPos, yPos + 1);
                    }
                    break;
            }
        }

        public static void UseSkill(int skillNumber, EnemyPreset enemy)
        {
            if (learnedSkills[skillNumber].skillType == SkillPreset.SkillType.Magiczny)
            {
                currentMana -= learnedSkills[skillNumber].cost;
            }
            else if (learnedSkills[skillNumber].skillType == SkillPreset.SkillType.Fizyczny)
            {
                currentStamina -= learnedSkills[skillNumber].cost;
            }

            enemy.currentHP -= learnedSkills[skillNumber].damage;
        }

        public static void ShowStats()
        {
            Console.WriteLine("HP: {0}/{1}, Siła: {2}, Moc: {3}, Wytrzymałość: {4}/{5}, Mana: {6}/{7}    (c)Pokaż więcej", currentHP, maxHP, strength, power, currentStamina, maxStamina, currentMana, maxMana);
        }

        public static void ShowStats(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write("HP: {0}/{1}, Siła: {2}, Moc: {3}, Wytrzymałość: {4}/{5}, Mana: {6}/{7}    (c)Pokaż więcej", currentHP, maxHP, strength, power, currentStamina, maxStamina, currentMana, maxMana);
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
            Console.WriteLine("Siła: {0}", strength);
            Console.WriteLine("Moc: {0}", power);
            Console.WriteLine("Wytrzymałość: {0}/{1}", currentStamina, maxStamina);
            Console.WriteLine("Mana: {0}/{1}", currentMana, maxMana);
            Console.ReadKey(true);
        }
    }
}
