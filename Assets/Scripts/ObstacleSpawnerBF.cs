using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawnerBF : MonoBehaviour
{
    public GameObject obstacle;

    void Start()
    {
        int[] positionBiases = {-4, -2, 0, 2, 4};
        int index = Random.Range(0, 5);
        int bias = positionBiases[index];
        Vector3 obstaclePosition = new Vector3(transform.position.x + bias, transform.position.y, transform.position.z);
        Instantiate(obstacle, obstaclePosition, transform.rotation);
    }
}
