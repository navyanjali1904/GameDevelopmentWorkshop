using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disableMachine : MonoBehaviour
{
    // Start is called before the first frame update
    public WorldColour worldColour;
    public GameObject ground;
    public PlayerMachineSpawn PlayerMachineSpawn;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ground = GameObject.FindGameObjectWithTag("ground");
        if (ground.GetComponent<SpriteRenderer>().sprite == worldColour.RedSprite)
        {
            Debug.Log("World Colur is Red");
            foreach (GameObject machine in  PlayerMachineSpawn.Allobject) 
            {
                Debug.Log("Traversing the list now");

                if ((machine.name == "blueMachine(CLone)") || ((machine.name == "yellowMachine(CLone)")))
                {
                    Debug.Log( "Found either Blue or Yellow machine ");
                    PlayerMachineSpawn.BlueMachineRB.SetActive(false);
                    PlayerMachineSpawn.YellowMachineRB.SetActive(false);
                    PlayerMachineSpawn.RedMachineRB.SetActive(true);


                }
            }

        }

        if (ground.GetComponent<SpriteRenderer>().sprite == worldColour.YellowSprite)
        {
            Debug.Log("World Colur is Yellow");
            foreach (GameObject machine in PlayerMachineSpawn.Allobject)
            {
                Debug.Log("Traversing the list now");

                if ((machine.name == "blueMachine(CLone)") || ((machine.name == "redMachine(CLone)")))
                {
                    Debug.Log("Found either Blue or red machine ");
                    PlayerMachineSpawn.BlueMachineRB.SetActive(false);
                    PlayerMachineSpawn.YellowMachineRB.SetActive(true);
                    PlayerMachineSpawn.RedMachineRB.SetActive(false);


                }
            }

        }
        if (ground.GetComponent<SpriteRenderer>().sprite == worldColour.BlueSprite)
        {
            Debug.Log("World Colur is Blue");
            foreach (GameObject machine in PlayerMachineSpawn.Allobject)
            {
                Debug.Log("Traversing the list now");

                if ((machine.name == "yellowMachine(CLone)") || ((machine.name == "redMachine(CLone)")))
                {
                    Debug.Log("Found either Yellow or red machine ");
                    PlayerMachineSpawn.BlueMachineRB.SetActive(true);
                    PlayerMachineSpawn.YellowMachineRB.SetActive(false);
                    PlayerMachineSpawn.RedMachineRB.SetActive(false);


                }
            }

        }



    }
}
