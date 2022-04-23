using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

namespace Geekbrains
{
    public sealed class DisplayBonuses
    {
        public int score;

        public void Display(int value)
        {
            this.score = score + value;
            Debug.Log($"Вы набрали: {score}");
            if(score > 3)
            {
                Debug.Log($"победа и вот это вот все");
            }   
            //Но score не прирастает..
        }
    }
}