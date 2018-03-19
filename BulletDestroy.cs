using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroy : MonoBehaviour {

    //initialize variables
    public float time = 3.0f;
    public Collider bullet;
	// Use this for initialization
	void Start () {
        //assign variables
        bullet = GetComponent<Collider>();
    }
	
	// Update is called once per frame
	void Update () { 
        
        //destroys bullet after 3 seconds
        Destroy(gameObject, time);
	}
}
