using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Geekbrains
{
    public class FatalBonus : InteractiveObject, IFlay
    {
        private float _lengthFlay;
        private int damage = 1;

        private void Awake()
        {
            _lengthFlay = Random.Range(1.0f, 5.0f);
        }

        public void Flay()
        {
            transform.localPosition = new Vector3(transform.localPosition.x,
                Mathf.PingPong(Time.time, _lengthFlay),
                transform.localPosition.z);
        }

        protected override void Interaction(Player player)
        {
            player.PlayerDamage(damage);
        }
    }
}