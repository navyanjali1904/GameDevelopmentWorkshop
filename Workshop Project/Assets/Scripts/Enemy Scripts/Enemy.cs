using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Transform targetDestination;
    GameObject targetGameobject;
    Objective targetObjective;
    [SerializeField] float speed;
    [SerializeField] public int maxHP = 3;
    [SerializeField] public int currentHP = 3;
    [SerializeField] int damage = 1;
    [SerializeField] EnemyStatusBar EnemyHPBar;
    public GameObject[] Energies;


    [Range(0f, 1f)]
    public float chance = 0.6f;
    public GameObject[] Machines ;




    Rigidbody2D rgdbd2d;

    private void Awake()
    {
        rgdbd2d = GetComponent<Rigidbody2D>();
    }

    public void SetTarget(GameObject target)
    {
        targetGameobject = target;
        targetDestination = target.transform;
    }

    private void FixedUpdate()
    {
        Vector3 direction = (targetDestination.position - transform.position).normalized;
        rgdbd2d.velocity = direction * speed;
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject == targetGameobject)
        {
            Attack();
        }
        
        /*
        if (collision.gameObject.tag == "Pipe")
        {
            Vector3 direction = (targetDestination.position - transform.position).normalized;
        }
        */
    }

    private void Attack()
    {
        if (targetObjective == null)
        {
            targetObjective = targetGameobject.GetComponent<Objective>();
        }

        targetObjective.TakeDamage(damage);
    }

    public void TakeDamage(int damage)
    {
        currentHP -= damage;
        if (currentHP < 1)
        {
            Destroy(gameObject);
            DropEnergy();
        }
            

        EnemyHPBar.SetState(currentHP, maxHP);
    }
    private void DropEnergy()

    {
        if (Random.value < chance && Energies.Length > 0)
        {
            int RandomIndex = Random.Range(0, Energies.Length);
            {
                Transform energyPosition = Instantiate(Energies[RandomIndex]).transform;
                energyPosition.position = transform.position;
            }

        }



    }


}
