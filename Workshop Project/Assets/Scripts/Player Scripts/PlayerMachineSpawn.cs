using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMachineSpawn : MonoBehaviour
{
    // Start is called before the first frame update

    private int redEnergy;
    private int blueEnergy;
    private int yellowEnergy;
    // Update is called once per frame
    public Rigidbody2D RedMachine;
    public Rigidbody2D YellowMachine;
    public Rigidbody2D BlueMachine;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            redEnergy = GetComponent<PlayerMovement>().redEnergy;
            if (redEnergy >= 3)
            {
                Instantiate(RedMachine, transform.position, Quaternion.identity);
                redEnergy -= 3;
                GetComponent<PlayerMovement>().redEnergy = redEnergy;
            }
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            blueEnergy = GetComponent<PlayerMovement>().blueEnergy;
            if (blueEnergy >= 3)
            {
                Instantiate(BlueMachine, transform.position, Quaternion.identity);
                blueEnergy -= 3;
                GetComponent<PlayerMovement>().blueEnergy = blueEnergy;
            }
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            yellowEnergy = GetComponent<PlayerMovement>().yellowEnergy;
            if (yellowEnergy >= 3)
            {
                Instantiate(YellowMachine, transform.position, Quaternion.identity);
                yellowEnergy -= 3;
                GetComponent<PlayerMovement>().yellowEnergy = yellowEnergy;
            }
        }
    }
}
