using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
using System;

namespace Geekbrains
{  
    public sealed class FastDieBonus : InteractiveObject, IFlay
    {
        private float _lengthFlay;
        private float _speedRotation;

        public delegate void CaughtPlayerChange(object value);
        
        private event EventHandler<CaughtPlayerEventArgs> _caugthPlayer;
        public event EventHandler<CaughtPlayerEventArgs> CaughtPlayer
        {
            add { _caugthPlayer += value; }
            remove { _caugthPlayer -= value; }
        }

        private void Awake()
        {
            _lengthFlay = Random.Range(1.0f, 10.0f);
        }

        public void Flay()
        {
            transform.localPosition = new Vector3(transform.localPosition.x,
                Mathf.PingPong(Time.time, _lengthFlay),
                transform.localPosition.z);
        }
        protected override void Interaction(Player player)
        {
            _caugthPlayer?.Invoke(this, new CaughtPlayerEventArgs(_color));
        }

    }
}