using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Geekbrains
{
    public class FlyCam : MonoBehaviour
    {
        private float _lengthFlay;


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






















        //public float _duration = .8f;
        //private Transform _cameraTransform;
        //private Vector3 _originalPosition;

        //void Start()
        //{
        //    _cameraTransform = GetComponent<Transform>();
        //    _originalPosition = _cameraTransform.transform.position;
        //}

        //public void Shake()
        //{
        //    StartCoroutine(_Shake());
        //}

        //IEnumerator _Shake()
        //{

        //    float x;
        //    float y;
        //    float timeLeft = Time.time;

        //    while ((timeLeft + _duration) > Time.time)
        //    {
        //        x = Random.Range(-0.3f, 0.3f);
        //        y = Random.Range(-0.3f, 0.3f);

        //        _cameraTransform.position = new Vector3(x, y, _originalPosition.z); yield return new WaitForSeconds(0.025f);
        //    }

        //    _cameraTransform.position = _originalPosition;

        //}
    }
}
