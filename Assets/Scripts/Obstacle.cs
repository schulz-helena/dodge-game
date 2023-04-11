using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float destroyTime;
    void Start()
    {
        ObstacleManager.instance.obstacles.Add(this);
        Destroy(gameObject, destroyTime);
    }

    void OnDestroy()
    {
        ObstacleManager.instance.obstacles.Remove(this);
    }
}
