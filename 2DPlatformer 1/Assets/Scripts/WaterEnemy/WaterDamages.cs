using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterDamages : MonoBehaviour {

    //attach to the hit box on an enemy
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Feet")
        {
            transform.parent.GetComponent<PacingSign>().TakeDamage();
        }
    }
}
