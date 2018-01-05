using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlatformerMovementWithFeet : MonoBehaviour
{
    public float moveSpeed = 3.0f;
    public float jumpSpeed = 3.0f;
    private bool grounded = false;
    Animator anim;
    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        Vector2 velocity = GetComponent<Rigidbody2D>().velocity;
        velocity.x = moveX * moveSpeed;
        GetComponent<Rigidbody2D>().velocity = velocity;
        if (Input.GetButtonDown("Jump") && grounded)
        {
            anim.SetBool("isJumping", true);
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 100 * jumpSpeed));
            grounded = false;
        }
    }



    public void Grounded()
    {
        grounded = true;
        anim.SetBool("isJumping", false);
    }

    public void NotGrounded()
    {
        grounded = false;
    }

    
}
