using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToadstoolBehaviour : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player") {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
