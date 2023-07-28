using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BluePickUpObject : MonoBehaviour, IPickUpObject
{
    [SerializeField] int chargeAmmount;
    public void OnPickUp(PlayerMovement PlayerMovement)
    {
        PlayerMovement.blueCharge(chargeAmmount);
    }
}
