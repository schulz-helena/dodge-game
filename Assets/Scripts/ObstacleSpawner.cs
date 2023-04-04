using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstacle;

    void Start()
    {
        Instantiate(obstacle, transform.position, transform.rotation);
    }
}
