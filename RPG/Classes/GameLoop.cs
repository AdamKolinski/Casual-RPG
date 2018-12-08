using System;
namespace RPG.Classes
{
    public class GameLoop
    {
        public enum GameStates {Playing, Menu, Exit}
        public static GameStates gameState = GameStates.Menu;
        private Player player = new Player();

        internal Player Player { get => player; set => player = value; }

        static void Main(string[] args)
        {
            //Console.OutputEncoding = System.Text.Encoding.Unicode;
            while (gameState != GameStates.Exit)
            {
                switch (gameState)
                {
                    case GameStates.Playing:
                        StageManager stageManager = new StageManager();
                        stageManager.LoadStage(StageManager.stageNumber);
                        break;
                    case GameStates.Menu:
                        MenuManager menu = new MenuManager();
                        menu.MainMenu();
                        break;
                }
            }
        }
    }
}
