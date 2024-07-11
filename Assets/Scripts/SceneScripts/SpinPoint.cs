using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SpinPoint : MonoBehaviour
{

    private Vector2 _baslangic;
    private float donmeAcisi;
    
    private void Start()
    {
        _baslangic = transform.right;
    }

    void Update()
    {

        /*float spin = gameObject.transform.eulerAngles.z;
        //Debug.Log("Spinim"+Mathf.Floor(spin));
         if (spin>= 179 && spin <180)
         {
             spincount++;
         }

         if (spincount == 1)
         {
             Points.skor += 1000000;
             spincount = 0;
         }*/
        

        Vector3 sonAci = transform.right;
        donmeAcisi += Vector2.SignedAngle(_baslangic, sonAci);
        _baslangic = sonAci;
        if (Mathf.Abs(donmeAcisi) >= 360f)
        {
            Points.skor += 150;
            donmeAcisi -= 360f * Mathf.Sign(donmeAcisi);
        }

    }
}