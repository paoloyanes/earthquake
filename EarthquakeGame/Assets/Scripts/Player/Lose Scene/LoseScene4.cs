using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseScene4 : MonoBehaviour
{

    float timer;
    int waitTimer;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Objective1.getOutClass == true)
        {
            if (StateNameController.selectStartingLocationDropdown == 0)
                {
                // 1st Floor
                }
            else if (StateNameController.selectStartingLocationDropdown == 1)
                {
                // 2nd Floor
                GameObject.FindGameObjectWithTag("LoseExit1stFloor").SetActive(false);
                }
            else if (StateNameController.selectStartingLocationDropdown == 2)
                {
                // 3rd Floor
                GameObject.FindGameObjectWithTag("LoseExit1stFloor").SetActive(false);
                GameObject.FindGameObjectWithTag("LoseExit2ndFloor").SetActive(false);
                }
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        GameObject collisionGameObject = collision.gameObject;

        
            if(collisionGameObject.tag == "Player"){
                //Objective 1: stay in classroom because of ongoing earthquake
                //Objective 2: pick up and duck dover hold
                //Objective 3: Stay inside Afterschock
                //Objective 4: Getting to an open space like the field is your top priority

                SceneManager.LoadScene(8);
            }

        

        
    }

}
