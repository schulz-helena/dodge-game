using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilesPlayerMovement : MonoBehaviour
{
    private Vector3 initialPosition;
    private float boundF;
    private float boundB;
    private float boundR;
    private float boundL;
    void Start()
    {
        initialPosition = transform.position;
        boundF = initialPosition.z + 3;
        boundB = initialPosition.z - 3;
        boundR = initialPosition.x + 3;
        boundL = initialPosition.x - 3;
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (transform.position.z + 2 < boundF)
            {
                transform.Translate(0, 0, 2);
            }
        }
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (transform.position.z - 2 > boundB)
            {
                transform.Translate(0, 0, -2);
            }
        }
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (transform.position.x + 2 < boundR)
            {
                transform.Translate(2, 0, 0);
            }
        }
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (transform.position.x - 2 > boundL)
            {
                transform.Translate(-2, 0, 0);
            }
        }
    }
}
