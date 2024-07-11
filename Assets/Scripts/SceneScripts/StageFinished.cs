using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameFinished : MonoBehaviour
{

    private float _zaman2;

    private void OnTriggerStay2D(Collider2D other)
    {
        _zaman2++;
        //Points points = new Points();
        if (other.tag == "Player" && _zaman2 >= 10)
        {   
            Points.skor +=10000;
            Debug.Log("Tebirkler Kazandiniz!  Puan : "+ Points.skor);
            Points.yuksekGuncelle();
            if (SceneManager.GetActiveScene().buildIndex == 1)
            {
                SceneManager.LoadScene(2);
            }
            if (SceneManager.GetActiveScene().buildIndex == 2)
            {
                SceneManager.LoadScene(3);
            }
            if (SceneManager.GetActiveScene().buildIndex == 3)
            {
                SceneManager.LoadScene(4);
            }
            if (SceneManager.GetActiveScene().buildIndex == 4)
            {
                SceneManager.LoadScene(5);
            }
            if (SceneManager.GetActiveScene().buildIndex == 5)
            {
                SceneManager.LoadScene(6);
            }
            if (SceneManager.GetActiveScene().buildIndex == 6)
            {
                SceneManager.LoadScene(0);
            }
        }
    }
}
