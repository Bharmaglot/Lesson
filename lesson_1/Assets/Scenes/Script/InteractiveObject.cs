using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Geekbrains
{
    public abstract class InteractiveObject : MonoBehaviour
    {
        public bool IsInteractable { get; } = true;
        protected abstract void Interaction();
        
        private void OnTriggerEnter(Collider other)
        {
        if(!IsInteractable || !other.CompareTag("Player"))
            {
                return;
            }
            Interaction();
            Destroy(gameObject);
        }

           private void Start()
        {
            
        }
    }
}