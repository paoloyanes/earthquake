using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShakingPrompt : MonoBehaviour
{
    public Text instructionsText;
    public Text instructionsText2;
    public Text earthquakeText;
    public GameObject ePrompt;
    public GameObject controlPrompt;
    public bool enablePrompt = false;
    public bool starter = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(starter == true)
        {
            if(Objective1.getOutClass == true)
            {
                starter = false;
                enablePrompt = true;
            }
        }
        

        if(enablePrompt == true)
        {
            if(CameraShake.shaking)
            {
                ePrompt.SetActive(true);
                controlPrompt.SetActive(true);
                instructionsText.text = "Pickup Book";
                instructionsText2.text = "Drop, Cover, and Hold!";
                earthquakeText.text = "EARTHQUAKE!";
            }
            else
            {
                ePrompt.SetActive(false);
                controlPrompt.SetActive(false);
                instructionsText.text = "";
                instructionsText2.text = "";
                earthquakeText.text = "";
            }
        }


    }
}
