using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPickUpObject : MonoBehaviour, IPickUpObject
{
    [SerializeField] int chargeAmmount;
    public void OnPickUp(PlayerMovement PlayerMovement)
    {
        PlayerMovement.redCharge(chargeAmmount);
    }
}
