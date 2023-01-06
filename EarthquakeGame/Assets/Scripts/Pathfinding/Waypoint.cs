using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Waypoint : MonoBehaviour
{
    public RectTransform prefab;

    private RectTransform waypoint;

    public Transform player;
    private Text distanceText;

    private Vector3 offset = new Vector3(0, 1.25f, 0);




    // Start is called before the first frame update
    void Start()
    {
        var canvas = GameObject.Find("Canvas").transform;

        waypoint = Instantiate(prefab, canvas);
        distanceText = waypoint.GetComponentInChildren<Text>();


    }

    // Update is called once per frame
    void Update()
    {
       
        if(Objective1.getOutClass == true)
        {
            var screenPos = Camera.main.WorldToScreenPoint(transform.position + offset);
            waypoint.position = screenPos;

            waypoint.gameObject.SetActive(screenPos.z > 0);
            distanceText.text = Vector3.Distance(player.position, transform.position).ToString("0") + " m";
        }
 
    }
}
