using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace millioner
{
    class GamePresenter
    {
        private readonly GameModel _model = new GameModel();
        private readonly IGameView _view;
        public GamePresenter(IGameView view)
        {
            _view = view;
            // Презентер подписывается на уведомления о событиях Представления
            _view.Answer += new EventHandler<EventArgs>(OnAnswer);
            _view.NewGame += new EventHandler<EventArgs>(OnNewGame);
            _view.Exit += new EventHandler<EventArgs>(OnExit);
            _view.Stop += new EventHandler<EventArgs>(OnStop);



        }
        private void OnAnswer(object sender, EventArgs e)
        {
            // В ответ на изменения в Представлении необходимо изменить Модель
            _model.Answer = _view.answ;
            if (_model.IsCorrect())
                _view.Proceed();
            else
                _view.Fail();
            // В данной форме этот вызов не нужен, однако в общем
            // случае изменение части Модели может привести к изменениям
            // в других ее частях. Поэтому необходимо синхронизировать
            // Представление с новым текущим состоянием Модели.
        }
        private void OnNewGame(object sender, EventArgs e)
        {
            _view.MakeVisible();
           
        }
        private void OnExit(object sender,EventArgs e)
        {
            _view.Quit();
        }
        private void OnStop(object sender, EventArgs e)
        {
            _view.MakeInvisible();
        }

    }
}
