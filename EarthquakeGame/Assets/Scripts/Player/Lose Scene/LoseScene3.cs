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
                //loadscene 3 = Objective 1: stay in classroom because of ongoing earthquake
                //loadscene 4 = Objective 2: stay in classroom because of possible aftershock
                //loadscene 5 = Objective 3: Get something hard to cover your head with while doing the DUCK COVER AND HOLD
                //loadscene 6 = Objective 4: Getting to an open space like the field is your top priority
                obj3failcounter++;
                SceneManager.LoadScene(5);
            }

        

        
    }

}
