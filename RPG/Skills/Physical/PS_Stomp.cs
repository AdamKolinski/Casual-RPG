using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Skills.Physical
{
    class PS_Stomp : SkillPreset
    {
        public PS_Stomp()
        {
            skillType = SkillType.Fizyczny;
            skillName = "Tąpnięcie";
            damage = 2 * playerStrength;
            cost = 3;
        }

    }
}
