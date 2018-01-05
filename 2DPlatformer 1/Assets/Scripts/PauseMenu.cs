using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P))
        {
            
            Time.timeScale = 0;
            //assume this script is attached to the pausemenu canvas
            gameObject.GetComponent<Canvas>().enabled = true;

        }
        if (Time.timeScale > 0)
        {
            gameObject.GetComponent<Canvas>().enabled = false;
        }
    }

    public void Resume()
    {
        //reset timescale to 1 and hide the canvas
        Time.timeScale = 1;
        
    }

    public void QuitGame()
    {
        //this will quit the .exe application of unity once the game is built
        //this will do nothing when running in the editor
        Application.Quit();
    }

    public void Restart()
    {
        SceneManager.LoadScene("Level1");
    }



}
