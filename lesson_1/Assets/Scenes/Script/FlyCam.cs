using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Geekbrains
{
    public class FlyCam : MonoBehaviour
    {

        public float _duration = .8f;
        private Transform _cameraTransform;
        private Vector3 _originalPosition;


        public void Awake()
        {
            Player player = GameObject.FindObjectOfType<Player>();
            player.ObjBadInt += Shake;




            _cameraTransform = GetComponent<Transform>();
            _originalPosition = _cameraTransform.transform.position;

        }

        public void Shake()
        {
            StartCoroutine(_Shake());
        }

        IEnumerator _Shake()
        {


            float x;
            float y;
            float timeLeft = Time.time;

           Vector3 _basePosition = _cameraTransform.transform.position;

            while ((timeLeft + _duration) > Time.time)
            {
              x = Random.Range(5.3f, 1.3f);
              y = Random.Range(13.3f, 11.3f);

                _cameraTransform.position = new Vector3(_basePosition.x+x, y, _basePosition.z); yield return new WaitForSeconds(0.025f);
            }
            _cameraTransform.position = _basePosition;

        }

    }
}
