using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowScript : MonoBehaviour
{
    public GameObject arrow;

    void OnTriggerEnter(Collider info)
    {
        if(info.tag == "Player")
        {
            arrow.SetActive(false);
        }
    }
}
