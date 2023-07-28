using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowPickUpObject : MonoBehaviour, IPickUpObject
{
    [SerializeField] int chargeAmmount;
    public void OnPickUp(PlayerMovement PlayerMovement)
    {
        PlayerMovement.yellowCharge(chargeAmmount);
    }
}
