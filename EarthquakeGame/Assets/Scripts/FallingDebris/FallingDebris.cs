using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingDebris : MonoBehaviour
{
    public GameObject debris;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (CameraShake.shaking)
        {
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-10,11), 2, Random.Range(-10,11));
            Instantiate(debris, randomSpawnPosition, Quaternion.identity);
        }
    }
}
