using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawnerLR : MonoBehaviour
{
    public GameObject[] obstacles;
    public float spawnRate;

    void Start()
    {
        InvokeRepeating("SpawnRandom", 0, spawnRate);
    }

    void SpawnRandom()
    {
        int obstacleIndex = Random.Range(0, 3);
        int index;
        int[] positionBiases;
        if (obstacleIndex == 1)
        {
            positionBiases = new int[] {-3, -1, 1, 3};
            index = Random.Range(0, 4);
        }
        else 
        {
            positionBiases = new int[] {-4, -2, 0, 2, 4};
            index = Random.Range(0, 5);
        }
        int bias = positionBiases[index];
        Vector3 obstaclePosition = new Vector3(transform.position.x, transform.position.y, transform.position.z + bias);
        Instantiate(obstacles[obstacleIndex], obstaclePosition, transform.rotation);
    }
}
