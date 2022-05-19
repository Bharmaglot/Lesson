using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Geekbrains
{
    public sealed class DelegatesObserver
    {
        public delegate void MyDelegate(object o);

        public sealed class Sourse
        {
            private event MyDelegate _functions;
       
            public void Add(MyDelegate f)
            {
                _functions += f;
            }
            public void Remove(MyDelegate f)
            {
                _functions -= f;
            }

            public void Run()
            {
                Debug.Log("RUNS!");
                if (_functions != null) _functions(this);
            }

            public sealed class Observer1
            {
                public void Do(object o)
                {
                    Debug.Log($"Первый. Принял, что объект {o} побежал");
                }
                public sealed class Observer2
                {
                    public void Do(object o)
                    {
                        Debug.Log($"Второй. Принял, что объект {o} побежал");
                    }
                }
            }
        }
    }
}