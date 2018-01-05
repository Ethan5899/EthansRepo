using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour {
    public int Hp = 1;
    public static int Lives = 3;
    public bool invincible = false;
     public float invTimer = 10;
    Animator anim;
    Color playerColor;
    public GameObject LifeText;

  
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        playerColor = GetComponent<SpriteRenderer>().color;

    }
	
	// Update is called once per frame
	void Update () {
		if (Hp <= 0)
        {
            Lives -= 1;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (Lives <= 0)
        {
            Lives = 3;
            SceneManager.LoadScene("GameOver");
        }
        if (invincible == true)
        {
            GetComponent<PlayerMovementTest>().moveSpeed = 4.5f;
            playerColor = GetComponent<SpriteRenderer>().color = Color.green;
            invTimer -= Time.deltaTime;
            if (invTimer <= 0)
            {
                invincible = false;
                invTimer = 10;
                anim.SetBool("isInvincible", false);
                playerColor = GetComponent<SpriteRenderer>().color = Color.white;
                GetComponent<PlayerMovementTest>().moveSpeed = 3;
            }
        }
        LifeText.GetComponent<UnityEngine.UI.Text>().text = " x " +Lives;

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy" && invincible == false)
        {
            
            Hp -= 1;
        }
        if (collision.gameObject.tag == "killBoundary")
        {
            Hp = 0;
        }
        if (collision.gameObject.tag == "invinciblePowerUp")
        {
            invincible = true;
            Destroy(collision.gameObject);
            anim.SetBool("isInvincible", true);
        }
        if (collision.gameObject.tag == "LifeItem")
        {
            Lives += 1;
            Destroy(collision.gameObject);
        }
    }
}
