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

    public static bool getOutClass;
    public bool missionObjDone = false;

    void Start()
    {
        getOutClass = false;
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

        if (missionObjDone == true)
        {
            if (getOutClass == false)
            {
                if (PickUpController.slotFull == true)
                {
                    getOutClass = true;
                    StartCoroutine(missionObj2());
                }
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
        theText.GetComponent<Text>().text = "Wait for at least 30 seconds in case of sudden aftershocks.";
        countdownTrigger = true;
        yield return new WaitForSeconds(30f);


        if (PickUpController.slotFull == false)
        {
            objSFX.Play();
            theObjective.SetActive(true);
            theObjective.GetComponent<Animation>().Play("ObjectiveDisplayAnim");
            theText.GetComponent<Text>().text = "Pick up a hard object to cover your head with.";
            missionObjDone = true;
            getOutClass = false;
            yield return getOutClass;
        }
        else
        {
            objSFX.Play();
            theObjective.SetActive(true);
            theObjective.GetComponent<Animation>().Play("ObjectiveDisplayAnim");
            theText.GetComponent<Text>().text = "Get out of the Classroom";
            getOutClass = true;
        }
    }

    private IEnumerator missionObj2()
    {
        objSFX.Play();
        theObjective.SetActive(true);
        theObjective.GetComponent<Animation>().Play("ObjectiveDisplayAnim");
        theText.GetComponent<Text>().text = "Get out of the Classroom";

        getOutClass = true;

        yield return getOutClass;
    }

}
