using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryArray : MonoBehaviour {
    public string[] inventory = new string[3];
    //create slot pointer, start at 0 so that the first item added will go into the array index 0
    int slot = 0;

    //first function will add a givin string to the inventory
    //recieves a string of the item to add to the inventory
    void Add(string item)
    {
        //add the given item to the inventory at the correct slot position
        //only add to the inventory if we have open slots
        if(slot < inventory.Length)
        {
            inventory[slot] = item;
            slot++;
        }
        
    }

    //second function will increase the size of our inventory
    //recieves an integer increase that is how many of our inventory slots we are going to add to our backpack
    void ExtendBackpack(int increase)
    {
        //create a new string[] that is as long as the old string[] plus the increased size
        string[] newInventory = new string[inventory.Length + increase];
        //loop through the entire inventory array using this for loop
        for (int i = 0; i < inventory.Length; i++)
        {
            newInventory[i] = inventory[i];
        }
        inventory = newInventory;
    }

	// Use this for initialization
	void Start () {
        Add("Sword of a Thousand Truths");
        Add("Last Word");
        Add("Uranium");
        Add("Broken Item");
        ExtendBackpack(3);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
