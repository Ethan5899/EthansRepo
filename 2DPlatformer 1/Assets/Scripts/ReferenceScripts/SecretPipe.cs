using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SecretPipe : MonoBehaviour {

    private bool OnPipe = false;

	// Use this for initialization
	void Start () {
   
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionStay2D(Collision2D myCollisionInfo)
    {
        if(myCollisionInfo.gameObject.name == "SpecialPipe" && Input.GetKeyDown(KeyCode.LeftShift))
        {
            SceneManager.LoadScene("SecretRooms");
        }
    }
    
  
}
