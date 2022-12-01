using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    private float PathUpdateSpeed = 0.25f;

    private Collectable ActiveInstance;
    private UnityEngine.AI.NavMeshTriangulation Triangulation;
    private Coroutine DrawPathCoroutine;
    private int starter = 1;

    private void Awake()
    {
        Triangulation = UnityEngine.AI.NavMesh.CalculateTriangulation();
    }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DrawPathToEnd());
    }

    // Update is called once per frame
    void Update()
    {
        
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
            else
            {
                Debug.LogError($"Unable to calculate a path on the NavMesg Between {Player.position} and {ActiveInstance.transform.position}!");
            }
            yield return Wait;
        }
    }

}
