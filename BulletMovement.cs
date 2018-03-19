using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour {

    //initilize variables
    public GameObject bulletSpawn;
    public GameObject bullet;
    public Rigidbody bullet_R;
    public float bulletSpeed = 10.0f;

	// Use this for initialization
	void Start () {
        bulletSpawn = GameObject.Find("BulletSpawn");
        //bullet = (GameObject) (Resources.Load("Bullet"));
        bullet_R = bullet.GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        //if the right mouse button is clicked...
        if (Input.GetMouseButtonDown(0)){
            //...instantiate a bullet...
            GameObject shot = Instantiate(bullet, bulletSpawn.transform.position, bulletSpawn.transform.rotation);
            //...collect its rigidbody...
            Rigidbody shot_R = shot.GetComponent<Rigidbody>();
            //...and move bullet in requested direction
            shot_R.AddForce(bulletSpawn.transform.forward * bulletSpeed, ForceMode.Impulse);
        }
	}
}
