using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject charModel;

    

    void OnTriggerEnter(Collider other)
    {
            this.gameObject.GetComponent<BoxCollider>().enabled = false;
            thePlayer.GetComponent<PlayerMovement>().enabled = false;
            charModel.GetComponent<Animator>().Play("Zombie Stumbling");
    }
}