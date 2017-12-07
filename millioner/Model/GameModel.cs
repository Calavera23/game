using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace millioner
{
    class GameModel
    {
        public List<Question> listQuestion;
        public bool call;
        public bool fifty;
        public bool hall;
        public int lvl;
        public bool gameover;
        public GameModel() { gameover = false; call = true; fifty = true; hall = true; lvl = 1; listQuestion = new List<Question>(); }
        public string Answer
        { set; get; }
        public bool IsCorrect()
        {
            if (Answer == listQuestion[lvl].a1_right)
            {
                ++lvl;
                return true;

            }
            return false;
        }


    }
}
