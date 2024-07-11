using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageMenusu : MonoBehaviour
{
   public void StageLoad1()
    {
        Time.timeScale = 0;
        Application.targetFrameRate = 60;
        SceneManager.LoadScene(1);
        Time.timeScale = 1; AudioListener.volume = 1;

    }
    
    public void StageLoad2()
    {
        Time.timeScale = 0;
        Application.targetFrameRate = 60;
        SceneManager.LoadScene(2);
        Time.timeScale = 1; AudioListener.volume = 1;
    }
    public void StageLoad3()
    {
        Time.timeScale = 0;
        Application.targetFrameRate = 60;
        SceneManager.LoadScene(3);
        Time.timeScale = 1; AudioListener.volume = 1;
    }
    public void StageLoad4()
    {
        Time.timeScale = 0;
        Application.targetFrameRate = 60;
        SceneManager.LoadScene(4);
        Time.timeScale = 1; AudioListener.volume = 1;
    }
    public void StageLoad5()
    {
        Time.timeScale = 0;
        Application.targetFrameRate = 60;
        SceneManager.LoadScene(5);
        Time.timeScale = 1; AudioListener.volume = 1;
    }
    public void StageLoad6()
    {
        Time.timeScale = 0;
        Application.targetFrameRate = 60;
        SceneManager.LoadScene(6);
        Time.timeScale = 1; AudioListener.volume = 1;
    }

}
