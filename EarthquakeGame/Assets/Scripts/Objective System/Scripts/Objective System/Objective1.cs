using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Objective1 : MonoBehaviour
{
    //Countdown Timer
    public float currentTime = 0f;
    public float startingTime = 30f;
    // Public Variables
    public AudioSource objSFX;
    public GameObject theObjective;
    public GameObject theTrigger;
    public GameObject theText;

    public Text countdownText;
    public bool countdownTrigger = false;

    void Start()
    {
        currentTime = startingTime;
        StartCoroutine(missionObj());

    }

    void Update()
    {
        if (countdownTrigger == true)
        {
            currentTime -= 1 * Time.deltaTime;
            countdownText.text = currentTime.ToString("0");
            if (currentTime <= 0)
            {

                currentTime = 0;
                countdownText.text = " ";
            }
        }
        
        
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
        countdownTrigger = true;
        yield return new WaitForSeconds(30f);
        objSFX.Play();
        theObjective.SetActive(true);
        theObjective.GetComponent<Animation>().Play("ObjectiveDisplayAnim");
        theText.GetComponent<Text>().text = "Get out of the classroom.";
    }

}
