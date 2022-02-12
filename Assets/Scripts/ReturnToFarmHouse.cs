using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class ReturnToFarmHouse : MonoBehaviour
{
    private bool foundAllBooks;
    public Text completedMessage;
    public Image messageBackground;
    public AudioSource birdSong;
    
    private void OnTriggerEnter(Collider other) {
        foundAllBooks = GetComponent<BookCollection>().countCollectedBooks == 4;
        Debug.LogWarning("found all books" + foundAllBooks);
        Debug.LogWarning("Found " + GetComponent<BookCollection>().countCollectedBooks);

        if (other.gameObject.tag == "Finish" && foundAllBooks) {
            messageBackground.enabled = true;
            completedMessage.enabled = true;
            completedMessage.text = "Congrats!!! Your library is complete again. Now you can finish learning how to rewild the land.";
            Invoke("DisableText", 8f);
            birdSong.Play();
        } else if (other.gameObject.tag == "Finish") {
            completedMessage.text = "Seems like you've missed a book. Come back once you've collected all 4 of them.";
            Invoke("DisableText", 8f);
        }
    }

    void DisableText() { 
        completedMessage.enabled = false;
        messageBackground.enabled = false;
    }  
}
