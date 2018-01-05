using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterFlows : MonoBehaviour {

    public float flowspd = 1.5f;
   void OnTriggerExit2D (Collider2D collision)
    {
        if (collision.gameObject.layer == 11)
        {
            transform.GetComponent<PlayerMovementTest>().BlueFun();
        }
    } 

    void OnTriggerStay2D(Collider2D collision)
    {
        //if on the waterflows enable the Flows funtion in the movement script
        if (collision.gameObject.layer == 11)
        {
            transform.GetComponent<PlayerMovementTest>().Flows();
        } 


        //The various water flows and with what force and direction they push you
        if (collision.gameObject.name == "RightFlow")
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(60, 0));
        }
        if (collision.gameObject.name == "LeftFlow")
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(-60, 0));
        }

        if (collision.gameObject.name == "UpFlow")
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 2));
        }

        if (collision.gameObject.name == "DownFlow")
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -1*flowspd)); 
        }
    }
}
