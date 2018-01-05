using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeetTest : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8 || collision.gameObject.layer == 4)
        {
            transform.parent.GetComponent<PlayerMovementTest>().Grounded();
        }
        if(collision.gameObject.tag == "Bounce")
        {
            transform.parent.GetComponent<PlayerMovementTest>().Bounce();
        }
        //parents the player to the moving platform when they collide
        if (collision.gameObject.tag == "MovingPlatform")
        {
            //inside if statement with tag
            transform.parent.SetParent(collision.gameObject.transform);//, true);

        }
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8 || collision.gameObject.layer == 4)
        {
            transform.parent.GetComponent<PlayerMovementTest>().Grounded();
        }
        //parents the player to the moving platform when they collide
        if (collision.gameObject.tag == "MovingPlatform")
        {
            //inside if statement with tag
            transform.parent.SetParent(collision.gameObject.transform);//, true);

        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8 || collision.gameObject.layer == 4)
        {
            transform.parent.GetComponent<PlayerMovementTest>().NotGrounded();
        }
        //deparents the player from the moving platform
        if (collision.gameObject.tag == "MovingPlatform")
        {
            //inside if statement with tag
            transform.parent.transform.parent.DetachChildren();
        }
    }

    
}
