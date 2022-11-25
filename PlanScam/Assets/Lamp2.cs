using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp2 : MonoBehaviour
{

    public int Number;
    public int Num;
    public Light Lamp;

    void Start()
    {
        
    }

    void Update()
    {
        Number = Random.Range(0, 120); //30
        if (Number < Num)
        {
            Lamp.intensity = 0;
        }
        else
        {
            Lamp.intensity = 1;
        }
    }

}
