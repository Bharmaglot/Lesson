using UnityEditor;


namespace Geekbrains
{
    public class MenuItems
    {

        [MenuItem("Geekbrains/Мое пробное окошко ")]
        private static void MenuOption()
        {
            EditorWindow.GetWindow(typeof(MyWindow), false, "Geekbrains");
        }

        [MenuItem("Geekbrains/Появись раздел меню!/Пункт меню появись! ")]
        private static void IschoMenuOption()
        {
            EditorWindow.GetWindow(typeof(MyWindowTwo), false, "Geekbrains");
        }

        [MenuItem("Assets/Geekbrains/Еще и тут пункт меню появись! ")]
        private static void IVotIschoMenuOption()
        {
        }

    }
}



