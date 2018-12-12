using System;
using RPG.NPC;
using System.Threading;

namespace RPG.Classes
{
    public class GameLoop
    {
        public enum GameStates { Playing, Menu, Pause , Exit }
        public static GameStates gameState = GameStates.Menu;
        private Player player = new Player();

        internal Player Player { get => player; set => player = value; }

        static void Main(string[] args)
        {
            MenuManager menu = new MenuManager();
            Player.InitializeCharacterClass(Player.CharacterClasses.Brak);
            StageManager stageManager = new StageManager();
            //Console.OutputEncoding = System.Text.Encoding.Unicode;
            while (gameState != GameStates.Exit)
            {
                switch (gameState)
                {
                    case GameStates.Playing:
                        stageManager.LoadStage();
                        break;
                    case GameStates.Menu:
                        menu.MainMenu();
                        break;
                    case GameStates.Pause:
                        menu.PauseMenu();
                        break;
                }
            }
        }

        public static void ClearKeyBuffer()
        {
            while (Console.KeyAvailable)
                Console.ReadKey(true);
        }

        public static void GetKeyboardInput()
        {
            ClearKeyBuffer();
            var keyPressed = Console.ReadKey(true).Key;
            switch (keyPressed)
            {
                case ConsoleKey.W:
                    Player.Movement(ConsoleKey.W);
                    break;
                case ConsoleKey.S:
                    Player.Movement(ConsoleKey.S);
                    break;
                case ConsoleKey.A:
                    Player.Movement(ConsoleKey.A);
                    break;
                case ConsoleKey.D:
                    Player.Movement(ConsoleKey.D);
                    break;
                
                case ConsoleKey.C:
                    Player.ShowStatsDetailed();
                    break;

                case ConsoleKey.Escape:
                    GameLoop.gameState = GameStates.Pause;
                    break;

                default:
                    break;
            }
            Thread.Sleep(30);


        }
    }
}
