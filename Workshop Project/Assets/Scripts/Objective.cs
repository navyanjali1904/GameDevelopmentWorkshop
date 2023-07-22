using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Objective : MonoBehaviour
{
    public int maxHp = 1000;
    public int currentHp = 1000;
    [SerializeField] StatusBar hpBar;

    public void TakeDamage(int damage)
    {
        currentHp -= damage;

        if (currentHp <= 0)
        {
            UnityEngine.Debug.Log("Character is dead GAME OVER");
        }
        hpBar.SetState(currentHp, maxHp);
    }
}
