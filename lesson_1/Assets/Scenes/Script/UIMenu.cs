using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Geekbrains
{
    public class UIMenu : MonoBehaviour
    {
        public void ToMenu()
        {
            SceneManager.LoadScene("MenuGame");
        }
    }
}