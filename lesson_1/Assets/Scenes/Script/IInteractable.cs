using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Geekbrains
{
    public interface IInteractable : IAction, IInitialization
    {
        bool IsInteractable { get; }
    }
}
