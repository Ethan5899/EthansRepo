using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
        PlayerHealth.Lives = 3;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void StartGame()
    {
        SceneManager.LoadScene("Level1");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    
}
