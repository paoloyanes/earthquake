using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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


    }

    private IEnumerator missionObj()
    {
        // objective 1
        yield return new WaitForSeconds(3f);
        objSFX.Play();
        theObjective.SetActive(true);
        theObjective.GetComponent<Animation>().Play("ObjectiveDisplayAnim");
        theText.GetComponent<Text>().text = "Pickup something hard and DUCK COVER AND HOLD!";
        // objective 2
        yield return new WaitForSeconds(15f);

        if (PlayerMotor.crouching == true && PickUpController.slotFull == true)
        {
            objSFX.Play();
            theObjective.SetActive(true);
            theObjective.GetComponent<Animation>().Play("ObjectiveDisplayAnim");
            theText.GetComponent<Text>().text = "Wait for at least 30 seconds in case of sudden aftershocks.";
            countdownTrigger = true;
            yield return new WaitForSeconds(30f);
            objSFX.Play();
            theObjective.SetActive(true);
            theObjective.GetComponent<Animation>().Play("ObjectiveDisplayAnim");
            theText.GetComponent<Text>().text = "Get out of the Classroom";
            getOutClass = true;
            
        }
        else
        {
            LoseScene3.obj3failcounter ++;
            SceneManager.LoadScene(5);
        }



    }


}
