using System;
using System.Collections.Generic;
using System.Text;
using UnofficialSagradaCompanion.Models.Resources;

namespace UnofficialSagradaCompanion.Models
{
    struct DefaultSettingsModel
    {
        public static readonly Dictionary<PlayerBoard, bool> DefaultActiveBoards = new Dictionary<PlayerBoard, bool>() {
                {PlayerBoard.Blue, true},
                {PlayerBoard.Green, true},
                {PlayerBoard.Orange, true},
                {PlayerBoard.Purple, true},
                {PlayerBoard.Red, false},
                {PlayerBoard.Yellow, false}
            };
    }
}
