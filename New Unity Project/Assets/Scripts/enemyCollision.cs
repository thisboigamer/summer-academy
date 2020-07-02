using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyCollision : MonoBehaviour
{
    //serializeField allows you to assign something to this in Unity
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;

    //this script kills the player when running into a block
    private void OnCollisionEnter(Collision collisionInfo)
    {
        //first check if the box has run into a player
        if (collisionInfo.collider.tag == "Player")
        {
            //if the box runs into a plyer, respawn the player
            player.transform.position = respawnPoint.transform.position;
            Physics.SyncTransforms();
            //destroy the block
            Destroy(gameObject);
        }
    }
   
}
