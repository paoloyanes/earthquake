using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgain : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadGame()
    {
        Objective1.getOutClass = false;
        PickUpController.slotFull = false;
        //StateNameController.selectStartingLocationDropdown = 0;
        SceneManager.LoadScene("SampleScene");
    }
}
