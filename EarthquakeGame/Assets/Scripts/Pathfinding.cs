using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pathfinding : MonoBehaviour
{
    Queue<GameObject> arrows = new Queue<GameObject>();

    Queue<GameObject> Floodfill(GameObject start, GameObject exit)
    {
        Dictionary<GameObject, GameObject> nextArrowToGoal = new Dictionary<GameObject, GameObject>();
        Queue<GameObject> frontier = new Queue<GameObject>();
        List<GameObject> visited = new List<GameObject>();

        frontier.Enqueue(exit); 

        while(frontier.Count > 0)
        {
            GameObject curArrow = frontier.Dequeue();

            //foreach(GameObject neighbor in )
        }

        return null;
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
