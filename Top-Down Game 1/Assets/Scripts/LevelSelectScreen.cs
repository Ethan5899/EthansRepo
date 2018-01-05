using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelSelectScreen : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Level1()
    {
        SceneManager.LoadScene("Level1");
    }
    public void Level2()
    {
        if (LevelPortal.L2enabled == true)
            {
            SceneManager.LoadScene("Level2"); }
    }
    public void Level3()
    {
        if (LevelPortal.L3enabled == true)
        {
            SceneManager.LoadScene("Level3");
        }
    }
    public void Level4()
    {
        if (LevelPortal.L4enabled == true)
        {
            SceneManager.LoadScene("Level4");
        }
    }
    public void Level5()
    {
        SceneManager.LoadScene("Level5");
    }
    public void MainMenu()
        {
        SceneManager.LoadScene("MainMenu");
    }
}
