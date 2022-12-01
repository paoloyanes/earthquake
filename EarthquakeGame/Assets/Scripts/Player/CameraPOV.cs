using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPOV : MonoBehaviour
{
    public GameObject ThePlayer;
    public GameObject FirstPersonCam;
    public GameObject ThirdPersonCam;

    // Start is called before the first frame update
    void Start()
    {
        ThirdPersonCam.gameObject.SetActive(false);
        FirstPersonCam.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerMotor.crouching)
        {
            ThirdPersonCam.gameObject.SetActive(true);
            FirstPersonCam.gameObject.SetActive(false);
        }
        else
        {
            ThirdPersonCam.gameObject.SetActive(false);
            FirstPersonCam.gameObject.SetActive(true);
        }
    }
}
