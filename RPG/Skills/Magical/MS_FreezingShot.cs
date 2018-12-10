using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Skills.Magical
{
    class MS_FreezingShot : SkillPreset
    { 

        public int freezeChance;
        public bool freezeSucces;
        public MS_FreezingShot()
        {
            skillType = SkillType.Magiczny;
            skillCostCharacter = SkillCostCharacter.M;
            skillName = "Zamrażający pocisk";
            damage = 1 * playerPower;
            freezeChance = 30;
            freezeSucces = false;
            cost = 2;
        }

        public override void SpecialEffect()
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 101);
            if (number <= freezeChance)
            {
                freezeSucces = true;
            } else
            {
                freezeSucces = false;
            }
        }
    }
}
