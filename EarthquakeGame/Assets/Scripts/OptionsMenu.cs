using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    public Slider intensityLevel;
    public void intensityLevelValueSelect()
    {
        StateNameController.intensityValue = intensityLevel.value;
        
    }

}
