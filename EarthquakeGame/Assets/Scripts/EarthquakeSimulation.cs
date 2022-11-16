using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthquakeSimulation : MonoBehaviour
{
    public CameraShake earthquakeSimulation;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EarthquakeCoroutine());
    }

    // Update is called once per frame
    //void Update()
    //{

    //    if (Input.GetKeyDown(KeyCode.Alpha1))
    //    {

            

    //    }

        
    //}

    IEnumerator EarthquakeCoroutine()
    {
        yield return new WaitForSecondsRealtime(3f);

        if (StateNameController.isStartGameClicked)
        {
            StateNameController.isEarthquakeSimulationRunning = true;
        }
        

        if(StateNameController.intensityValue < 2)
        {
            StartCoroutine(earthquakeSimulation.Shake(15.0f, 0.02f));
        }
        else
        {
            StartCoroutine(earthquakeSimulation.Shake(15.0f, StateNameController.intensityValue / 100));
        }
    }
}
