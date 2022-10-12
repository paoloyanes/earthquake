using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QT_Event : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI countdown;
    public GameObject countdownGO;
    float currentTime;
    float startingTime = 8f;
    public string eventSuccess = "n";

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (StateNameController.isEarthquakeSimulationRunning)
        {
            countdownGO.SetActive(true);
            
        }

        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            Debug.Log("Pressed Left Control");
            countdownGO.SetActive(false);
            eventSuccess = "y";
        }
        currentTime -= 1 * Time.deltaTime;
        countdown.text = currentTime.ToString("0");

        if(currentTime <= 0f)
        {
            currentTime = 0f;
            countdownGO.SetActive(false);
            StateNameController.isEarthquakeSimulationRunning = false;
        }
    }
}
