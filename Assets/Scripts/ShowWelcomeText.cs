using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowWelcomeText : MonoBehaviour
{   
    public Text welcomeMessage;
    public Image messageBackground;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("DisableText", 8f);
    }

    void DisableText() { 
        welcomeMessage.enabled = false;
        messageBackground.enabled = false;
    }   
}
