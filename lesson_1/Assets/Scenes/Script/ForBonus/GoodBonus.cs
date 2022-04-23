using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Geekbrains
{
    public sealed class GoodBonus : InteractiveObject, IFlay, IFlicker
    {
        private Material _material;
        private float _lenghtFlay;
        private DisplayBonuses _displayBonuses;
        private int score = 0;
        

        private void Awake()
        {
            _material = GetComponent<Renderer>().material;
            _lenghtFlay = Random.Range(1.0f, 5.0f);
            _displayBonuses = new DisplayBonuses();
            _displayBonuses = new DisplayBonuses();
        }



        protected override void Interaction()
        {
            score++;
            _displayBonuses.Display(score);
        }

        public void Flay()
        {
                transform.localPosition = new Vector3(transform.localPosition.x, 
                Mathf.PingPong(Time.time, _lenghtFlay), 
                transform.localPosition.z);
        }

        public void Flicker()
        {
            _material.color = new Color(_material.color.r, _material.color.g, _material.color.b,
                Mathf.PingPong(Time.time, 1.0f));
        }
    }
}