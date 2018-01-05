using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopPractice : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        int num = 10;
        while (num > 0)
        {


            Debug.Log(num);
            num -= 1;
        }
        int num1 = 176;
       for(int i = 176; i < 1000; i++)
        {
            num1 += i;
            Debug.Log(num1);
        }
        int roll = 0;
       for (int i = 0; i < 100; i++)
        {
            int die1 = Random.Range(1, 7);
            int die2 = Random.Range(1, 7);
            roll = die1 + die2;
            Debug.Log(roll);
            if (roll == 12)
            {
                break;
            }
        }
    }

}
	

