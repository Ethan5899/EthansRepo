using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLeft : MonoBehaviour
{


    //if you run into the wall this will let you jump
    //if you want
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 10)
        {
            transform.parent.GetComponent<PlayerMovementTest>().WallingLeft();
        }
    }

    //This is telling you you may not wall jump when not on a wall
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 10)
        {
            transform.parent.GetComponent<PlayerMovementTest>().OffLeft();
        }
    }

    //if you are on the wall and just stay there this will let you jump
    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 10)
        {
            transform.parent.GetComponent<PlayerMovementTest>().WallingLeft();
        }
    }
}
