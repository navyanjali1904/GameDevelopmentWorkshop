using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEnergyPickup : MonoBehaviour
{

    public List<string> inventory;
    public List<string> RedEnergy;
    public List<string> BlueEnergy;
    public List<string> YellowEnergy;
    public int RedEnergyCount = 50;
    public int BlueEnetgyCount = 50;
    public int YellowEnergyCount = 50;
    public string itemtype;

    private void Start()
    {
        inventory = new List<string> ();
        RedEnergy = new List<string> ();
        BlueEnergy = new List<string> ();
        YellowEnergy = new List<string> ();




    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("collectable"))
        {
            itemtype = collision.gameObject.GetComponent<ItemtypeScript>().itemtype;
            Debug.Log("We have an " + itemtype);
            if(itemtype == "blue energy")
            {
                
                BlueEnergy.Add(itemtype);
                inventory.Add(itemtype);
                BlueEnetgyCount += 2;


            }
            else if (itemtype == "red energy")
            {
                RedEnergy.Add(itemtype);
                inventory.Add(itemtype);
                RedEnergyCount += 2;

            }
            else if (itemtype == "yellow energy")
            {
                YellowEnergy.Add(itemtype);
                inventory.Add(itemtype);
                YellowEnergyCount += 2;

            }
            
            Debug.Log("inventory length " + inventory.Count);
            Destroy(collision.gameObject);
        }


    }
    
}
