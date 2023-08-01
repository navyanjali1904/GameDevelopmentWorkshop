using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class EnergyUpdateScript : MonoBehaviour
{
    public PlayerEnergyPickup playerEnergyPickup;
    
    public TextMeshProUGUI EnergyCountTextUpdate;
    

    private void Start()
    {
        GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
         
        playerEnergyPickup = playerObject.GetComponent<PlayerEnergyPickup>();
        

    }


    private void Update()
    {
        // Access the RedEnergyCount value from the PlayerEnergyPickup script

        if (EnergyCountTextUpdate.CompareTag("RUI"))
        {
            int EnergyCount = playerEnergyPickup.RedEnergyCount;
            EnergyCountTextUpdate.text = EnergyCount.ToString();

        }

        else if(EnergyCountTextUpdate.CompareTag("BUI"))
        {
            int EnergyCount = playerEnergyPickup.BlueEnergyCount;
            EnergyCountTextUpdate.text = EnergyCount.ToString();

        }
        else if (EnergyCountTextUpdate.CompareTag("YUI"))
        {
            int EnergyCount = playerEnergyPickup.YellowEnergyCount;
            EnergyCountTextUpdate.text = EnergyCount.ToString();

        }


    }
}