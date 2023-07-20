using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldColour : MonoBehaviour
{
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
            SpriteRenderer redSpriteRenderer = GetComponent<SpriteRenderer>();

            // Set the color of the SpriteRenderer to red
            redSpriteRenderer.color = redColor;

            RedMachine.SetActive(true);
            BlueMachine.SetActive(false);
            YellowMachine.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            // Create a new Color object for "Blue"
            Color blueColor = new Color(0f, 0f, 1f, 1f);

            // Get the SpriteRenderer component from the BlueMachine GameObject
            SpriteRenderer blueSpriteRenderer = GetComponent<SpriteRenderer>();

            // Set the color of the SpriteRenderer to blue
            blueSpriteRenderer.color = blueColor;

            RedMachine.SetActive(false);
            BlueMachine.SetActive(true);
            YellowMachine.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            // Create a new Color object for "Yellow"
            Color yellowColor = new Color(1f, 1f, 0f, 1f);

            // Get the SpriteRenderer component from the YellowMachine GameObject
            SpriteRenderer yellowSpriteRenderer = GetComponent<SpriteRenderer>();

            // Set the color of the SpriteRenderer to yellow
            yellowSpriteRenderer.color = yellowColor;

            RedMachine.SetActive(false);
            BlueMachine.SetActive(false);
            YellowMachine.SetActive(true);
        }
    }
}
