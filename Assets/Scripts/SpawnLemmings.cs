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
        float x = Random.Range(-9, 9);
        float y = Random.Range(0.6f, 1);
        float z = Random.Range(-9, 9);

        return new Vector3(x, y, z);
    }

    void SpawnObject()
    {
        // NOTE: Quaterion is the rotation
        Instantiate(objectToSpawn, GetSpawnPoint(), Quaternion.identity);
    }
}
