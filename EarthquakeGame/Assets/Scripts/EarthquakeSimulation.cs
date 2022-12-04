using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EarthquakeSimulation : MonoBehaviour
{
    public CameraShake earthquakeSimulation;
    public CameraShake earthquakeSimulation2;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EarthquakeCoroutine());
    }

    //Update is called once per frame
    void Update()
    {

        if (Objective1.aftershockStarter == true)
        {
            StartCoroutine(earthquakeSimulation.Shake(28.0f, 0.02f));
            StartCoroutine(earthquakeSimulation2.Shake(28.0f, 0.02f));
            Objective1.aftershockStarter = false;
        }

        if (Objective1.getOutClass == true)
        {
            if(Objective1.finalObjective == true)
            {
                StartCoroutine(earthquakeSimulation.Shake(10.0f, 0.02f));
                StartCoroutine(earthquakeSimulation2.Shake(10.0f, 0.02f));
                Objective1.finalObjective = false;
                StartCoroutine(DropCoverHoldChecker());
                
            }
        }

        
    }

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
            StartCoroutine(earthquakeSimulation2.Shake(15.0f, 0.02f));
        }
        else
        {
            StartCoroutine(earthquakeSimulation.Shake(15.0f, StateNameController.intensityValue / 100));
            StartCoroutine(earthquakeSimulation2.Shake(15.0f, StateNameController.intensityValue / 100));
        }
        
        //Delay before next earthquake
        

    }
    IEnumerator DropCoverHoldChecker()
    {
        yield return new WaitForSecondsRealtime(10.0f);
        if (PlayerMotor.crouching == true && PickUpController.slotFull == true)
        {
            yield return new WaitForSecondsRealtime(0f);
        }
        else if(PlayerMotor.crouching == true && PickUpController.slotFull == false)
        {
            PlayerMotor.crouching = false;
            SceneManager.LoadScene(5);
        }
        else if(PlayerMotor.crouching == false && PickUpController.slotFull == true)
        {
            PlayerMotor.crouching = false;
            SceneManager.LoadScene(6);
        }
        else
        {
            PlayerMotor.crouching = false;
            SceneManager.LoadScene(7);
        }
    }

}


