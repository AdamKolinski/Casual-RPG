using System;
using RPG.Stages;

namespace RPG.Classes
{
    public class StageManager
    {
        public static int stageNumber = 1;

        public void LoadStage(int number) {
            switch(number) {
                case 0:
                    StageNewGame stageNewGame = new StageNewGame();
                    break;
                case 1:
                    StageOne stageOne = new StageOne();
                    break;
            }
        }
    }
}
