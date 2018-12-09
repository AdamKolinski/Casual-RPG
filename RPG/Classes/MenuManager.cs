using System;
using System.Text;

namespace RPG.Classes
{
    class MenuManager
    {


        public void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("   _____                      _   _____  _____   _____ ");
            Console.WriteLine("  / ____|                    | | |  __ \\|  __ \\ / ____|");
            Console.WriteLine(" | |     __ _ ___ _   _  __ _| | | |__) | |__) | |  __ ");
            Console.WriteLine(" | |    / _` / __| | | |/ _` | | |  _  /|  ___/| | |_ |");
            Console.WriteLine(" | |___| (_| \\__ \\ |_| | (_| | | | | \\ \\| |    | |__| |");
            Console.WriteLine("  \\_____\\__,_|___/\\__,_|\\__,_|_| |_|  \\_\\_|     \\_____|");
            Console.WriteLine();
            Console.WriteLine("1] Start");
            Console.WriteLine("2] Ustawienia");
            Console.WriteLine("3] Wyjście");

            var choice = Console.ReadKey(true).Key;

            switch (choice)
            {
                case ConsoleKey.D1:
                    GameLoop.gameState = GameLoop.GameStates.Playing;
                    break;
                case ConsoleKey.D2:
                    break;
                case ConsoleKey.D3:
                    //GameLoop.x = 1;
                    GameLoop.gameState = GameLoop.GameStates.Exit;
                    break;
            }
        }
        public void PauseMenu()
        {
            Console.Clear();
            Console.WriteLine("Pauza");
            Console.WriteLine("1] Wznów grę");
            Console.WriteLine("2] Zapisz grę (niedostępne)");
            Console.WriteLine("3] Wyjdź do menu głównego");

            var key = Console.ReadKey().Key;

            switch(key)
            {
                case ConsoleKey.D1:
                    GameLoop.gameState = GameLoop.GameStates.Playing;
                    break;
                case ConsoleKey.D2:
                    break;
                case ConsoleKey.D3:
                    GameLoop.gameState = GameLoop.GameStates.Menu;
                    break;
            }
        }
    }
}
