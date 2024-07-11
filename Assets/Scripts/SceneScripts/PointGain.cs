using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PointGain : MonoBehaviour
{
    
    public static bool _isGrounded = true;
    public static bool _isAirborne = false;
    private int frame;
  //  Points points = new Points();
    void Start()
    {
        frame = 0;
    }
    void Update()
    {
        frame++;
        if(frame >= 150)
        {
            if (_isAirborne && !_isGrounded && Time.timeScale == 1)
            {
            Points.skor++;
            }
        }
       
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Zemin" && Time.timeScale == 1)
        {
            _isGrounded = true;
            _isAirborne = false;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        _isGrounded = false;
        _isAirborne = true;
    }
}
