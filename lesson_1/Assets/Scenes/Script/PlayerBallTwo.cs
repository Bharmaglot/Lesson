using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Geekbrains
{
    public class PlayerBallTwo : Player
    {

        void FixedUpdate()
        {
            Move();//сделать новый метод для управления вторым игроком
            
        }
    }
}