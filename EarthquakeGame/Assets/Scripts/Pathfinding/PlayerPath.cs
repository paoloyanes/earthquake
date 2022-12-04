using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerPath : MonoBehaviour
{
    [SerializeField]
    private Transform End;
    [SerializeField]
    private Transform Player;
    [SerializeField]
    private LineRenderer Path;
    [SerializeField]
    private float PathHeightOffset = 1.25f;
    [SerializeField]
    private float PathUpdateSpeed = 0.10f;



    private Collectable ActiveInstance;
    private UnityEngine.AI.NavMeshTriangulation Triangulation;
    private Coroutine DrawPathCoroutine;
    private int starter = 1;
    private bool drawPathStarter = true;




    private void Awake()
    {
        Triangulation = UnityEngine.AI.NavMesh.CalculateTriangulation();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        
        if(drawPathStarter == true)
        {
            if(Objective1.getOutClass == true)
            {
                StartCoroutine(DrawPathToEnd());
                drawPathStarter = false;
            }
        }
        

    }

    private IEnumerator DrawPathToEnd()
    {
        WaitForSeconds Wait = new WaitForSeconds(PathUpdateSpeed);
        UnityEngine.AI.NavMeshPath path = new UnityEngine.AI.NavMeshPath();

        while(starter == 1)
        {
    
            if (UnityEngine.AI.NavMesh.CalculatePath(Player.position, End.position, UnityEngine.AI.NavMesh.AllAreas, path))
            {
                Path.positionCount = path.corners.Length;

                for (int i = 0; i < path.corners.Length; i++)
                {
                    Path.SetPosition(i, path.corners[i] + Vector3.up * PathHeightOffset);
                }
            }
            yield return Wait;

        }
        
    }

}
