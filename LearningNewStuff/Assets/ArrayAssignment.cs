using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayAssignment : MonoBehaviour {
    public int[] maxHP;
    public int lvl = 1;
	// Use this for initialization
	void Start () {
        Debug.Log("MaximumHP:" + maxHP[lvl - 1]);
        //We can always get the last index in the array by doing .Length - 1 on our array
        Debug.Log("Max HP at Lvl Cap" + maxHP[maxHP.Length - 1]);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
