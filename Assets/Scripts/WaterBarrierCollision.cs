using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class WaterBarrierCollision : MonoBehaviour
{

    private bool playerBreathsUnderWater = false;
    public Text drowningWarning;
    
    void OnTriggerEnter(Collider other) {
        playerBreathsUnderWater = other.GetComponent<FirstPersonController>().canBreatheLikeFish;
        // Debug.LogWarning("Player breaths under water: " + playerBreathsUnderWater);

        if (other.tag == "Player" && playerBreathsUnderWater) {
            Destroy(transform.parent.gameObject);
        } else {
            drowningWarning.text = "This is not a good idea. After all, you cannot breathe under water, can you?";
        }
    }
    
    void OnTriggerExit(Collider other) {
        drowningWarning.text  = "";
    } 
}