using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLemmings : MonoBehaviour
{
    public GameObject objectToSpawn;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObject", 2, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    Vector3 GetSpawnPoint() 
    {
        // Values are currently hard coded to positions on start platform
        float x = Random.Range(-0.9f, 1.83f);
        float y = Random.Range(0.97f, 1);
        float z = Random.Range(-5.3f, -2.4f);

        return new Vector3(x, y, z);
    }

    void SpawnObject()
    {
        // NOTE: Quaterion is the rotation
        Instantiate(objectToSpawn, GetSpawnPoint(), Quaternion.identity);
    }
}
