using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Events;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obstacles;
    public float spawnRate;
    //public UnityEvent spawnL;
    //public UnityEvent spawnF;
    //public UnityEvent spawnR;
    public GameObject spawnerL;
    public GameObject spawnerF;
    public GameObject spawnerR;
    private Vector3 selectedPosition;
    private Quaternion selectedRotation;
    private Vector3 obstaclePosition;
    private GameObject selectedSpawner;

    void Start()
    {
        InvokeRepeating("Spawn", 0, spawnRate);
    }

    void Spawn()
    {
        int spawnerIndex = Random.Range(0, 3);

        int obstacleIndex = Random.Range(0, 3);
        int index;
        int[] positionBiases;
        if (obstacleIndex == 1)
        {
            //positionBiases = new int[] {-3, -1, 1, 3};
            positionBiases = new int[] {-1, 1};
            //index = Random.Range(0, 4);
            index = Random.Range(0, 2);
        }
        else 
        {
            //positionBiases = new int[] {-4, -2, 0, 2, 4};
            positionBiases = new int[] {-2, 0, 2};
            //index = Random.Range(0, 5);
            index = Random.Range(0, 3);
        }
        int bias = positionBiases[index];

        if (spawnerIndex == 0)
        {
            selectedPosition = spawnerL.transform.position;
            selectedRotation = spawnerL.transform.rotation;
            obstaclePosition = new Vector3(selectedPosition.x, selectedPosition.y, selectedPosition.z + bias);
            selectedSpawner = spawnerL;
        }
        else if (spawnerIndex == 1)
        {
            selectedPosition = spawnerF.transform.position;
            selectedRotation = spawnerF.transform.rotation;
            obstaclePosition = new Vector3(selectedPosition.x + bias, selectedPosition.y, selectedPosition.z);
            selectedSpawner = spawnerF;
        }
        else
        {
            selectedPosition = spawnerR.transform.position;
            selectedRotation = spawnerR.transform.rotation;
            obstaclePosition = new Vector3(selectedPosition.x, selectedPosition.y, selectedPosition.z + bias);
            selectedSpawner = spawnerR;
        }

        GameObject instantiatedObject = Instantiate(obstacles[obstacleIndex], obstaclePosition, selectedRotation);
        instantiatedObject.GetComponent<Obstacle>().spawner = selectedSpawner;
    }
}
