using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float PlayerSpeed = 5f;
    public Rigidbody2D RB;
    public Vector2 Movement;


    // Update is called once per frame
    void Update()
    {
        Movement.x = Input.GetAxisRaw("Horizontal");
        Movement.y = Input.GetAxisRaw("Vertical");


    }

    private void FixedUpdate()
    {
        RB.MovePosition(RB.position+Movement * PlayerSpeed * Time.fixedDeltaTime);
    }
}
