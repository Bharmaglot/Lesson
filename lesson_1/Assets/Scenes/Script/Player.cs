using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Geekbrains
{
    public class Player : MonoBehaviour
    {
        public float Speed = 3.0f;
        private Rigidbody _rigidbody;
        private int score;
        private int hit = 3;
        private float _bonusSpeed;
        private Coroutine _bonusRoutine;


        //public delegate void CaugthPlayerChange();
       // public CaugthPlayerChange CaughtPlayer;

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();

        }

        protected void Move()
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");
            

            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

            _rigidbody.AddForce(movement * Speed);
        }
        public void PlusScore(int value)
        {
            score = score + value;
            if (score >= 4)
            {
                //победный
            }
        }

        public void CorrectSpeedPlayer(float timer, double correctSpeed)
        {
      
            Speed = Speed * (float)correctSpeed;
            if(_bonusRoutine != null)
            {
                StopCoroutine(_bonusRoutine);
            }
            _bonusRoutine = StartCoroutine(BonusTimer(timer, correctSpeed));
        }

        IEnumerator BonusTimer(float time, double correctSpeed)
        {
            yield return new WaitForSeconds(time);
            Speed = Speed / (float)correctSpeed;
        }




        public void PlayerDamage(int damage)
        {
            hit = hit - damage;
            if(hit <= 0)
            {
                Dead();
            }
        }

        public void Dead()
        {
            //CaughtPlayer();
            Destroy(gameObject);
        }
    }

}