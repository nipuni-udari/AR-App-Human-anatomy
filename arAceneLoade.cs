using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class arAceneLoade : MonoBehaviour
{
   
    public void Heart()
   {
    SceneManager.LoadScene("HeartTarget");
   }

   public void Digestive()
   {
    SceneManager.LoadScene("DigestiveTarget");
   }

   public void Urinary()
   {
    SceneManager.LoadScene("UrinaryTarget");
   }

    public void Lymphatic()
   {
    SceneManager.LoadScene("LymphaticTarget");
   }

   public void HumanBrain()
   {
    SceneManager.LoadScene("BrainTarget");
   }

   public void Kidney()
   {
    SceneManager.LoadScene("KidneyTarget");
   }

   public void Respiratory()
   {
    SceneManager.LoadScene("RespiratoryTarget");
   }

    public void Nephron()
   {
    SceneManager.LoadScene("NephronTarget");
   }

   public void AllAnatomy()
   {
    SceneManager.LoadScene("AllAnatomy");
   }

   public void back()
    {
        SceneManager.LoadScene("login");
    }


}
