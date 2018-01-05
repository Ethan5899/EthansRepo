using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animcontrols3 : MonoBehaviour {
    Animator anim;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        //get axis raw gives us the base values ignoring how long the button has been pressed ,we get 1, -1, 0
        float moveX = Input.GetAxisRaw("Horizontal");
        anim.SetFloat("x", moveX);
        //if moveX == 0 were not getting user input, so we are not walking, tell this to the animator.
        if (moveX == 0)
        {
            anim.SetBool("isWalking", false);
        }
        else
        {
            anim.SetBool("isWalking", true);
        }

	}
}
