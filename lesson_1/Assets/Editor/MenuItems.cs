using UnityEditor;


namespace Geekbrains
{
    public class MenuItems
    {

        [MenuItem("Geekbrains/��� ������� ������ ")]
        private static void MenuOption()
        {
            EditorWindow.GetWindow(typeof(MyWindow), false, "Geekbrains");
        }

        [MenuItem("Geekbrains/������� ������ ����!/����� ���� �������! ")]
        private static void IschoMenuOption()
        {
            EditorWindow.GetWindow(typeof(MyWindowTwo), false, "Geekbrains");
        }

        [MenuItem("Assets/Geekbrains/��� � ��� ����� ���� �������! ")]
        private static void IVotIschoMenuOption()
        {
        }

    }
}



