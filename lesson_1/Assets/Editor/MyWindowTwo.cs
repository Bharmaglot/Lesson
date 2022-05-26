using UnityEditor;
using UnityEngine;

namespace Geekbrains
{
    public class MyWindowTwo : EditorWindow
    {

        private void OnGUI()
        {
            GUILayout.Label("Лейбл - тут у нас, вроде как, название окошка", EditorStyles.boldLabel);
            var button = GUILayout.Button("Некоторое действие");
            if (button)
            {
                //Пока нет идей. Пойду долги поделаю. :)
            }
        }
    }

}