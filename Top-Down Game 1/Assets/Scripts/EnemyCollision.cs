using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour {

	void OnCollisionEnter2D (Collision2D CollisionInfo)
    {
        
        

        if (CollisionInfo.collider.gameObject.tag == "Health")
        {
            Destroy(gameObject);
        }
        if (CollisionInfo.collider.gameObject.tag == "portal")
        {
            Destroy(gameObject);
        }
        if (CollisionInfo.collider.gameObject.tag == "Boundary")
        {
            Destroy(gameObject);
        }
        if (CollisionInfo.collider.gameObject.tag == "Asteriod")
        {
            Destroy(gameObject);
        }
        if (CollisionInfo.collider.gameObject.tag == "Life")
        {
            Destroy(gameObject);
        }
    }

}
