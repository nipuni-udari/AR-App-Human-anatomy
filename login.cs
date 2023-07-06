using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class login : MonoBehaviour
{
   public void start()
   {
    SceneManager.LoadScene("Home");
   }

   public void Exit ()
    {
        Debug.Log("Quit Done!");
        Application.Quit();
    }


}