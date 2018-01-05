using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTakeDamage : MonoBehaviour {

	//attach to the hit box on an enemy
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Feet")
        {
            transform.parent.GetComponent<EnemyMoveLeft>().TakeDamage();
        }
    }
}
