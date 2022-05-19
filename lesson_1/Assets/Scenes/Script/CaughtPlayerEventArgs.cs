using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


namespace Geekbrains
{
    public sealed class CaughtPlayerEventArgs : EventArgs
    {
        public Color Color { get; }

        public CaughtPlayerEventArgs(Color Color)
        {
            Color = Color;
        }
    }
}