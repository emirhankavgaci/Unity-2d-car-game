using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GoldCollect : MonoBehaviour
{
  
    private void OnTriggerEnter2D(Collider2D collide)
    {
        
        if (collide.tag == "Player")
        {
            AudioSource.PlayClipAtPoint(gameObject.GetComponent<AudioSource>().clip, gameObject.transform.position);
            gameObject.SetActive(false);
             Points.skor += 500;
            //Debug.Log(Points.skor);
        }

    }

}
