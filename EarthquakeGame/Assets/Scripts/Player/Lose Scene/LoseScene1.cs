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
                //loadscene 3 = Objective 1: stay in classroom because of ongoing earthquake
                //loadscene 4 = Objective 2: stay in classroom because of possible aftershock
                obj1failcounter ++;
                SceneManager.LoadScene(3);
            }

        

        
    }

}
