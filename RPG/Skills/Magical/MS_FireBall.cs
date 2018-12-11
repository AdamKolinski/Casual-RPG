using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Skills.Magical
{
    class MS_FireBall : SkillPreset
    {
        public MS_FireBall()
        {
            InitializeSkillValues();
        }

        public override void InitializeSkillValues()
        {
            base.InitializeSkillValues();
            skillType = SkillType.Magiczny;
            skillCostCharacter = SkillCostCharacter.M;
            skillName = "Kula ognia";
            damage = 2 * playerPower;
            cost = 2;
        }
    }
}
