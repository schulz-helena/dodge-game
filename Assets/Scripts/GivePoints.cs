using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GivePoints : MonoBehaviour
{
    public GameObject triggeringSpawner;

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<Obstacle>())
        {
            if (other.GetComponent<Obstacle>().spawner == triggeringSpawner)
            {
                Destroy(other.gameObject);
                ScoreManager.instance.score += 1;
            }
        }
    }
}
