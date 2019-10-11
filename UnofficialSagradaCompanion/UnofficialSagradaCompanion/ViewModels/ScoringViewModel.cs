using System;
using System.Collections.Generic;
using System.Text;
using UnofficialSagradaCompanion.Resources;

namespace UnofficialSagradaCompanion.ViewModels
{
    class ScoringViewModel : ViewModelBase
    {
        // The set acquired in the constructor
        private Dictionary<PlayerBoard, string> players;
        // The Dictionaries for keeping track of player scores
        private Dictionary<PlayerBoard, int> glassScore = new Dictionary<PlayerBoard, int>();
        private Dictionary<PlayerBoard, int> common1Score = new Dictionary<PlayerBoard, int>();
        private Dictionary<PlayerBoard, int> common2Score = new Dictionary<PlayerBoard, int>();
        private Dictionary<PlayerBoard, int> common3Score = new Dictionary<PlayerBoard, int>();
        private Dictionary<PlayerBoard, int> secretScore = new Dictionary<PlayerBoard, int>();

        public String PlayerCount
        {
            get
            {
                return players.Count.ToString();
            }

            private set { }
        }
         
        public ScoringViewModel(Dictionary<PlayerBoard, string> currentPlayers)
        {
            players = currentPlayers;
            // Generate the other sets
            foreach (KeyValuePair<PlayerBoard, string> kvp in players)
            {
                glassScore.Add(kvp.Key, -1);
                common1Score.Add(kvp.Key, -1);
                common2Score.Add(kvp.Key, -1);
                common3Score.Add(kvp.Key, -1);
                secretScore.Add(kvp.Key, -1);
            }
        }
    }
}
