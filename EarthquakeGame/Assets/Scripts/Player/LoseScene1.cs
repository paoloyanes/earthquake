using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseScene1 : MonoBehaviour
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
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        GameObject collisionGameObject = collision.gameObject;

       
            if(collisionGameObject.tag == "Player"){
                SceneManager.LoadScene(3);
            }

        

        
    }

}
