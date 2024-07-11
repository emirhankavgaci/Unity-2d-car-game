using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Points : MonoBehaviour
{   
    public static TextMeshProUGUI HighScore; 
    public static int skor = 0;
    public static int yuksekSkor;
    public void Awake()
    {   
        HighScore = GameObject.Find("TextMaxSkor (TMP) (1)").GetComponent<TextMeshProUGUI>();
        Points.skor = 0;
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            Points.yuksekSkor = PlayerPrefs.GetInt("Highscore0");
        }
        if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            Points.yuksekSkor = PlayerPrefs.GetInt("Highscore1");
        }
        if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            Points.yuksekSkor = PlayerPrefs.GetInt("Highscore2");
        }
        if (SceneManager.GetActiveScene().buildIndex == 4)
        {
            Points.yuksekSkor = PlayerPrefs.GetInt("Highscore3");
        }
        if (SceneManager.GetActiveScene().buildIndex == 5)
        {
            Points.yuksekSkor = PlayerPrefs.GetInt("Highscore4");
        }
        if (SceneManager.GetActiveScene().buildIndex == 6)
        {
            Points.yuksekSkor = PlayerPrefs.GetInt("Highscore5");
        }
       
        Points.HighScore.text = "" + yuksekSkor;
        
    }
    
    public static void yuksekGuncelle()
    {
        if(SceneManager.GetActiveScene().buildIndex == 1 )
        { 
            Points.yuksekSkor = PlayerPrefs.GetInt("Highscore0"); //s1
            if (Points.skor > Points.yuksekSkor)
            {
                Points.yuksekSkor = Points.skor;
                PlayerPrefs.SetInt("Highscore0", yuksekSkor);
                PlayerPrefs.Save();
                Debug.Log("1");
            }
        }
        if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            Points.yuksekSkor = PlayerPrefs.GetInt("Highscore1"); //s2
            if (Points.skor > Points.yuksekSkor)
            {
                Points.yuksekSkor = Points.skor;
                PlayerPrefs.SetInt("Highscore1", yuksekSkor);
                PlayerPrefs.Save();
                Debug.Log("2");

            }
        }
        if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            Points.yuksekSkor = PlayerPrefs.GetInt("Highscore2"); //s3
            if (Points.skor > Points.yuksekSkor)
            {
                Points.yuksekSkor = Points.skor;
                PlayerPrefs.SetInt("Highscore2", yuksekSkor);
                PlayerPrefs.Save();
                Debug.Log("3");

            }
        }
        if (SceneManager.GetActiveScene().buildIndex == 4)
        {
            Points.yuksekSkor = PlayerPrefs.GetInt("Highscore3"); //s4
            if (Points.skor > Points.yuksekSkor)
            {
                Points.yuksekSkor = Points.skor;
                PlayerPrefs.SetInt("Highscore3", yuksekSkor);
                PlayerPrefs.Save();
                Debug.Log("4");

            }
        }
        if (SceneManager.GetActiveScene().buildIndex == 5)
        {
            Points.yuksekSkor = PlayerPrefs.GetInt("Highscore4"); //s5
            if (Points.skor > Points.yuksekSkor)
            {
                Points.yuksekSkor = Points.skor;
                PlayerPrefs.SetInt("Highscore4", yuksekSkor);
                PlayerPrefs.Save();
                Debug.Log("5");

            }
        }
        if (SceneManager.GetActiveScene().buildIndex == 6)
        {
            Points.yuksekSkor = PlayerPrefs.GetInt("Highscore5"); //s6
            if (Points.skor > Points.yuksekSkor)
            {
                Points.yuksekSkor = Points.skor;
                PlayerPrefs.SetInt("Highscore5", yuksekSkor);
                PlayerPrefs.Save();
                Debug.Log("6");

            }
        }
       /* if (Points.skor > Points.yuksekSkor)
        {
            Points.yuksekSkor = Points.skor;
            PlayerPrefs.SetInt("Highscore0", yuksekSkor);
            PlayerPrefs.Save();

        }*/
        HighScore = GameObject.Find("TextMaxSkor (TMP) (1)").GetComponent<TextMeshProUGUI>();    
        Points.HighScore.text = "" + yuksekSkor;
        //Debug.Log(yuksekSkor);
    }
       


}
