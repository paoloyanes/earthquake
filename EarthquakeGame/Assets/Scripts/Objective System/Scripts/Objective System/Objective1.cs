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

    public GameObject controlPrompt;
    public GameObject nPrompt;
    public GameObject nPromptText;
    public GameObject ePrompt;

    public Text countdownText;
    public bool countdownTrigger = false;

    public Text goodJobText;
    public Text trivia;
    public Text earthquakeText;
    public Text instructionsText;
    public Text instructionsText2;
 

    public static bool getOutClass;
    public static bool buildNavStarter = false;
    public static bool aftershockStarter = false;
    public static bool finalObjective = false;

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
        instructionsText.text = "Drop, Cover, and Hold!";
        instructionsText2.text = "Pickup Book";
        controlPrompt.SetActive(true);
        ePrompt.SetActive(true);
        objSFX.Play();
        theObjective.SetActive(true);
        theObjective.GetComponent<Animation>().Play("ObjectiveDisplayAnim");
        theText.GetComponent<Text>().text = "Pick up a book and DROP, COVER, and HOLD!";
        yield return new WaitForSeconds(15f);
        controlPrompt.SetActive(false);
        ePrompt.SetActive(false);

        if (PlayerMotor.crouching == true && PickUpController.slotFull == true)
        {
            // Objective 2
            buildNavStarter = true;
            earthquakeText.text = "";
            instructionsText.text = "";
            instructionsText2.text = "";
            goodJobText.text = "Good Job!";
            trivia.text = "Did you know that the DROP, COVER, and HOLD maneuver stops you from being knocked over, makes you a smaller target from debris, and protects your body?";
            goodJobSFX.Play();
            yield return new WaitForSeconds(10f);
            goodJobText.text = "";
            trivia.text = "";
            objSFX.Play();
            theObjective.SetActive(true);
            theObjective.GetComponent<Animation>().Play("ObjectiveDisplayAnim");
            theText.GetComponent<Text>().text = "Incoming Aftershock! Do the Drop, Cover, and Hold!";
            earthquakeText.text = "EARTHQUAKE!";
            instructionsText.text = "Drop, Cover, and Hold!";
            instructionsText2.text = "Pickup Book";
            controlPrompt.SetActive(true);
            ePrompt.SetActive(true);
            countdownTrigger = true;
            aftershockStarter = true;
            yield return new WaitForSeconds(30f);
            controlPrompt.SetActive(false);
            ePrompt.SetActive(false);
            if (PlayerMotor.crouching == true && PickUpController.slotFull == true)
            {
                earthquakeText.text = "";
                instructionsText.text = "";
                instructionsText2.text = "";
                goodJobSFX.Play();
                goodJobText.text = "Good Job!";
                trivia.text = "Did you know that aftershocks can happen after an earthquake? Aftershocks are dangerous since it can have the same effects as the recent earthquake.";
                getOutClass = true;
                theObjective.SetActive(true);
                theObjective.GetComponent<Animation>().Play("ObjectiveDisplayAnim");
                theText.GetComponent<Text>().text = "Get out of the Classroom";
                nPrompt.SetActive(true);
                nPromptText.SetActive(true);
                yield return new WaitForSeconds(10f);
                goodJobText.text = "";
                trivia.text = "";

                while(getOutClass == true)
                {
                    yield return new WaitForSeconds(30f);
                    finalObjective = true;
                }
                
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
