using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FlappyBirdMovement : MonoBehaviour {
    public float moveSpeed = 3;
    public float jumpSpeed = 10;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 move = new Vector2(moveSpeed, 
            GetComponent<Rigidbody2D>().velocity.y);
        GetComponent<Rigidbody2D>().velocity = move;
        if (Input.anyKeyDown)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpSpeed));
        }
	}
    void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
