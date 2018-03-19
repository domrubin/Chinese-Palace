using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorControl : MonoBehaviour {
    //intitialize variables
    public bool open = false;
    public Transform openLoc;
    public Transform closedLoc;
    public float doorSpeed = 0.05f;

	// Use this for initialization
	void Start () {
    
	}
	
	// Update is called once per frame
	void Update () {
        //if the character is in the opening location...
        if (open == true){
            //move the door to the open position
            transform.position = Vector3.MoveTowards(transform.position, openLoc.position, doorSpeed);
        }
        //if the character leaves the opening location...
        else if (open == false){
            //move the door to the closed location
            transform.position = Vector3.MoveTowards(transform.position, closedLoc.position, doorSpeed);
        }
		
	}
}
