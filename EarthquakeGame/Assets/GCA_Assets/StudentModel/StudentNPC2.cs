using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudentNPC2 : MonoBehaviour
{
    [SerializeField]
    private GameObject studentNPC;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (StateNameController.isEarthquakeSimulationRunning == true)
        {
            studentNPC.GetComponent<Animator>().SetBool("npcIsDropCoverHold", true);
        } 
        else if(StateNameController.isEarthquakeSimulationRunning == false)
        {
            studentNPC.GetComponent<Animator>().SetBool("npcIsDropCoverHold", false);
        }
        else
        {
            studentNPC.GetComponent<Animator>().SetBool("npcIsIdle", true);
        }
    }
}
