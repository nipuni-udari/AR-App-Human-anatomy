using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Brain : MonoBehaviour
{
   public void back()
   {
    SceneManager.LoadScene("Home");
   }

   public void Exit ()
    {
        Debug.Log("Quit Done!");
        Application.Quit();
    }

    public void play ()
    {
      SceneManager.LoadScene("BrainVideo");
        
    }



}