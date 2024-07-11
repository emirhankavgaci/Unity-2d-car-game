using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class TextEdit : MonoBehaviour
{
    [SerializeField] private TMP_Text _tmp;
    private int Skor;
    //Points points = new Points();
    void Start()
    {
    _tmp = GetComponent<TMP_Text>();
    }
    void Update()
    {
        Skor = Points.skor;
        _tmp.text = Skor.ToString();
    }



}
