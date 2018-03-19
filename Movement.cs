using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour {

    public float speed = 5.0F;
    public float jumpHeight = 5;
    public Rigidbody playerBody;
    public bool grounded = false;
    public int health;
    public Text healthText;

	// Use this for initialization
	void Start () {
        //lock cursor in fame window and remove it from visibility
        Cursor.lockState = CursorLockMode.Locked;
        playerBody = GetComponent<Rigidbody>();
        health = 500;
        SetHealth();
    }
	
	// Update is called once per frame
	void Update () {
        //assign forward/backward and left/right movement to keyboard input
        float translation = Input.GetAxis("Vertical") * speed;
        float straffe = Input.GetAxis("Horizontal") * speed;
        //make movement affected by time, therefore making it smooth
        translation *= Time.deltaTime;
        straffe *= Time.deltaTime;
        //running
        if(Input.GetKeyDown("left shift")){
            speed = speed * 2;
        }

        if (Input.GetKeyUp("left shift")){
            speed = speed / 2;
        }

        if (Input.GetButtonDown("Jump") && (grounded == true)){
            playerBody.velocity = new Vector3(playerBody.velocity.x, jumpHeight, playerBody.velocity.z);
        }

        //assign movements to the correct axis
        transform.Translate(straffe, 0, translation);

        //turn cursor back to normal
        if (Input.GetKeyDown("escape")){
            Cursor.lockState = CursorLockMode.None;
        }

        //if the player's health reaches zero...
        if (health == 0){
            Application.LoadLevel("clinic 1");

        }

    }
    void OnTriggerEnter(Collider collider){
        if (collider.gameObject.tag == "Enemy"){
            health -= 100;
            SetHealth();
        }
    }

    void SetHealth(){
        healthText.text = health.ToString();
    }
}
