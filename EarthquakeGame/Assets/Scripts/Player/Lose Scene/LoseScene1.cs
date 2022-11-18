using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseScene1 : MonoBehaviour
{

    float timer;
    int waitTimer;

    static public int obj1failcounter = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        GameObject collisionGameObject = collision.gameObject;

       
            if(collisionGameObject.tag == "Player"){
                //Objective 1: stay inside and duck cover hold
                //Objective 2: Stay inside Afterschock
                //Objective 3: Getting to an open space like the field is your top priority
                SceneManager.LoadScene(3);
            }

        

        
    }

}
