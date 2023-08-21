using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{   
    public GameObject[] foodPrefabs;
    private float rangeXZ = 17;
    private float maxXZ = 17;

    private float startDelay = 4;
    private float spawnInterval = 1.0f;
    bool topSpawn;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomFood", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {   

    }

    void SpawnRandomFood()
    {
     
        int foodIndex = Random.Range(0, foodPrefabs.Length);


            Vector3 spawnPos = new Vector3(Random.Range(-rangeXZ,rangeXZ), 0 , Random.Range(-rangeXZ, rangeXZ));
            Instantiate(foodPrefabs[foodIndex], spawnPos, foodPrefabs[foodIndex].transform.rotation);
 

    }
}
