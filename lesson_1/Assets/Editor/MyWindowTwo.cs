using UnityEditor;
using UnityEngine;

namespace Geekbrains
{
    public class MyWindowTwo : EditorWindow
    {

        private void OnGUI()
        {
            GUILayout.Label("����� - ��� � ���, ����� ���, �������� ������", EditorStyles.boldLabel);
            var button = GUILayout.Button("��������� ��������");
            if (button)
            {
                //���� ��� ����. ����� ����� �������. :)
            }
        }
    }

}