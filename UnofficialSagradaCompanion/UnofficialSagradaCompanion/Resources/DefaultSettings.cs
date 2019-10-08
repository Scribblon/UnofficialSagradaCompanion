using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using UnofficialSagradaCompanion.Resources;

namespace UnofficialSagradaCompanion.Models
{
    struct DefaultSettings
    {
        public static readonly ImmutableDictionary<PlayerBoard, bool> DefaultActiveBoards = new Dictionary<PlayerBoard, bool>() {
                {PlayerBoard.Blue, true},
                {PlayerBoard.Green, true},
                {PlayerBoard.Red, true},
                {PlayerBoard.Purple, true},
                {PlayerBoard.Orange, false},
                {PlayerBoard.Yellow, false}
            }.ToImmutableDictionary();
    }
}
