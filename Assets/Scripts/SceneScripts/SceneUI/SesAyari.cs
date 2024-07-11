using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SesAyari : MonoBehaviour
{
    // Start is called before the first frame update

    public float ses;
    public GameObject sesKaynagi;
    public GameObject sesKaynagi2;
    public Slider sesAyari;


    void Start()
    {
        sesAyari.value = PlayerPrefs.GetFloat("SesAyari", 0.6f);
        ses = sesAyari.value;
    }
    public void SesAyarla(float sesDegeri)
    {
        sesKaynagi.GetComponent<AudioSource>().volume = sesDegeri;
        PlayerPrefs.SetFloat("SesAyari", sesDegeri);
        PlayerPrefs.Save();
    }
}