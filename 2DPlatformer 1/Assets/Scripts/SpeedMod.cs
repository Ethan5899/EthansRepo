using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedMod : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D collision)
    {
        //entering or within water
        if (collision.gameObject.layer == 4 && collision.gameObject.layer != 11)
        {
            transform.GetComponent<PlayerMovementTest>().BlueFun();
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        //leaving water
        if (collision.gameObject.layer == 4 && collision.gameObject.layer != 11)
        {
            transform.GetComponent<PlayerMovementTest>().RedFun();
        }
    }
}
