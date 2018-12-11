using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Enemies
{
    class WolfEnemy : EnemyPreset
    {

        public WolfEnemy()
        {
            name = "Wilk";
            maxHP = 10;
            currentHP = maxHP;
            strength = 2;
            power = 0;
        }
    }
}
