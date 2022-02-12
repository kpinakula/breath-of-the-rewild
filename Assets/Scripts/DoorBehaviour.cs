using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBehaviour : MonoBehaviour
{
    public float openAmount = 0.0f;
    private Vector3 openDir;
    private float doorWidth;
    private Transform door; 
    private bool isDoorOpen;
    private float openSpeed = 2.0f;
    public bool isDoorLocked;

    void Start()
    {
        // the door is assumed to be child 0, aligned along the *local* x axis, and at position 0,0,0
        door = transform.GetChild(0);
        // find the width from the box colliders
        doorWidth = door.GetComponent<BoxCollider>().size.x;
        openDir = new Vector3(1.0f, 0.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if(isDoorOpen){
            openAmount += openSpeed * Time.deltaTime;
        } else {
            openAmount -= openSpeed * Time.deltaTime;
        }
        openAmount = Mathf.Clamp(openAmount, 0.0f, 1.0f);
        door.transform.localPosition = openDir * openAmount * doorWidth;
    }

    private void OnTriggerEnter(Collider other) {
         if (other.gameObject.tag == "Player") {
            isDoorOpen = true;
        }
    }

    private void OnTriggerExit(Collider other) {
         if (other.gameObject.tag == "Player") {
            isDoorOpen = false;
        }
    }
}
