using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class IntensityLevelScript : MonoBehaviour
{
    //This is for the Slider
    public Slider intensityLevel;
    public TextMeshProUGUI intensityValue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        intensityValue.text = intensityLevel.value.ToString();
    }
}
