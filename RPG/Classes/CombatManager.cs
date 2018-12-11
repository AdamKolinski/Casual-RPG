using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using RPG.Enemies;

namespace RPG.Classes
{
    using static Console;
    class CombatManager
    {
        int dealtDmg, turnNumber;
        bool battleStarted;
        public CombatManager()
        {
            dealtDmg = 0;
            turnNumber = 0; 
            battleStarted = false;
        }

        public void Fight(EnemyPreset enemy, int enemyPosX, int enemyPosY)
        {
            while (enemy.currentHP >= 0 && Player.currentHP >= 0)
            {
                Clear();
                battleStarted = true;
                SetCursorPosition(0, 0);
                WriteLine("Walczysz z {0}", enemy.name);
                WriteLine("HP: {0}/{1}", enemy.currentHP, enemy.maxHP);
                WriteLine("Siła: {0}", enemy.strength);
                WriteLine("Moc: {0}", enemy.power);

                Player.ShowStats(0, 29);

                if(turnNumber % 2 == 0) {

                    SetCursorPosition(0, 20);
                    WriteLine("Wybierz atak:");
                    WriteLine("1] Atak podstawowy   2W");
                    WriteLine("2] {0}   {1}{2}", Player.learnedSkills[1].skillName, Player.learnedSkills[1].cost, Player.learnedSkills[1].skillCostCharacter);
                    WriteLine("3] {0}   {1}{2}", Player.learnedSkills[2].skillName, Player.learnedSkills[2].cost, Player.learnedSkills[2].skillCostCharacter);
                    WriteLine("4] {0}   {1}{2}", Player.learnedSkills[3].skillName, Player.learnedSkills[3].cost, Player.learnedSkills[3].skillCostCharacter);

                    var choice = ReadKey().Key;

                    switch (choice)
                    {
                        case ConsoleKey.D1:
                            break;
                        case ConsoleKey.D2:
                            Player.learnedSkills[1].SpecialEffect();
                            Player.UseSkill(1, enemy);
                            dealtDmg = Player.learnedSkills[1].damage;
                            break;
                        case ConsoleKey.D3:
                            Player.learnedSkills[2].SpecialEffect();
                            Player.UseSkill(2, enemy);
                            dealtDmg = Player.learnedSkills[2].damage;
                            break;
                        case ConsoleKey.D4:
                            Player.learnedSkills[3].SpecialEffect();
                            Player.UseSkill(3, enemy);
                            dealtDmg = Player.learnedSkills[3].damage;
                            break;
                        default:
                            break;
                    }

                    SetCursorPosition(0, 15);
                    WriteLine("{0} otrzymał {1} obrażeń!", enemy.name, dealtDmg);

                    turnNumber++;
                    Thread.Sleep(1000);
                } else if(turnNumber % 2 == 1)
                {
                    dealtDmg = Player.GetDamage(enemy.strength); ;
                    SetCursorPosition(0, 15);
                    WriteLine("{0} otrzymał {1} obrażeń!", Player.name, dealtDmg);

                    turnNumber++;
                    Thread.Sleep(1000);
                }
            }
            if(enemy.currentHP <= 0)
            {
                Player.currentXP += enemy.XP;
                Clear();
                WriteLine("Pokonałeś {0}!", enemy.name);
                WriteLine("Zdobyte doświadczenie: {0}XP", enemy.XP);
                WriteLine("Twoje aktualne doświadczenie: {0}XP/{1}XP", Player.currentXP, Player.nextLvlXP);


                ReadKey();
                MapGenerator.mapCharacters[enemyPosX, enemyPosY] = " ";
                MapGenerator.mapCharacters[Player.xPos, Player.yPos] = " ";
                Player.xPos = enemyPosX;
                Player.yPos = enemyPosY;
                MapGenerator.mapCharacters[Player.xPos, Player.yPos] = Player.characterSign;
            }
        }
    }
}
