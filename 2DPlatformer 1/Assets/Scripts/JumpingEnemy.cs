using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingEnemy : MonoBehaviour {

    public float moveSpeed = 1;
    public float triggerDistance = 1;
    public GameObject player;
    bool on = false;
    bool damage;
    public int Hp = 1;
    bool moveRight = false;
    bool moveLeft = false;
    public float jumpSpeed = 1;
    bool grounded = false;
    Animator anim;
    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {

        Vector3 playerPos = player.transform.position;
        Vector2 Distance = new Vector2(playerPos.x - transform.position.x,
                                                playerPos.y - transform.position.y);
      
        if (Distance.magnitude < triggerDistance)
        {
            on = true;

        }
        Vector2 velocity = GetComponent<Rigidbody2D>().velocity;

        //move left
        if (on == true && moveRight == false && grounded == true)
        {
            velocity.x = moveSpeed * -1;
            GetComponent<Rigidbody2D>().velocity = velocity;
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 100 * jumpSpeed));
            moveLeft = true;

        }

        if (damage == true)
        {
            Hp -= 1;
            damage = false;
        }
        if (Hp <= 0)
        {


            Destroy(gameObject);

        }
        //move right
        if (on == true && moveRight == true && grounded == true)
        {
            velocity.x = moveSpeed * 1;
            GetComponent<Rigidbody2D>().velocity = velocity;
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 100 * jumpSpeed));

        }
        float moveX = velocity.x;
        anim.SetFloat("x", moveX);

    }

    public void TakeDamage()
    {
        damage = true;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "killBoundary")
        {
            Hp = 0;
        }

        if (collision.gameObject.tag == "Player" && GameObject.Find("player").GetComponent<PlayerHealth>().invincible == true)
        {
            Hp = 0;
        }
    }
    public void HitWall()
    {
        Debug.Log("HitWall");
        if (moveRight == false && moveLeft == true)
        {
            moveRight = true;
            moveLeft = false;
            return;
        }
        if (moveLeft == false && moveRight == true)
        {
            moveLeft = true;
            moveRight = false;
            return;
        }
    }
    public void Grounded()
    {
        grounded = true;
    }
    public void NotGrounded()
    {
        grounded = false;
    }
}
