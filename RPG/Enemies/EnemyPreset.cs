﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Enemies
{
    class EnemyPreset
    {
        public static string[] EnemySigns = new string[] {"W", "S", "K"};
        public string name = "Enemy";
        public int currentHP, maxHP;
        public int strength, power;
        public int XP = 20;
    }
}
