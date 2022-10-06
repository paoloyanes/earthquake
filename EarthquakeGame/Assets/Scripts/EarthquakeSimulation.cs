using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthquakeSimulation : MonoBehaviour
{
    public CameraShake earthquakeSimulation;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {

            StartCoroutine(earthquakeSimulation.Shake(5.0f, StateNameController.intensityValue/100));

        }

        
    }
}
