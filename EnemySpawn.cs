using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {

    //initialize variables
    public Transform enemySpawnPos;
    public GameObject enemy;
    Collider spawnCollider;
    public bool cannotSpawn = false;
    
	// Use this for initialization
	void Start () {

        //assign the transform and collider of spawn point
        enemySpawnPos = GetComponent<Transform>();
        spawnCollider = GetComponent<Collider>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider spawnCollider){
        //if the spawner hasn't spawned an enemy yet...
        if (cannotSpawn == false)
        {
            //...spawn an enemy and set the spawner so it does not spawn any more
            if (spawnCollider.gameObject.tag == "Trigger")
            {
                //GameObject enemy = (GameObject)Instantiate(Resources.Load("Enemy"));
                enemy.transform.position = new Vector3(enemySpawnPos.position.x, enemySpawnPos.position.y, enemySpawnPos.position.z);
                cannotSpawn = true;
            }
        }
    }
}
