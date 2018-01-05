using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelPortal : MonoBehaviour {

    public Object SceneToLoad;
    public string LoadSceneName;
    static public bool L2enabled = false;
    static public bool L3enabled = false;
    static public bool L4enabled = false;
    static public bool L5enabled = false;



    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "portal")
        {
            SceneManager.LoadScene(LoadSceneName);
        }
        if(col.gameObject.name == "Level3Portal")
        {
            L2enabled = true;
        }
        if (col.gameObject.name == "Level4Portal")
        {
            L3enabled = true;
        }
        if (col.gameObject.name == "Level5Portal")
        {
            L4enabled = true;
        }
        if (col.gameObject.name == "EndPortal")
        {
            L5enabled = true;
        }
       
    }
}
