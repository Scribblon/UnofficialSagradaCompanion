using System;
using System.Collections.Generic;
using System.Text;
using UnofficialSagradaCompanion.Resources;
using Xamarin.Forms;

namespace UnofficialSagradaCompanion.CustomElements
{
    class PlayerEntry : Entry
    {
        public PlayerBoard BoardType { get; private set; }

        public PlayerEntry(PlayerBoard board)
        {
            BoardType = board;
        }
    }
}
