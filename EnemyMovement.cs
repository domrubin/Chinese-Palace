using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

    //initailize variables
    public GameObject player;
    public Transform playerPos;
    public float enemySpeed = 3.0f;
    public Collider enemyCollider;

	// Use this for initialization
	void Start () {
        //assign the player and it's transform
        player = GameObject.Find("Player");
        playerPos = player.transform;
        enemyCollider = GetComponent<Collider>();
	}
	
	// Update is called once per frame
	void Update () {
        //make enemies move toward the player
        transform.position = Vector3.MoveTowards(transform.position, playerPos.position, enemySpeed);
	}

    void OnTriggerEnter(Collider enemyCollider)
    {
        if (enemyCollider.gameObject.tag == "Bullet")
        {
            Destroy(gameObject);

        }
    }
}
