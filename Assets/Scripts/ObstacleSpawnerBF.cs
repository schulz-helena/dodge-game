using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawnerBF : MonoBehaviour
{
    public GameObject[] obstacles;

    void Start()
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
        Vector3 obstaclePosition = new Vector3(transform.position.x + bias, transform.position.y, transform.position.z);
        Instantiate(obstacles[obstacleIndex], obstaclePosition, transform.rotation);
    }
}
