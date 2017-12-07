using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace millioner
{
    public interface IGameView
    {
        event EventHandler<EventArgs> Answer;
        event EventHandler<EventArgs> NewGame;
        event EventHandler<EventArgs> Stop;
        event EventHandler<EventArgs> Exit;
        event EventHandler<EventArgs> Edit;
        event EventHandler<EventArgs> Add;
        event EventHandler<EventArgs> Delete;
        string answ {get; }
        void Fail();
        void Proceed();
        void MakeVisible();
        void MakeInvisible();

        void Quit();
    }
}
