using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Transform targetDestination;
    GameObject targetGameobject;
    Objective targetObjective;
    public GameObject Objective;
    [SerializeField] float speed;
    [SerializeField] public int maxHP = 3;
    [SerializeField] public int currentHP = 3;
    [SerializeField] int damage = 1;
    [SerializeField] EnemyStatusBar EnemyHPBar;
    public GameObject[] Energies;
    public bool pipeAvoidance = false;
    public Vector3 updatedTargetPosition;


    private Animator _animator;
    private SpriteRenderer _spriteRenderer;

    [Range(0f, 1f)]
    public float chance = 0.6f;
    




    Rigidbody2D rgdbd2d;

    private void Awake()
    {

        rgdbd2d = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>(); // needed for telling the animator to change values
        _spriteRenderer = GetComponent<SpriteRenderer>(); // needed for flipping sprite to face direction
    }




    private void FixedUpdate()
    {
            
           Objective = GameObject.FindGameObjectWithTag("Finish");
           targetGameobject = Objective;
            targetDestination = Objective.transform;

        FlipSprite();


        Vector3 direction = (targetDestination.position - transform.position).normalized;
        if (pipeAvoidance)
        {
            // Use the direction with avoidance
            direction = (updatedTargetPosition - transform.position).normalized;
        }

        rgdbd2d.velocity = direction * speed;
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject == targetGameobject)
        {
            Attack();
            _animator.SetBool("isAttacking", true);
        }

        if (collision.gameObject.tag == "Pipe")
        {
            Vector3 awayFromPipe = transform.position - collision.transform.position;
            Vector3 offset = awayFromPipe.normalized * 0.5f; // Adjust the offset as needed
            Vector3 newDirection = (targetDestination.position - transform.position + offset).normalized;

            updatedTargetPosition = transform.position + newDirection * speed; // Calculate the updated target position

            pipeAvoidance = true; // Enable pipe avoidance mode
        }


    }
    private void Attack()
    {
        if (targetObjective == null)
        {
            targetObjective = targetGameobject.GetComponent<Objective>();
        }

        targetObjective.TakeDamage(damage);
        speed = 0;
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

    private void FlipSprite()
    {

        updatedTargetPosition = targetDestination.position - transform.position;

        updatedTargetPosition.Normalize();

        _animator.SetFloat("X", updatedTargetPosition.x);
        _animator.SetFloat("Y", updatedTargetPosition.y);

        if (updatedTargetPosition.x < -0.1 )
        {
            _spriteRenderer.flipX = true;
        }

        else if (updatedTargetPosition.x >= -0.09)
        {
            _spriteRenderer.flipX = false;
        }

    }

}