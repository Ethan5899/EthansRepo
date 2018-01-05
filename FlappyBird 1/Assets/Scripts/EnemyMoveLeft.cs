using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveLeft : MonoBehaviour {
    public float moveSpeed = 1;
    public float triggerDistance = 1;
    public GameObject player;
    bool on = false;
	// Use this for initialization
	void Start () {
		
	}

   
    // Update is called once per frame
    void Update () {
        Vector3 playerPos = player.transform.position;
        Vector2 Distance = new Vector2(playerPos.x - transform.position.x,
                                                playerPos.y - transform.position.y);
        if (Distance.magnitude < triggerDistance)
        {
            on = true;
        }

        Vector2 velocity = GetComponent<Rigidbody2D>().velocity;
        velocity.x = moveSpeed * -1;
        if (on == true){
            GetComponent<Rigidbody2D>().velocity = velocity;
        }
	}
}
