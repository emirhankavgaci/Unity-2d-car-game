using System.Collections;
using System.Collections.Generic;
//using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnaMenu : MonoBehaviour
{
   // Points points = new Points();
    public void OyunuBaslat()
    {
        Points.skor = 0;
        Time.timeScale = 1;
        AudioListener.volume = 1;
        Application.targetFrameRate = 60;
        SceneManager.LoadScene(1);  
    }
    
    public void OyundanCik()
    {
        
         Application.Quit();
    }

}
