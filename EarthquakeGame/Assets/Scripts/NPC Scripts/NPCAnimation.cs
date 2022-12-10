using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCAnimation : MonoBehaviour
{
    public bool isShaking;
    public GameObject FieldNPC;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(CameraShake.shaking)
        {
            FieldNPC.GetComponent<Animator>().Play("BoyNPC2DropCoverHold");
        }
        else
        {
            FieldNPC.GetComponent<Animator>().Play("BoyNPC1Idle");
        }

    }
}
