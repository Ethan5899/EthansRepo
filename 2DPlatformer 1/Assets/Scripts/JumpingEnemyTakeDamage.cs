using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingEnemyTakeDamage : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Feet")
        {
            transform.parent.GetComponent<JumpingEnemy>().TakeDamage();
        }
    }
}
