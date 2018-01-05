using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelLoader : MonoBehaviour {
    public string LoadSceneName;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "LevelEnd")
        {
            SceneManager.LoadScene(LoadSceneName);
        }
    }
}
