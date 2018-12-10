using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Classes;

namespace RPG.Skills.Magical
{
    class MS_HealingSalve : SkillPreset
    {
        public int healing;
        public MS_HealingSalve()
        {
            skillType = SkillType.Magiczny;
            skillCostCharacter = SkillCostCharacter.M;
            skillName = "Lecząca Salwa";
            damage = 0;
            healing = 1 * playerPower;
            cost = 3;
        }

        public override void SpecialEffect()
        {
            Player.currentHP += healing;
            if (Player.currentHP > Player.maxHP) Player.currentHP = Player.maxHP;
            Console.SetCursorPosition(0, 16);
            Console.WriteLine("{0} użył {1}", Player.name, skillName);
        }
    }
}
