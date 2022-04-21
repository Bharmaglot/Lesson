using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Geekbrains
{

    public sealed class CameraController : MonoBehaviour
    {

        public Player Player;
        private Vector3 _offset;

        void Start()
        {
            _offset = transform.position - Player.transform.position;
        }

    
        void LateUpdate()
        {
            transform.position = Player.transform.position + _offset;
        }
    }

}