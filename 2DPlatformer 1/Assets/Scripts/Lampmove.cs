using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lampmove : MonoBehaviour
{

    public float moveSpeed = 3.0f;
    public float jumpSpeed = 3.0f;
    private bool grounded = false;
    private bool DoubleJump;
    private bool OnWallLeft = false;
    private bool OnWallRight = false;
    public float timer = 0.0f;
    public float timer2 = 0.0f;
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
        timer2 += Time.deltaTime;

        float moveX = Input.GetAxis("Horizontal");
        Vector2 velocity = GetComponent<Rigidbody2D>().velocity;
        velocity.x = moveSpeed * moveX;
        GetComponent<Rigidbody2D>().velocity = velocity;

        if (Input.GetButtonDown("Jump") && grounded)
        {
            //anim.SetBool("isJump", true);
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 100 * jumpSpeed));
        }

        if (Input.GetButtonDown("Jump") && !grounded && !DoubleJump)
        {
            //anim.SetBool("isJump", true);
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 50 * jumpSpeed));
            DoubleJump = true;
        }

        //lets you wall jump off left wall, has a one second cool down
        if (Input.GetButtonDown("Jump") && OnWallLeft && timer > 1)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(150 * moveSpeed, 100 * jumpSpeed));
            timer = 0;
        }

        //lets you wall jump off right wall, has a one second cool down
        if (Input.GetButtonDown("Jump") && OnWallRight && timer2 > 1)
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
        moveSpeed = 5;
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


    //On a left wall
    public void WallingLeft ()
    {
        OnWallLeft = true;
    }

    //On a right wall
    public void WallingRight()
    {
        OnWallRight = true;
    }

    //having left left wall
    public void OffLeft()
    {
        OnWallLeft = false;
    }

    //having left right wall
    public void OffRight ()
    {
        OnWallRight = false;
    }

}
