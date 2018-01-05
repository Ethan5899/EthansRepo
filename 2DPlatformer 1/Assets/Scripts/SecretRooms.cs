using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretRooms : MonoBehaviour {

    //These are the points you are moved to
    //marked in game by empty game objects
    //(6.3, -7.7)
    public GameObject Destination1;
    //(11.2, 0.15)
    public GameObject Destination2;

    private void Start()
    {
       
    }

    void OnCollisionEnter2D(Collision2D collision)

    {
        //when you collide with the pipe and press shift
       //you will be moved to the location of the game object
        if (collision.gameObject.name == "PipeE1" && Input.GetKeyDown(KeyCode.LeftShift))
        {
            transform.position = Destination1.transform.position;
        }

        if (collision.gameObject.name == "PipeE2" && Input.GetKeyDown(KeyCode.LeftShift))
        {
            transform.position = Destination2.transform.position;
        }
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        //when you collide with the pipe and press shift
        //you will be moved to the location of the game object

        if (collision.gameObject.name == "PipeE1" && Input.GetKeyDown(KeyCode.LeftShift))
        {
            transform.position = Destination1.transform.position;
        }

        if (collision.gameObject.name == "PipeE2" && Input.GetKeyDown(KeyCode.LeftShift))
        {
            transform.position = Destination2.transform.position;
        }
    }

   
}
