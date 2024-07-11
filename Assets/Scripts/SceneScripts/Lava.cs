using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lava : MonoBehaviour
{
    private int zaman = 0;
    //Points points = new Points();
    private void OnCollisionStay2D(Collision2D collision)
    {
        zaman++;
        if (zaman >= 2)
        {
            Points.yuksekGuncelle();
            Points.skor -= Points.skor; 
            if (SceneManager.GetActiveScene().buildIndex == 1)
            {
                SceneManager.LoadScene(1);
            }
            if (SceneManager.GetActiveScene().buildIndex == 2)
            {
                SceneManager.LoadScene(2);
            }
            if (SceneManager.GetActiveScene().buildIndex == 3)
            {
                SceneManager.LoadScene(3);
            }
            if (SceneManager.GetActiveScene().buildIndex == 4)
            {
                SceneManager.LoadScene(4);
            }
            if (SceneManager.GetActiveScene().buildIndex == 5)
            {
                SceneManager.LoadScene(5);
            }
            if (SceneManager.GetActiveScene().buildIndex == 6)
            {
                SceneManager.LoadScene(6);
            }
        }
       
    }
}
