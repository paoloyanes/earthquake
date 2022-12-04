using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshBaker : MonoBehaviour
{
    public NavMeshSurface[] surfaces;
    public bool buildNavCheck = true;

    void Update()
    {
        if (buildNavCheck)
        {
            if(Objective1.buildNavStarter)
            {
                for(int i = 0; i < surfaces.Length; i++)
                {
                    surfaces[i].BuildNavMesh();
                }
                buildNavCheck = false;
            }
        }
        
    }
}
