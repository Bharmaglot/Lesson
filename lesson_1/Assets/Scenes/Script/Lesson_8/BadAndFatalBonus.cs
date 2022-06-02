using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Geekbrains
{
    public class BadAndFatalBonus : InteractiveObject, IFlay
    {
        private float _lengthFlay;


        private sealed class BadAndFatalBonusC
        {
            private float _timer = 5;
            private double _slowPlayer = 0.5;
            

            public (float timer, double slowPlayer) GetOnt()
            {
                return (_timer, _slowPlayer);
            }
        }



    private void Awake()
        {
            _lengthFlay = Random.Range(1.0f, 5.0f);
        }

        protected override void Interaction(Player player)
        {
            (float timer, double slowPlayer) BadAndFatalBonusCOnt = (10, 0.5);
            player.CorrectSpeedPlayer(BadAndFatalBonusCOnt.timer, BadAndFatalBonusCOnt.slowPlayer);
        }

       

       

        public void Flay()
        {
            transform.localPosition = new Vector3(transform.localPosition.x,
                Mathf.PingPong(Time.time, _lengthFlay),
                transform.localPosition.z);
        }
    }
}
