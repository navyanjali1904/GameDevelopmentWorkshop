using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldColour : MonoBehaviour
{
    
    public GameObject ground;
    public GameObject RedMachine;
    public GameObject BlueMachine;
    public GameObject YellowMachine;




    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            // Create a new Color object for "Red"
            Color redColor = new Color(1f, 0f, 0f, 1f);

            // Get the SpriteRenderer component from the RedMachine GameObject
            SpriteRenderer redSpriteRenderer = ground.GetComponent<SpriteRenderer>();
            redSpriteRenderer.color = redColor;
            RedMachine.GetComponent<MachineShoot>().enabled = true;
            BlueMachine.GetComponent<MachineShoot>().enabled = false;
            YellowMachine.GetComponent<MachineShoot>().enabled = false;



            // Set the color of the SpriteRenderer to red

        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            // Create a new Color object for "Blue"
            Color blueColor = new Color(0f, 0f, 1f, 1f);

            // Get the SpriteRenderer component from the BlueMachine GameObject
            SpriteRenderer blueSpriteRenderer = ground.GetComponent<SpriteRenderer>();
            blueSpriteRenderer.color = blueColor;
            RedMachine.GetComponent<MachineShoot>().enabled = false;
            BlueMachine.GetComponent<MachineShoot>().enabled = true;
            YellowMachine.GetComponent<MachineShoot>().enabled = true;


            // Set the color of the SpriteRenderer to blue

        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            // Create a new Color object for "Yellow"
            Color yellowColor = new Color(1f, 1f, 0f, 1f);

            // Get the SpriteRenderer component from the YellowMachine GameObject
            SpriteRenderer yellowSpriteRenderer = ground.GetComponent<SpriteRenderer>();

            // Set the color of the SpriteRenderer to yellow
            yellowSpriteRenderer.color = yellowColor;
            RedMachine.GetComponent<MachineShoot>().enabled = false;
            BlueMachine.GetComponent<MachineShoot>().enabled = false;
            YellowMachine.GetComponent<MachineShoot>().enabled = true;

        }
    }
}
