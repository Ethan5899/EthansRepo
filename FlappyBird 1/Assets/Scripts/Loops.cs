using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour {

    // Use this for initialization
    void Start() {
        //if statements care about a boolean 
        if (true)
        {
            Debug.Log("Do the Thing");
        }
        //Dont do this
        //while loop will continue to run over and over as long as its condition is true
        int dishes = 5;
        while (dishes > 0)
        {
            Debug.Log("I washed a dish");
            dishes--;
        }
        int cups = 5;
        while (true)
        {
            Debug.Log("I washed a cup");
            if (cups <= 0)
            {
                break;
                //we can get out of the loop[ by using a conditional if statement and teh break command
            }
        }
        //for loop
        for (int i = 0; i > 5; i++)
        {
            Debug.Log("Repeating step" + i);
        }

        for (int plates = 0; plates < 5; plates++)
        {
            Debug.Log("WashingPlates");
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
