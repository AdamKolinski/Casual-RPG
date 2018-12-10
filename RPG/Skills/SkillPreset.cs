using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Classes;

namespace RPG.Skills
{
    class SkillPreset
    {
        public enum SkillType { Fizyczny, Magiczny, Brak}
        public SkillType skillType = SkillType.Brak;

        public enum SkillCostCharacter { W, M }
        public SkillCostCharacter skillCostCharacter = SkillCostCharacter.W;
        public string skillName = "Some skill";
        public int damage = 1;
        public int cost = 2;

        public int playerStrength = Player.strength;
        public int playerPower = Player.power;

        public virtual void SpecialEffect()
        {

        }
    }
}
