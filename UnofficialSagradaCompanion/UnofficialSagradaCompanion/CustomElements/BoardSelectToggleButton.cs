using System;
using System.Collections.Generic;
using System.Text;
using UnofficialSagradaCompanion.Resources;

namespace UnofficialSagradaCompanion.CustomElements
{
    class BoardSelectToggleButton : ToggleButton
    {
        public PlayerBoard ButtonBoard { get; private set; }
        public BoardSelectToggleButton(PlayerBoard board)
        {
            ButtonBoard = board;
        }
    }
}
