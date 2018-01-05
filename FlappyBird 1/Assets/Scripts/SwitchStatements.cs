using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchStatements : MonoBehaviour {

	// Use this for initialization
	void Start () {
        int popularity = 5;
        //switch outcome based on popularity
        switch (popularity)
        {         //if our popularity is 5 say were so popular
            case 5:
                Debug.Log("Were so popular");
                    break;
            case 4:
                Debug.Log("Were pretty cool");
                break;
            case 3:
                Debug.Log("sort of cool");
                break;
            case 2:
                Debug.Log("Not cool");
                break;
            case 1:
                Debug.Log("Social outcast");
                break;
            default:
                Debug.Log("Your popularity is out of bounds");
                break;


        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
