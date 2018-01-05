using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    
    // Use this for initialization
    void Start()
    {

        
        gameObject.GetComponent<Canvas>().enabled = false;
        
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
       
        
    }

    public void Resume()
    {
        //reset timescale to 1 and hide the canvas
        Time.timeScale = 1;
        gameObject.GetComponent<Canvas>().enabled = false;

    }

    public void QuitGame()
    {

        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1;
    }

    public void Restart()
    {
        PlayerHealth.Lives -= 1;
        Scene loadedLevel = SceneManager.GetActiveScene();
        SceneManager.LoadScene(loadedLevel.buildIndex);
        Time.timeScale = 1;
        if (PlayerHealth.Lives <= 0)
        {
            PlayerHealth.Lives = 5;
            SceneManager.LoadScene("GameOver");
        }
    }



}
