using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

namespace Geekbrains
{

    public sealed class ScoreForWin : MonoBehaviour
    {
        public int score;

        void takeScore(int value)
        {
            score = score + value; ;
          Debug.Log($"  {score}");
        }

        


    }
}