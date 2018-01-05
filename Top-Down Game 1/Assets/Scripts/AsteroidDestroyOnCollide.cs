using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidDestroyOnCollide : MonoBehaviour {
    public int AsteroidHP = 10;

    void OnCollisionEnter2D (Collision2D ColInfo)
    {
        if (ColInfo.gameObject.tag == "Bullet")
        {
            AsteroidHP -= 1;
            Destroy(ColInfo.gameObject);
        }
        if (AsteroidHP < 1)
        {
            Destroy(gameObject);
        }

           
           
        }







    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
