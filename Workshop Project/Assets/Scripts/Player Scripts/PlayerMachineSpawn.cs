using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMachineSpawn : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject[] Allobject;
    public GameObject nearestOBJ;
    public float nearestDistance = 50;
    public float minimumDistanceThreshold = 8f;
    public Rigidbody2D RedMachine;
    public Rigidbody2D YellowMachine;
    public Rigidbody2D BlueMachine;
    public GameObject ground;

    private void Start()
    {

    }

    void Update()
    {
        // Find the nearest machine and update nearestOBJ and nearestDistance
        Allobject = GameObject.FindGameObjectsWithTag("Machine");
        nearestDistance = 50; // Reset nearestDistance to a high value

        for (int i = 0; i < Allobject.Length; i++)
        {
            float distance = Vector3.Distance(this.transform.position, Allobject[i].transform.position);
            if (distance < nearestDistance)
            {
                nearestDistance = distance;
                nearestOBJ = Allobject[i];
            }
        }

        // Check if the player is close to the nearest machine and prevent instantiation if true


        if (Input.GetKeyDown(KeyCode.S))
        {

            if (nearestDistance < minimumDistanceThreshold)
            {
                Debug.Log("Too close to an existing machine. Cannot place a new one.");
                return; // Prevent instantiation of the new machine
            }

            // Instantiate the new machine if the player is not too close to any existing machine
            if (Input.GetKeyDown(KeyCode.S) &&  ground.GetComponent<SpriteRenderer>().color == new Color(1f, 0f, 0f, 1f))
            {
                Instantiate(RedMachine, transform.position, Quaternion.identity);
            }
            else if (Input.GetKeyDown(KeyCode.S) && ground.GetComponent<SpriteRenderer>().color == new Color(0f, 0f, 1f, 1f))
            {
                Instantiate(BlueMachine, transform.position, Quaternion.identity);
            }
            else if (Input.GetKeyDown(KeyCode.S) &&  ground.GetComponent<SpriteRenderer>().color == new Color(1f, 1f, 0f, 1f))
            {
                Instantiate(YellowMachine, transform.position, Quaternion.identity);
            }
        }

    }
}
