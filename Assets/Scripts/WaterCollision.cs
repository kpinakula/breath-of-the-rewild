using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class WaterCollision : MonoBehaviour
{
    private bool playerWalksOnWater = false;
    
    void OnTriggerEnter(Collider other) {        
        playerWalksOnWater = other.GetComponent<FirstPersonController>().canWalkLikeJesus;
        // Debug.LogWarning("player walks on water: " + playerWalksOnWater);

        if (other.tag == "Player" && playerWalksOnWater) {
            GetComponent<Collider>().isTrigger = false;
        }
    }
}