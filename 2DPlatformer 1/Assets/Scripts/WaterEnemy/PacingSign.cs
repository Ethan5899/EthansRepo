using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacingSign : MonoBehaviour {

    public Vector3 paceDirection = new Vector3(0f, 0f, 0f);
    public float paceDistance = 3.0f;
    private Vector3 startPosition;
    public float chaseSpeed = 2.0f;
    Animator anim;
    public GameObject player;
    bool damage;
    public int Hp = 1;

    // Use this for initialization
    void Start () {
        //home space
        
        startPosition = transform.position;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update () {


        if (damage == true)
        {
            Hp -= 1;
            damage = false;

        }
        if (Hp <= 0)
        {

            Destroy(gameObject);
        }

        Vector2 vel = gameObject.GetComponent<Rigidbody2D>().velocity;
        float input_x = vel.x;
        Vector3 displacement = transform.position - startPosition;
        float distanceFromStart = displacement.magnitude;
        if (distanceFromStart >= paceDistance)
        {
            //do stuff, we've gone too far
            paceDirection = -displacement;
        }
            paceDirection.Normalize();
        GetComponent<Rigidbody2D>().velocity = paceDirection * chaseSpeed;
        anim.SetFloat("x", input_x);
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
}

