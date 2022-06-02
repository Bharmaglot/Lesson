using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Geekbrains
{
    public sealed class ExampleChecked
    {
        public void Main()
        {
            int a = 150;
            int b = 150;


            try
            {
                byte result = checked((byte)(a + b));
            }
            catch (Exception e)
            {
                Debug.Log(e.Message);
            }
        }
    }
}
