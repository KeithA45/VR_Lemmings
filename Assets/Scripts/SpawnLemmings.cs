using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLemmings : MonoBehaviour
{
    public GameObject objectToSpawn;
    public float initialDelayInSeconds = 10f;
    public float repeatedDelayInSeconds = 10f;

    public float spawnHeightAdjustment = 0.35f;
    public Vector3 spawnRangeVariation = new Vector3(0.5f, 0f, 0.5f);

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObject", initialDelayInSeconds, repeatedDelayInSeconds);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    Vector3 GetSpawnPoint() 
    {
        float x = Random.Range(0 - spawnRangeVariation.x, spawnRangeVariation.x);
        float y = Random.Range(0 - spawnRangeVariation.y, spawnRangeVariation.y);
        float z = Random.Range(0 - spawnRangeVariation.z, spawnRangeVariation.z);

        return transform.position + new Vector3(x, y + spawnHeightAdjustment, z);
    }

    void SpawnObject()
    {
        // use the platform's rotation to determine which way the lemmings should go
        Instantiate(objectToSpawn, GetSpawnPoint(), transform.rotation);
    }
}
