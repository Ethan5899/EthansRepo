using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySides : MonoBehaviour {

	
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 8 || collision.gameObject.tag == "Enemy" || collision.gameObject.layer == 10)
        {
            transform.parent.GetComponent<EnemyMoveLeft>().HitWall();
        }
    }
    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8 || collision.gameObject.tag == "Enemy" || collision.gameObject.layer == 10)
        {
            transform.parent.GetComponent<EnemyMoveLeft>().HitWall();
        }
    }
}
