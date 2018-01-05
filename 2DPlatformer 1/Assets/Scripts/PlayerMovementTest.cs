using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementTest : MonoBehaviour {
    public float moveSpeed = 3.0f;
    public float jumpSpeed = 3.0f;
    private bool grounded = false;
    private bool DoubleJump;
    private bool bounce = false;
    Animator anim;
    public float bounceHeight = 250;
    private bool OnWallLeft = false;
    private bool OnWallRight = false;
    public float timer = 0.0f;

    // Animator anim;

    // Use this for initialization
    void Start()
    {
        DoubleJump = false;
        //anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        float moveX = Input.GetAxis("Horizontal");
        Vector2 velocity = GetComponent<Rigidbody2D>().velocity;
        velocity.x = moveSpeed * moveX;
        GetComponent<Rigidbody2D>().velocity = velocity;

        

        if (Input.GetButtonDown("Jump") && grounded)
        {
          //anim.SetBool("isJump", true);
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 100 * jumpSpeed));

        }
        if (bounce == true)
        {
          //anim.SetBool("isJump", true);
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, bounceHeight));
            bounce = false;
        }
       

            if (Input.GetButtonDown("Jump") && !grounded && !DoubleJump)
            {
              //anim.SetBool("isJump", true);
                GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 50 * jumpSpeed));
                DoubleJump = true;
            }
        if (Input.GetButtonDown("Jump") && OnWallLeft && timer > 0.5f)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(150 * moveSpeed, 100 * jumpSpeed));
            timer = 0;
        }

        if (Input.GetButtonDown("Jump") && OnWallRight && timer > 0.5f)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(-150 * moveSpeed, 100 * jumpSpeed));
            timer = 0;
        }

    }

        public void Grounded()
        {
            grounded = true;
            //anim.SetBool("isJump", false);
            DoubleJump = false;
        }

        public void NotGrounded()
        {
            grounded = false;
        }

    //when you are in water you have a lower mass and less mobility
    public void BlueFun()
    {
        moveSpeed = 2;
        jumpSpeed = 2;
        GetComponent<Rigidbody2D>().mass = 0.8f;
    }

    //when you are not in water you have a higher mass and mobility
    public void RedFun()
    {
        moveSpeed = 3;
        jumpSpeed = 3;
        GetComponent<Rigidbody2D>().mass = 1;
    }
    //when you are in flowing water you have the least mobility
    // and a medium mass
    public void Flows()
    {
        moveSpeed = 2;
        jumpSpeed = 1.8f;
        GetComponent<Rigidbody2D>().mass = 0.9f;
    }

        public void Bounce()
        {
            bounce = true;
        }
    public void WallingLeft()
    {
        OnWallLeft = true;
    }

    public void WallingRight()
    {
        OnWallRight = true;
    }

    public void OffLeft()
    {
        OnWallLeft = false;
    }

    public void OffRight()
    {
        OnWallRight = false;
    }
}




