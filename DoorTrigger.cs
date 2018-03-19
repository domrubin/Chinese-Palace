using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour {
    //initialize variables
    public GameObject door1;
    public GameObject door2;
    private DoorControl control1;
    private DoorControl control2;
    
	// Use this for initialization
	void Start () {
        //assign variables
        control1 = door1.GetComponent<DoorControl>();
        control2 = door2.GetComponent<DoorControl>();
    }

    // Update is called once per frame
    void Update () {
		
	}

    void OnTriggerEnter(Collider collider){
        //if player enters trigger area...
        if (collider.gameObject.tag == "Trigger" || collider.gameObject.tag == "Enemy")
        {
            //set doors to open
            control1.open = true;
            control2.open = true;
        }
    }

    void OnTriggerExit(Collider collider)
    {
        //if player leaves trigger area...
        if (collider.gameObject.tag == "Trigger" || collider.gameObject.tag == "Enemy")
        {
            //set doors to close...
            control1.open = false;
            control2.open = false;
        }
    }
}
