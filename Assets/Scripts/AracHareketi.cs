using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using TMPro;
using Unity.VisualScripting;
//using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UIElements;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private Rigidbody2D _tekerlek1RB;
    [SerializeField] private Rigidbody2D _tekerlek2RB;
    [SerializeField] private Rigidbody2D _arabaGovdeRB;
    [SerializeField] private float _aracDonmeHizi = 400f;
    [SerializeField] private float _aracHizi = 200f;
    [SerializeField] private float _aracMaxHizi = 1200f;
    [SerializeField] private float _aracMaxDonmeHizi = 2400f;
    private float maxPitch = 1.3f;
    private AudioSource _as;
    private float yon; // -1 0 1
    //[SerializeField] private Joystick joystick1;
    private Touch _touch;
        
    void Start()
    {
        _as = GetComponent<AudioSource>();
        _as.volume = 0.7f;
        _as.pitch = 0f;
    }
    // Update is called once per frame
    void Update()  //surekli
    {
        //yon =Input.GetAxisRaw("Horizontal");
        //yon = joystick1.Horizontal;
        if (Input.touchCount > 0)
        {
            _touch = Input.GetTouch(0);
            if (_touch.position.x >= Screen.width /2.0 && _touch.phase != TouchPhase.Ended) 
            {
                yon = +1;
                if (_as.pitch < maxPitch)
                {
                _as.pitch += 0.01f;
                }
                

            }
            else if (_touch.position.x < Screen.width / 2.0 && _touch.phase != TouchPhase.Ended)
            {
                yon = -1;
                if (_as.pitch > -maxPitch)
                {
                    _as.pitch -= 0.01f;
                }
            }
            else
            {
                
                yon = 0;
            }

           
        }
        else
        {
                    if (_as.pitch < 0)
                    {
                        _as.pitch += 0.01f;
                    }

                    if (_as.pitch > 0)
                    {
                        _as.pitch -= 0.01f;
                    }
         
        }
               

    }

    

    void FixedUpdate()  //deltatime aralýkla
    {
        
       if(_tekerlek1RB.totalTorque <= _aracMaxHizi - _aracMaxHizi * Time.fixedDeltaTime && _tekerlek1RB.totalTorque >= -_aracMaxHizi * Time.fixedDeltaTime)
         { 
            _tekerlek1RB.AddTorque(-1 * yon * _aracHizi * Time.fixedDeltaTime);
            _tekerlek2RB.AddTorque(-1 * yon * _aracHizi * Time.fixedDeltaTime);
         }

       if (_arabaGovdeRB.totalTorque <= _aracMaxHizi - _aracMaxDonmeHizi * Time.fixedDeltaTime && _arabaGovdeRB.totalTorque >= -_aracMaxDonmeHizi * Time.fixedDeltaTime)
       { 
           _arabaGovdeRB.AddTorque(-1 * yon * _aracDonmeHizi * Time.fixedDeltaTime);
       }
            

    }





   /* bool isAirborne(Collider2D rb)
    {
        if (rb.IsTouching(this.GetComponent<Collider2D>()))
        {

        }
        return false;
    }*/


}
