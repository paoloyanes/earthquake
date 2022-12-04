using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandHeldBook : MonoBehaviour
{

    public GameObject heldBook;

    // Update is called once per frame
    void Update()
    {
        if(PickUpController.slotFull && PlayerMotor.crouching)
        {
            heldBook.SetActive(true);
        }
        else
        {
            heldBook.SetActive(false);
        }
    }
}
