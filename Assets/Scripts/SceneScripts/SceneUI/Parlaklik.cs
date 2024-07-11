using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.UI;

public class Parlaklik : MonoBehaviour
{
    public Slider parlaklikAyari;

    public PostProcessProfile parlaklik; 
    public PostProcessLayer ParlakilkLayer;

    public AutoExposure aexp;


    // Start is called before the first frame update
    void Start()
    {
        parlaklik.TryGetSettings(out aexp);
        parlaklikAyari.value = PlayerPrefs.GetFloat("ParlaklikAyari",0.9f);
        ParlaklikAyarla(parlaklikAyari.value);
    }

    public void ParlaklikAyarla(float parlaklik)
    {
        if(parlaklik < 0.5f)
        {
            aexp.keyValue.value = 0.5f;
        }
        else if (parlaklik >1.2f)
        {
            aexp.keyValue.value = 1.2f;
        }
        else
        {
            aexp.keyValue.value = parlaklik;
        }
        PlayerPrefs.SetFloat("ParlaklikAyari",aexp.keyValue.value);
        PlayerPrefs.Save();
    }

}
