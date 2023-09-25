using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContactDestroyer : MonoBehaviour
{
    public 

    void OnTriggerEnter(Collider other)
    {
        //if(other.GetComponent<Collider>().GetType() == typeof(CapsuleCollider)) Debug.Log("player collided");
        if(other.GetComponent<TilesPlayerMovement>()){
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
        if(other.GetComponent<Obstacle>()){
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
