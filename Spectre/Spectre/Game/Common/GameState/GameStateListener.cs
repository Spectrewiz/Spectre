using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spectre.Game.Common.GameState
{
    public class GameStateListener
    {
        public GameStateListener()
        {
            GameState.ChangeGameState += new ChangeGameStateHandler(listener);
        }

        public void listener(State state, EventArgs args)
        {
            //TODO: add listening logic here
        }

        public void detach()
        {
            GameState.ChangeGameState -= new ChangeGameStateHandler(listener);
        }
    }
}
