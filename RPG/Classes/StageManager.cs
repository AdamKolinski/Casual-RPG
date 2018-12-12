using System;
using RPG.Stages;

namespace RPG.Classes
{
    public class StageManager
    {
        public enum Stages { NewGame, Khaletris_Gate, Khaletris_Entrance }
        public static Stages currentStage = Stages.NewGame;
        //public static int stageNumber = 1;

        public void LoadStage()
        {
            switch (currentStage)
            {
                case Stages.NewGame:
                    StageNewGame stageNewGame = new StageNewGame();
                    break;
                case Stages.Khaletris_Gate:
                    StageOne stageOne = new StageOne();
                    break;
                case Stages.Khaletris_Entrance:
                    Khaletris_Entrance khaletris_Entrance = new Khaletris_Entrance();
                    break;
            }
        }
    }
}
