using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class BookCollection : MonoBehaviour
{
    public Text collectionInfo;
    public Image collectionInfoBackground;
    public int countCollectedBooks = 0;
    public Text foundBookMessage;

    void Start() {
        collectionInfoBackground.enabled = false;
    }

    private void OnTriggerEnter(Collider other) {
        string currentTag = other.gameObject.tag;
        bool collidedWithABook = currentTag == "Book1" || currentTag == "Book2" || currentTag == "Book3" || currentTag == "Book4" || currentTag == "Book5";

        if (collidedWithABook) {
            countCollectedBooks += 1;
            foundBookMessage.enabled = true;
            collectionInfoBackground.enabled = true;
            collectionInfo.text = "Books found:" + countCollectedBooks + "/4";
            Destroy(other.gameObject);
            
            if (currentTag == "Book1") {
                foundBookMessage.text = "You found a book called 'Fantastic fungi and how to find them'!";
            } else if (currentTag == "Book2") {
                foundBookMessage.text = "You found a book called 'How to diversify your crops, from seed to pollination'!";
            } else if (currentTag == "Book3") {
                foundBookMessage.text = "You found a book called 'Wildlife gardening beyond the bug hotel'!";
            } else if (currentTag == "Book4") {
                foundBookMessage.text = "You found a book called 'How to transition away from fertilizers, pesticides and fungicides'!";
            }
            Invoke("DisableText", 5f);
        }
    }


    void DisableText() { 
        foundBookMessage.enabled = false;
    }   
}
