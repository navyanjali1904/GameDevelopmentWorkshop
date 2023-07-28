using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float PlayerSpeed = 5f;
    public Rigidbody2D RB;
    public Vector2 Movement;
    [SerializeField] public int redEnergy = 0;
    [SerializeField] public int blueEnergy = 0;
    [SerializeField] public int yellowEnergy = 0;

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

    public void redCharge(int amount)
    {
        redEnergy += amount;
    }

    public void blueCharge(int amount)
    {
        blueEnergy += amount;
    }
    public void yellowCharge(int amount)
    {
        yellowEnergy += amount;
    }
}
