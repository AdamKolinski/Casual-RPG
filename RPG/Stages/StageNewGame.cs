using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Classes;
using RPG.NPC;

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

                while (Player.characterClass == Player.CharacterClasses.Brak)
                {
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
                }

                Console.Clear();
                Console.Write("Podaj imię swojego dawnego przyjaciela: ");
                Companion.name = Console.ReadLine();
                Console.Clear();
                Console.WriteLine($"Na odludziu żył sobie {Player.name}, niegdyś potężny, lecz teraz pozbawiony dawnej chwały i umiejętności {Player.characterClass}.\n" +
                    $"Pewnego dnia odwiedził go jego stary przyjaciel, {Companion.name}. Ten powiedział mu, że zagłada świata jest blisko,\n" +
                    $"ponieważ Gorgoth zebrał siły, aby przejąć 3 Artefakty Równowagi... {Player.name} postanowił odrzucić życie pustelnika i powrócić do dawnej siły, aby przeszkodzić Gorgothowi w przejęciu Artefaktów Równowagi, które dadzą mu władzę nad światem.\n" +
                    $"{Companion.name} usłyszał tylko podziękowania rzucone z daleka, ponieważ {Player.name} biegł już ku przygodzie.\n" +
                    $"Spotkajmy się w Khaletris! Krzyknął do {Player.characterClass}a.");
                Console.ReadKey();

                StageManager.currentStage = StageManager.Stages.Khaletris_Gate;
                StagePreset.mapLoaded = false;
            }
        }
    }
}
