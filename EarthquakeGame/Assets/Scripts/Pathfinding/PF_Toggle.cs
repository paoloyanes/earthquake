using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PF_Toggle : MonoBehaviour
{
    public GameObject guide;
    public bool toggle = false;
    public static bool usedGuide = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.N))
        {
            if(toggle == false)
            {
            toggle = true;
            guide.SetActive(true);
            }
            else
            {
            toggle = false;
            guide.SetActive(false);
            }
               
        }
        if(toggle == true)
        {
            usedGuide = true;
        }
    }
}
