using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Geekbrains
{
    public sealed class ListInteractableObject : IEnumerator
    {
        private InteractiveObject[] _interactiveObjects;
        private int _index = -1;
        public ListInteractableObject()
        {
            _interactiveObjects = Object.FindObjectsOfType<InteractiveObject>();
        }
        public bool MoveNext()
        {
            if (_index == _interactiveObjects.Length - 1)
            {
                Reset();
                return false;
            }
            _index++;
            return true;

        }
        public void Reset() => _index = -1;
        public object Current => _interactiveObjects[_index];
        public IEnumerator GetEnumerator()
        {
            return this;
        }
        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    return GetEnumerator();
        //}

    }
}

