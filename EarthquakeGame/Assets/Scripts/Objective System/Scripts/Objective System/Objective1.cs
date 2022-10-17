using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Objective1 : MonoBehaviour
{

    // Public Variables
    public AudioSource objSFX;
    public GameObject theObjective;
    public GameObject theTrigger;
    public GameObject theText;

    void Start()
    {
        StartCoroutine(missionObj());
    }


    private IEnumerator missionObj()
    {
        // objective 1
        yield return new WaitForSeconds(3f);
        objSFX.Play();
        theObjective.SetActive(true);
        theObjective.GetComponent<Animation>().Play("ObjectiveDisplayAnim");
        theText.GetComponent<Text>().text = "Wait for the shaking to stop.";
        // objective 2
        yield return new WaitForSeconds(8f);
        objSFX.Play();
        theObjective.SetActive(true);
        theObjective.GetComponent<Animation>().Play("ObjectiveDisplayAnim");
        theText.GetComponent<Text>().text = "Wait for at least 30 seconds in order to avoid sudden aftershocks.";
        yield return new WaitForSeconds(38f);
        objSFX.Play();
        theObjective.SetActive(true);
        theObjective.GetComponent<Animation>().Play("ObjectiveDisplayAnim");
        theText.GetComponent<Text>().text = "Get out of the classroom.";
    }

}
