using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

namespace Geekbrains
{
    public sealed class DisplayEndGame
    {
        private Text _finishGameLabel;

        public DisplayEndGame(Text finishGameLabel)
        {
            _finishGameLabel = finishGameLabel;
            _finishGameLabel.text = string.Empty;
        }

        public void GameOver(object o, CaughtPlayerEventArgs args)
        {
            _finishGameLabel.text = $"Вы проиграли. Вас убил {((InteractiveObject)o).name}";
        }

        public void GameVictory()
        {
            _finishGameLabel.text = $"Вы победитель.";
        }
    }
}
