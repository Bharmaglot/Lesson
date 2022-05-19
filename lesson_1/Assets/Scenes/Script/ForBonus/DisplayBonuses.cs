using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

namespace Geekbrains
{
    public sealed class DisplayBonuses
    {


        public void Display(int value)
        {
            Debug.Log($"Вы получили: {value}");
        }
    }
}