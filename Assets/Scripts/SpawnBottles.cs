using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBottles : MonoBehaviour
{
    public GameObject PrefabBottle1;
    public GameObject PrefabBottle2;
    public GameObject PrefabBottle3;
    public int Bottle1;
    public int Bottle2;
    public int Bottle3;
    private float minX = -1084f;
    private float maxX = 65f;
    private float minZ = -264f;
    private float maxZ = 839f;
    private Vector2 noSpawnAreaMin = new Vector2(-559.9f, 230.2f);
    private Vector2 noSpawnAreaMax = new Vector2(-530.1f, 294.92f);

    void Start()
    {
        for (int i = 0; i < Bottle1; i++)
        {
            GameObject bottleInstance = Instantiate(PrefabBottle1);

            Vector3 randomPosition = GetRandomPosition();

            bottleInstance.transform.position = randomPosition;
            bottleInstance.transform.rotation = Quaternion.Euler(0f, Random.Range(0f, 360f), 0f);
        }

        for (int i = 0; i < Bottle2; i++)
        {
            GameObject instance;
            if (Random.value < 0.5f)
            {
                instance = Instantiate(PrefabBottle1);
            }
            else
            {
                instance = Instantiate(PrefabBottle2);
            }

            Vector3 randomPosition = GetRandomPosition();

            instance.transform.position = randomPosition;
            instance.transform.rotation = Quaternion.Euler(0f, Random.Range(0f, 360f), 0f);
        }

        for (int i = 0; i < Bottle3; i++)
        {
            GameObject bottleInstance = Instantiate(PrefabBottle3);

            Vector3 randomPosition = GetRandomPosition();

            bottleInstance.transform.position = randomPosition;
            bottleInstance.transform.rotation = Quaternion.Euler(0f, Random.Range(0f, 360f), 0f);
        }
    }

    private Vector3 GetRandomPosition()
    {
        Vector3 randomPosition;
        do
        {
            float x = Random.Range(minX, maxX);
            float z = Random.Range(minZ, maxZ);
            randomPosition = new Vector3(x, 0.3f, z);
        } while (IsInNoSpawnArea(randomPosition));

        return randomPosition;
    }

    private bool IsInNoSpawnArea(Vector3 position)
    {
        if (position.x >= noSpawnAreaMin.x && position.x <= noSpawnAreaMax.x && position.z >= noSpawnAreaMin.y && position.z <= noSpawnAreaMax.y)
        {
            return true;
        }

        return false;
    }
}