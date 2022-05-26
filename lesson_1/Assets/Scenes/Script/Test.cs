using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Geekbrains
{
    [ExecuteInEditMode]
    public class Test : MonoBehaviour
    {
        //private void Start()
        //{
        //    var tempRenderer = GetComponent<Renderer>();
        //    if (tempRenderer != null) tempRenderer.material.color = Random.ColorHSV();
        //}

        [ContextMenuItem("Random Count", nameof(Random))]
        [SerializeField] private int _count;
        private void Random()
        {
            _count = UnityEngine.Random.Range(0, 100);
        }

        //[Obsolete("Древнее зло пробудилось")]
        //private void TestObsolete()
        //{
        //}
    }
}