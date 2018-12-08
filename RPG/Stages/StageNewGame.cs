﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Classes;

namespace RPG.Stages
{
    class StageNewGame
    {
        public StageNewGame()
        {

            Console.Clear();

            Console.WriteLine("Witaj! Zanim rozpoczniesz przygodę, powiedz mi coś o sobie. Jak masz na imię?");
            Console.Write("Nazywam się "); Player.name = Console.ReadLine();


            while (Player.characterClass == Player.CharacterClasses.NONE)
            {
                Console.Clear();

                Console.WriteLine("Powiedz mi {0}, jesteś [1]Wojownikiem czy [2]Magiem?", Player.name);
                var choice = Console.ReadKey(true).Key;


                switch (choice)
                {
                    case ConsoleKey.D1:
                        Player.characterClass = Player.CharacterClasses.WARRIOR;
                        Player.Power = 1;
                        break;
                    case ConsoleKey.D2:
                        Player.characterClass = Player.CharacterClasses.MAGE;
                        Player.Strength = 1;
                        break;
                }

                StageManager.stageNumber = 1;
            }
        }
    }
}