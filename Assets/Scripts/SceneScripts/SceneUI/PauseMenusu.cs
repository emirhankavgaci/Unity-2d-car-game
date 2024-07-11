using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenusu : MonoBehaviour
{
    [SerializeField] GameObject durdur;
    public Slider ses;
    public Slider parlaklik;
    //Points points = new Points();
    public void AnamenuDon()
    {
        Points.yuksekGuncelle();
        Points.skor = 0;
        SceneManager.LoadScene(0);
        Time.timeScale = 0.1f;
        AudioListener.volume = 0;
    }

    public void YenidenBaslat()
    {
        Points.yuksekGuncelle();
        Points.skor = 0;  
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
        Time.timeScale = 1;
        AudioListener.volume = 1;
    }
    public void DevamEt()
    {
        
        gameObject.SetActive(false);
        durdur.SetActive(true);
        Time.timeScale = 1;
        AudioListener.volume = 1;


    }
    public void Durdur()
    {
        Time.timeScale = 0; AudioListener.volume = 0;
        gameObject.SetActive(true);
        durdur.SetActive(false);
       

    }

    public void Sifirla()
    {
       ses.value = 0.6f;
       parlaklik.value = 0.9f;
       PlayerPrefs.SetFloat("ParlaklikAyari", 0.9f);
        PlayerPrefs.SetFloat("SesAyari", 0.6f);
        PlayerPrefs.Save();
    }

   

}
