using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListsAndArrays : MonoBehaviour {
     
	// Use this for initialization
	void Start () {
        //arrays have fixed length, length is determined when they are created
        int[] intArray = new int[10];
        //this array has length 10
        
        //list count = 0, empty on creation
        List<string> names = new List<string>();
        names.Add("Gable");
        //now the list has one item in it
        Debug.Log(names.Count);
        Debug.Log(names[0]);
        names.Remove("Gable");
        names.Sort();
        //sort is heavey uses lots of processing only sort once, when you need it
        List<string> classNames = new List<string>();
        classNames.Add("Gable");
        classNames.Add("Alex");
        classNames.Add("Caleb");
        classNames.Add("Carlos");
        classNames.Add("Jessica");
        classNames.Add("Ethan");
        classNames.Add("Brenna");
        classNames.Add("Vince");
        classNames.Add("Jordan");
        classNames.Add("Jeremiah");
        classNames.Add("Evan");
        classNames.Add("Denis");
        Debug.Log(classNames[1]);
	}
	
	
}
