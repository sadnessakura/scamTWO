using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screamer : MonoBehaviour
{
    public float TimeCur = 5;
    public float TimeStep = 1;

    public GameObject offit;

    // Update is called once per frame
    void Update()
    {
        if (TimeCur > 0)
        { TimeCur -= TimeStep; }
        else
        {
            offit.SetActive(false);
            TimeCur = 0;
        } 
    }
}
