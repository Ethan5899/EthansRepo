using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingEnemyFeet : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            transform.parent.GetComponent<JumpingEnemy>().Grounded();
        }
        if (collision.gameObject.layer == 4)
        {
            transform.parent.GetComponent<JumpingEnemy>().TakeDamage();
        }

    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            transform.parent.GetComponent<JumpingEnemy>().Grounded();
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            transform.parent.GetComponent<JumpingEnemy>().NotGrounded();
        }
        if (collision.gameObject.layer == 4)
        {
            transform.parent.GetComponent<JumpingEnemy>().TakeDamage();
        }
    }
}
