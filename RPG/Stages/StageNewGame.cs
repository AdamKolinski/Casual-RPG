using System;
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


            while (Player.characterClass == Player.CharacterClasses.Brak)
            {
                Console.Clear();

                Console.WriteLine("Powiedz mi {0}, jesteś [1]Wojownikiem czy [2]Magiem?", Player.name);
                var choice = Console.ReadKey(true).Key;


                switch (choice)
                {
                    case ConsoleKey.D1:
                        Player.InitializeCharacterClass(Player.CharacterClasses.Wojownik);
                        break;
                    case ConsoleKey.D2:
                        Player.InitializeCharacterClass(Player.CharacterClasses.Mag);
                        break;
                }

                StageManager.stageNumber = 1;
                StagePreset.mapLoaded = false;
            }
        }
    }
}
