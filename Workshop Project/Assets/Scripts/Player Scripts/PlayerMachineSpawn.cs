using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMachineSpawn : MonoBehaviour
{
    // Start is called before the first frame update


    // Update is called once per frame
    public Rigidbody2D RedMachine;
    public Rigidbody2D YellowMachine;
    public Rigidbody2D BlueMachine;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            
            Instantiate(RedMachine, transform.position, Quaternion.identity);
        }
        if (Input.GetKeyDown(KeyCode.T))
        {

            Instantiate(BlueMachine, transform.position, Quaternion.identity);
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {

            Instantiate(YellowMachine, transform.position, Quaternion.identity);
        }
    }
}
