using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{
    [SerializeField] GameObject startingLocation01, startingLocation12, startingLocation17;

    Vector3 location01, location12, location17;

    bool isDone = false;

    // Start is called before the first frame update
    void Start()
    {
        location01 = startingLocation01.transform.position;
        location12 = startingLocation12.transform.position;
        location17 = startingLocation17.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isDone)
        {
            if (StateNameController.selectStartingLocationDropdown == 0)
            {
                PlayerStartingLocation(location01);
            }
            else if (StateNameController.selectStartingLocationDropdown == 1)
            {
                PlayerStartingLocation(location12);
            }
            else if (StateNameController.selectStartingLocationDropdown == 2)
            {
                PlayerStartingLocation(location17);
            }
            isDone = true;
        }
        
    }

    void PlayerStartingLocation(Vector3 location)
    {
        gameObject.transform.position = location;
        Debug.Log(location + " Teleported!");
    }

}
