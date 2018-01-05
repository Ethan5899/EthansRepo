using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformerMovement : MonoBehaviour {
    public float moveSpeed = 1;
    public float jumpSpeed = 1;
    private bool grounded = false;
    public GameObject groundCheck;


	// Use this for initialization
	void Start () {
		
	}
	


	// Update is called once per frame
	void Update () {
        float moveX = Input.GetAxis("Horizontal");
        Vector2 velocity = GetComponent<Rigidbody2D>().velocity;
        velocity.x = moveSpeed * moveX;
        GetComponent<Rigidbody2D>().velocity = velocity;
        if(velocity.y == 0)

        if (Input.GetButtonDown("Jump") && grounded)
        {
                
                GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 100 * jumpSpeed));
                grounded = false;
            }

	}
    void OnCollisionEnter2D(Collision2D collision)
    {
        //if we collided with anything on the ground layer we are grounded
        if(collision.gameObject.layer == 8)
        {
            grounded = true;
        }
    }
    void OnCollisionExit2D (Collision2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            grounded = false;
        }
    }
    void OnCollisionStay2D (Collision2D collision)
    {
        //if we collided with anything on the ground layer we are grounded
        if (collision.gameObject.layer == 8)
        {
            grounded = true;
        }
    }
}
