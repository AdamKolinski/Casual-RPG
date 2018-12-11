using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Classes;

namespace RPG.Skills.Magical
{
    class MS_FreezingShot : SkillPreset
    { 

        public int freezeChance, freezeDuration;
        public bool freezeSucces;
        public MS_FreezingShot()
        {
            skillType = SkillType.Magiczny;
            skillCostCharacter = SkillCostCharacter.M;
            skillName = "Zamrażający pocisk";
            damage = 1 * playerPower;
            freezeChance = 30;
            freezeDuration = 1;
            freezeSucces = false;
            cost = 2;
        }

        public override void SpecialEffect()
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 101);
            if (number <= freezeChance)
            {
                CombatManager.turnNumber++;
                Console.WriteLine("Przeciwnik został zamrożony na {0} turę!", freezeDuration);
            } else
            {
                freezeSucces = false;
            }
        }
    }
}
