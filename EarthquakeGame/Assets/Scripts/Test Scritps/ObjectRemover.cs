using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRemover : MonoBehaviour
{
    public GameObject FirstFloorObstacle1;
    public GameObject FirstFloorObstacle2;

    public GameObject SecondFloorObstacle1;
    public GameObject SecondFloorObstacle2;

    public GameObject ThirdFloorObstacle1;
    public GameObject ThirdFloorObstacle2;

    public bool intensityChecker = true;
    // Start is called before the first frame update
    void Start()
    {
        intensityChecker = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (intensityChecker == true)
        {
            if(StateNameController.intensityValue < 5 && StateNameController.intensityValue > 2)
            {
                FirstFloorObstacle1.SetActive(true);
                FirstFloorObstacle2.SetActive(false);

                SecondFloorObstacle1.SetActive(false);
                SecondFloorObstacle2.SetActive(false);

                ThirdFloorObstacle1.SetActive(true);
                ThirdFloorObstacle2.SetActive(false);
            }
            else if (StateNameController.intensityValue == 6)
            {
                FirstFloorObstacle1.SetActive(false);
                FirstFloorObstacle2.SetActive(true);

                SecondFloorObstacle1.SetActive(false);
                SecondFloorObstacle2.SetActive(true);

                ThirdFloorObstacle1.SetActive(false);
                ThirdFloorObstacle2.SetActive(true);
            }
            else if (StateNameController.intensityValue == 7)
            {
                FirstFloorObstacle1.SetActive(true);
                FirstFloorObstacle2.SetActive(true);

                SecondFloorObstacle1.SetActive(false);
                SecondFloorObstacle2.SetActive(true);

                ThirdFloorObstacle1.SetActive(false);
                ThirdFloorObstacle2.SetActive(true);
            }
            else if (StateNameController.intensityValue == 8)
            {
                FirstFloorObstacle1.SetActive(true);
                FirstFloorObstacle2.SetActive(true);

                SecondFloorObstacle1.SetActive(true);
                SecondFloorObstacle2.SetActive(true);

                ThirdFloorObstacle1.SetActive(true);
                ThirdFloorObstacle2.SetActive(true);
            }
            else
            {
                FirstFloorObstacle1.SetActive(false);
                FirstFloorObstacle2.SetActive(false);

                SecondFloorObstacle1.SetActive(false);
                SecondFloorObstacle2.SetActive(false);

                ThirdFloorObstacle1.SetActive(false);
                ThirdFloorObstacle2.SetActive(false);
            }
            intensityChecker = false;
        }
    }
}
