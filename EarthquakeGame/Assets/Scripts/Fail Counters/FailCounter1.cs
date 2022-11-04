using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FailCounter1 : MonoBehaviour
{

    public Text ValueText;

    public int FCObj1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int FCObj1 = LoseScene1.obj1failcounter;
        ValueText.text = FCObj1.ToString();
    }
}
