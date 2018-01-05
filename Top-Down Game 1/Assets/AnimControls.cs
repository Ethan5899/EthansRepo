using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimControls : MonoBehaviour {
    Animator anim;
	// Use this for initialization
	void Start () {
        //assumes this script is attached to an object with an animator
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

        float input_x = Input.GetAxisRaw("Horizontal");
        float input_y = Input.GetAxisRaw("Vertical");

        bool isWalking = (Mathf.Abs(input_x) + Mathf.Abs(input_y) > 0);
        if (isWalking)
        {
            anim.SetFloat("x", input_x);
            anim.SetFloat("y", input_y);
        }
        anim.SetBool("isWalking", isWalking);
	}
}
