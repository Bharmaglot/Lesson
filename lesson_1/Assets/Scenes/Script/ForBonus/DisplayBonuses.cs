using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

namespace Geekbrains
{
    public sealed class DisplayBonuses
    {





        private Text _text;
        public int score = 0;
        public DisplayBonuses()
        {
            _text = Object.FindObjectOfType<Text>();
        }
        public void Display(int value)
        {
            _text.text = $"�� ������� {score + value}";
        }


        //public void Display(int value)
        //{
        //    Debug.Log($"�� ��������: {value}");
        //}
    }
}