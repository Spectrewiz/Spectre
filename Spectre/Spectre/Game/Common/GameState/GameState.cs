using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spectre.Game.Common.GameState
{
    public delegate void ChangeGameStateHandler(State state, EventArgs e);

    public enum State
    {
        MainMenu,
        PauseMenu,
        Inventory,
        Game,
        Quit
    }

    public class GameState
    {
        public static State currentGameState;

        public static event ChangeGameStateHandler ChangeGameState;
        protected static void onChangeGameState(State state, EventArgs args)
        {
            if (ChangeGameState != null)
            {
                ChangeGameState(state, args);
            }
        }

        public static void changeGameState(State state)
        {
            currentGameState = state;
            onChangeGameState(state, EventArgs.Empty);
        }
    }
}
