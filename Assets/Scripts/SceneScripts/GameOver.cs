using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    //[SerializeField] private EdgeCollider2D _ec; 

    private float zaman;
   
    private void OnTriggerStay2D(Collider2D collision)
    {
        zaman++;
         if (zaman >= 2 && collision.tag == "Zemin")
         {
                Points.yuksekGuncelle();
            //Points.skor = 0;
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

    private void OnCollisionExit2D(Collision2D collision)
    {
        zaman = 0;
    }


    
}
