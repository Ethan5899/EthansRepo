using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour {
   public string name1 = "Freddy", name2 = "Archibald", name3 = "Tinkerbell", name4 = "Gertrude", name5 = "Alex";
    public string[] namesList;
	// Use this for initialization
	void Start () {
        //Reference a particular index, in this casze index = 0.
        Debug.Log("Name:" + namesList[0]);
        Debug.Log("How many names:" + namesList.Length);
        // Arrays are a fixed length, once created they cannot get longer or shorter.
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
