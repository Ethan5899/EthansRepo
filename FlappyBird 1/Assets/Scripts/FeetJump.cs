using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FeetJump : MonoBehaviour {

void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 8)
        {
            transform.parent.GetComponent<PlatformerMovementWithFeet>().Grounded();
        }
        if (collision.gameObject.layer == 9)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            transform.parent.GetComponent<PlatformerMovementWithFeet>().NotGrounded();
        }
    }
    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            transform.parent.GetComponent<PlatformerMovementWithFeet>().Grounded();
        }
    }
}
