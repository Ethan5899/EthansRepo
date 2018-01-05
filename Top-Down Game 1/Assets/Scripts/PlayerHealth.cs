using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PlayerHealth : MonoBehaviour
{
    public int Hp = 5;
    public GameObject HpText;
    public static int Lives = 5;
    public GameObject LivesText;
    void Update()
    {
        HpText.GetComponent<Text>().text = "Health: " + Hp;
        LivesText.GetComponent<Text>().text = "Lives: " + Lives;
    }


    void OnCollisionEnter2D(Collision2D Bob)
    {
        if (Bob.gameObject.tag == "Enemy")
        {
            Hp -= 1;
        }
        if (Bob.gameObject.tag == "Asteroid")
        {
            Hp -= 1;
        }
        if (Bob.gameObject.tag == "Health" & Hp < 10)
        {
            Hp += 1;
        }
        if (Bob.gameObject.tag == "Life")
        {
            Lives += 1;
        }
        if (Hp <= 0)
        {
            Lives -= 1;
            Scene loadedLevel = SceneManager.GetActiveScene();
            SceneManager.LoadScene(loadedLevel.buildIndex);
            
        }
        if (Lives <= 0)
        {
            Lives = 5;
            SceneManager.LoadScene("GameOver");
        }
       
    }
}

