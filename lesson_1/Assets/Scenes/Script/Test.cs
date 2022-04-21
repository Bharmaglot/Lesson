using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


namespace Geekbrains
{
    public class Test : MonoBehaviour
    {
        private void Start()
        {
            var interactableObject = new ListInteractableObject();
            while (interactableObject.MoveNext())
            {
                print(interactableObject.Current);
            }

            foreach (var o in interactableObject)
            {
                print(o);
            }

        }
    }
}
