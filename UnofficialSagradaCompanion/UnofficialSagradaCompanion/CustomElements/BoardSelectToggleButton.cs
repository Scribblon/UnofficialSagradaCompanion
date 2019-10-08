using System;
using System.Collections.Generic;
using System.Text;
using UnofficialSagradaCompanion.Resources;

namespace UnofficialSagradaCompanion.CustomElements
{
    class BoardSelectToggleButton : ToggleButton
    {
        public PlayerBoard ButtonOfBoard { get; private set; }
        public BoardSelectToggleButton(PlayerBoard board)
        {
            ButtonOfBoard = board;
        }
    }
}
