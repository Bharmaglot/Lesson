using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Geekbrains
{
    public class ResetLevel : MonoBehaviour
    {
        public void Reset()
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}