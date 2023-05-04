using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBottles : MonoBehaviour
{
    public GameObject bottlePrefab; 
    public int numBottlesToSpawn;

    void Start()
    {
        for (int i = 0; i < numBottlesToSpawn; i++)
        {
            GameObject bottleInstance = Instantiate(bottlePrefab);

            float x = Random.Range(-733f,-171f );
            float z = Random.Range(653f,-27f );
            Vector3 randomPosition = new Vector3(x, -0.5f, z);

            bottleInstance.transform.position = randomPosition;
        }
    }
}