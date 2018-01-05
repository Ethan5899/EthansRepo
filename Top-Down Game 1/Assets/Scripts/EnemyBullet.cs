using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour {

    void OnCollisionEnter2D (Collision2D Col)
    {



        if (Col.collider.gameObject.tag == "Health")
        {
            Destroy(gameObject);
        }
        if (Col.collider.gameObject.tag == "portal")
        {
            Destroy(gameObject);
        }
        if (Col.collider.gameObject.tag == "Boundary")
        {
            Destroy(gameObject);
        }
        if (Col.collider.gameObject.tag == "Asteriod")
        {
            Destroy(gameObject);
        }
        if (Col.collider.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
        if (Col.collider.gameObject.tag == "Life")
        {
            Destroy(gameObject);
        }
    }
}
