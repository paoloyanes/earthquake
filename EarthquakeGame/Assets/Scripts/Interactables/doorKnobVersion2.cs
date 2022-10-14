using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class doorKnobVersion2 : Interactable
{
    [SerializeField]
    private GameObject doorVersion2;
    private bool doorOpenVersion2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //this function is where we will design our interaction using code :)
    protected override void Interact()
    {

        doorOpenVersion2 = !doorOpenVersion2;
        doorVersion2.GetComponent<Animator>().SetBool("IsOpenVersion2", doorOpenVersion2);
        
    }


    
}
