using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FailCounter2 : MonoBehaviour
{

    public Text ValueText;

    public int FCObj2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int FCObj2 = LoseScene2.obj2failcounter;
        ValueText.text = FCObj2.ToString();
    }
}
