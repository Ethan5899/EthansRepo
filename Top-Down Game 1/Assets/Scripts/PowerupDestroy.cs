using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupDestroy : MonoBehaviour {

	void OnCollisionEnter2D (Collision2D Col)
    {
        if (Col.collider.gameObject.tag == "Player")
        {
            Destroy (gameObject);
        }
    }
}
