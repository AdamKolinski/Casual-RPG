using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Classes;

namespace RPG.Skills.Physical
{
    class PS_Harden : SkillPreset
    {
        public PS_Harden()
        {
            skillType = SkillType.Fizyczny;
            skillCostCharacter = SkillCostCharacter.W;
            skillName = "Hart";
            damage = 0;
            cost = 2;
        }

        public override void SpecialEffect()
        {
            Player.dmgReduction = 2;
            Player.dmgReductionDuration += 2;
        }
    }
}
