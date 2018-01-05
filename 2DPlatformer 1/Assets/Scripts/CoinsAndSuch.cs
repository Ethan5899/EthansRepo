using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsAndSuch : MonoBehaviour
{

    //these are for the image canvas'
    public GameObject Muns;
    //public GameObject Gemas;
    public GameObject Stary;
    public GameObject Starry;
    public GameObject Stary3;
    public GameObject ScoreBoard;

    //Counting the collectables
    private int CoinCount = 0;
    private int GemCount = 0;
    private int StarCount = 0;
    private int Score;
    //Gems are worth 24 points
    private int GemP = 0;
    //Stars are worth 44 points
    private int StarP = 0;

    //Display Helper
    private bool Star1;
    private bool Star2;
    private bool Star3;

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetInt("Gems", GemCount);

        PlayerPrefs.SetInt("Coins", CoinCount);

        if (Star1 == true)
        {
            PlayerPrefs.SetInt("Star1", 1);
        }

        if (Star2 == true)
        {
            PlayerPrefs.SetInt("Stars2", 1);
        }

        if (Star3 == true)
        {
            PlayerPrefs.SetInt("Stars3", 1);
        }

        Score = CoinCount + GemP + StarP;

        GemP = 24 * GemCount;

        StarP = 44 * StarCount;

        //tells you how many coins you have
        Muns.GetComponent<Text>().text = "x " + CoinCount;

        //Keeps track of your score
        ScoreBoard.GetComponent<Text>().text = "Score: " + Score;

    }

     void OnTriggerEnter2D(Collider2D collision)
    {
        //If you run into a coin you collect it
        if (collision.gameObject.name == "Coins")
        {
            Destroy(collision.gameObject);
            CoinCount ++;
        }

        //if you run into a star gem you collect it
        //and the appropriate star image is displayed
        if (collision.gameObject.name == "Star")
        {
            Destroy(collision.gameObject);
            Starry.GetComponent<Image>().enabled = true;
            StarCount ++;
            Star1 = true;
        }

        //if you run into a gem, you collect it, it is displayed
        if (collision.gameObject.name == "Gem")
        {
            Destroy(collision.gameObject);
            GemCount ++;
            //Gemas.GetComponent<Image>().enabled = true;
        }

        //if you run into a star gem you collect it
        //and the appropriate star image is displayed
        if (collision.gameObject.name == "Stars")
        {
            Destroy(collision.gameObject);
            StarCount ++;
            Stary.GetComponent<Image>().enabled = true;
            Star2 = true;
        }

        if (collision.gameObject.name == "Stars2")
        {
            Destroy(collision.gameObject);
            StarCount++;
            Stary3.GetComponent<Image>().enabled = true;
            Star3 = true;
        }
    }
}
