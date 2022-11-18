using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FailCounter4 : MonoBehaviour
{

    public Text ValueText;

    public int FCObj3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Get to the Field
        int FCObj3 = LoseScene3.obj3failcounter;
        ValueText.text = FCObj3.ToString();
    }
}
