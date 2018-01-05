using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SecretsCanvas : MonoBehaviour {

    //Shift1 is covering the secret room
    public GameObject Shift1;
    //Shift2 is covering the level, while
    //in secret room
    public GameObject Shift2;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Destination1")
        {
            Shift1.GetComponent<Image>().enabled = false;
            Shift2.GetComponent<Image>().enabled = true;
        }

        if (collision.gameObject.name == "Destination2")
        {
            Shift1.GetComponent<Image>().enabled = true;
            Shift2.GetComponent<Image>().enabled = false;
        }
    }
}
