using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ScreamsFace : MonoBehaviour
{
    public GameObject Orange; //Объект лица
    public AudioSource AppearSFX;
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Orange.SetActive(true);
            AppearSFX.Play();
            Destroy(gameObject,2);
            
        }         
            
           // Destroy(Screamss,2);

           // Orange.SetActive(false);
        
    }
}
