using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FailCounter3 : MonoBehaviour
{

    public Text ValueText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PF_Toggle.usedGuide)
        {
            ValueText.text = "Yes";
        }
        else
        {
            ValueText.text = "No";
        }

    }
}
