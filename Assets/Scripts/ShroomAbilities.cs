using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class ShroomAbilities : MonoBehaviour
{
    public Text foundShroomMessage;

    private void OnTriggerEnter(Collider other) {
        // Debug.LogWarning("Collision with " + other);
        // TODO: refactor below to mimimize repetition
        if (other.gameObject.tag == "FrogLegs") {
            // Debug.LogWarning("Quack!");
            Destroy(other.gameObject);
            foundShroomMessage.text = "You found and a rare Frog Leg Mushroom! What will it let you do?";
            Invoke("DisableText", 5f);
            GetComponent<FirstPersonController>().JumpLikeFrog();
        } else if (other.gameObject.tag == "FishLungs") {
            Destroy(other.gameObject);
            foundShroomMessage.text = "You found and a rare Fish Lungs Mushroom! What will it let you do?";
            Invoke("DisableText", 5f);
            GetComponent<FirstPersonController>().BreathLikeFish();
        } else if (other.gameObject.tag == "Miracle") {
            // TODO: ensure book at bottom of lake found before this, or make this ability controllable through a menu
            Destroy(other.gameObject);
            foundShroomMessage.text = "You found and a rare Miracle Mushroom! What will it let you do?";
            Invoke("DisableText", 5f);
            GetComponent<FirstPersonController>().BecomeWaterStrider();
        }
    }

    void DisableText() { 
        foundShroomMessage.text = ""; 
    }   
}
