using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Geekbrains
{
    public abstract class InteractiveObject : MonoBehaviour
    {
        protected Color _color;
        public bool IsInteractable { get; } = true;




        protected abstract void Interaction(Player player);
        


        private void OnTriggerEnter(Collider other)
        {
        if(!IsInteractable || !other.CompareTag("Player"))
            {
                return;
            }
            Interaction(other.GetComponent<Player>());
            Destroy(gameObject);
        }

           private void Start()
        {
            Action();
        }

        public void Action()
        {
            _color = Random.ColorHSV();
            if (TryGetComponent(out Renderer renderer))
            {
                renderer.material.color = _color;
            }
        }
    }
}