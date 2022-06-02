using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Geekbrains
{ 
    public class NewGame : MonoBehaviour
    {
       
       public InputField playerName;


        public void NewGameScn()
        {
            if(playerName.text != null){
            SceneManager.LoadScene("SampleScene");
            }
            //ֲûחמג ForProfile.CheckProfileAndRun
        }
    }
}
