using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour {
    //initialize variables
    private Movement player;
    Collider groundCheck;

	// Use this for initialization
	void Start () {
        //assign collider to variable
        groundCheck = GetComponent<Collider>();
        player = GetComponentInParent<Movement>();
    }
	
	// Update is called once per frame
	void Update () {
	}

    //On enter, make grounded = true
    void OnTriggerEnter(Collider groundCheck){
        if (groundCheck.gameObject.tag == "Ground") {
            player.grounded = true;
        }
    }

    //On exit, make grounded = false
    void OnTriggerExit(Collider groundCheck){
        if (groundCheck.gameObject.tag == "Ground")
        {
            player.grounded = false;
        }
    }
}
