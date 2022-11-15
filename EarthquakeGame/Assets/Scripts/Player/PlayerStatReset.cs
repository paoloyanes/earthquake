using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatReset : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LoseScene1.obj1failcounter = 0;
        LoseScene2.obj2failcounter = 0;
        LoseScene3.obj3failcounter = 0;

        PickUpController.slotFull = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
