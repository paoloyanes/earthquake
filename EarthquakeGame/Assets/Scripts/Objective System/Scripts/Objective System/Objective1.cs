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
    public AudioSource goodJobSFX;

    public GameObject theObjective;
    public GameObject theTrigger;
    public GameObject theText;

    public Text countdownText;
    public bool countdownTrigger = false;

    public Text goodJobText;
    public Text trivia;
    public Text earthquakeText;

    public static bool getOutClass;
    public bool missionObjDone = false;

    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
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
        earthquakeText.text = "EARTHQUAKE!";
        objSFX.Play();
        theObjective.SetActive(true);
        theObjective.GetComponent<Animation>().Play("ObjectiveDisplayAnim");
        theText.GetComponent<Text>().text = "Pick up a book and DROP COVER AND HOLD!";
        yield return new WaitForSeconds(15f);

        if (PlayerMotor.crouching == true && PickUpController.slotFull == true)
        {
            // Objective 2
            
            earthquakeText.text = "";
            goodJobText.text = "Good Job!";
            trivia.text = "Did you know that the DROP, COVER, and HOLD maneuver stops you from being knocked over, makes you a smaller target from debris, and it protects your body?";
            goodJobSFX.Play();
            yield return new WaitForSeconds(10f);
            goodJobText.text = "";
            trivia.text = "";
            objSFX.Play();
            theObjective.SetActive(true);
            theObjective.GetComponent<Animation>().Play("ObjectiveDisplayAnim");
            theText.GetComponent<Text>().text = "Wait for at least 30 seconds in case of sudden aftershocks.";
            countdownTrigger = true;
            yield return new WaitForSeconds(30f);
            goodJobSFX.Play();
            goodJobText.text = "Good Job!";
            trivia.text = "Did you know that aftershocks can happen after an earthquake? Aftershocks are dangerous since it can have the same effects as the recent earthquake.";
            getOutClass = true;
            theObjective.SetActive(true);
            theObjective.GetComponent<Animation>().Play("ObjectiveDisplayAnim");
            theText.GetComponent<Text>().text = "Get out of the Classroom";
            yield return new WaitForSeconds(10f);
            goodJobText.text = "";
            trivia.text = "";

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
