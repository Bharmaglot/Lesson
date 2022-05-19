using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace Geekbrains
{
    public class GameController : MonoBehaviour
    {
        private InteractiveObject[] _interactiveObjects;
        public Text _finishGameLabel;
        private DisplayEndGame _displayEndGame;

        private void Awake()
        {
            _interactiveObjects = FindObjectsOfType<InteractiveObject>();
            _displayEndGame = new DisplayEndGame(_finishGameLabel);
            foreach (var o in _interactiveObjects)
            {
                if (o is FastDieBonus fastDieBonus)
                {
                    fastDieBonus.CaughtPlayer += CaughtPlayer;
                    fastDieBonus.CaughtPlayer += _displayEndGame.GameOver;
                }
            }
        }

        private void CaughtPlayer(object value, CaughtPlayerEventArgs args)
        {
            Time.timeScale = 0.0f;
        }

        private void Update()
        {
            for (var i = 0; i < _interactiveObjects.Length; i++)
            {
                var interactiveObject = _interactiveObjects[i];

                if (interactiveObject == null)
                {
                    continue;
                }

                if (interactiveObject is IFlay flay)
                {
                    flay.Flay();
                }

                if (interactiveObject is IFlicker flicker)
                {
                    flicker.Flicker();
                }
                if
                (interactiveObject is IRotation rotation)
                {
                    rotation.Rotation();
                }
            }
        }
        public void Dispose()
        {
            foreach (var o in _interactiveObjects)
            {
                if (o is InteractiveObject interactiveObject)
                {
                    Destroy(interactiveObject.gameObject);
                    if (o is FastDieBonus fastDieBonus)
                    {
                        fastDieBonus.CaughtPlayer -= CaughtPlayer;
                        fastDieBonus.CaughtPlayer -= _displayEndGame.GameOver;
                    }
                }
            }    
        }
    }
}
