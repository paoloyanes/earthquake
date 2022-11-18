using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseScene3 : MonoBehaviour
{

    float timer;
    int waitTimer;

    static public int obj3failcounter = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Objective1.getOutClass == true)
        {
            GameObject.FindGameObjectWithTag("Lose3").SetActive(false);
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

                SceneManager.LoadScene(5);
            }

        

        
    }

}
