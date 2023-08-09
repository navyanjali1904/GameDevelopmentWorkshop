using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BulletVelocityScript : MonoBehaviour
{
    public Rigidbody2D Bullet;
    public float BulletSpeed = 20f;
    public string enemyTag = "Enemy";
    Enemy targetEnemy;
    [SerializeField] int damage = 1;

    private Transform target;
    [SerializeField] Vector2 bulletAttackSize = new Vector2(1f, 1f);

    public void Seek(Transform _target, string _enemyTag)
    {
        target = _target;
        enemyTag = _enemyTag;
    }

    bool hitDetected = false;
    void Update()
    {
        Collider2D[] hit = Physics2D.OverlapCircleAll(transform.position, 0.5f);
        foreach (Collider2D c in hit) 
        { 
            Enemy enemy = c.GetComponent<Enemy>();
            if(enemy != null)
            {
                enemy.TakeDamage(damage);
                hitDetected = true;
                break;
            }
        }
        if(hitDetected == true) 
        {
            Destroy(gameObject);
        }

        if (target == null)
        {
            Destroy(gameObject);
            return;
        }

        Vector3 dir = target.position - transform.position;
        float distanceThisFrame = BulletSpeed * Time.deltaTime;

        if (dir.magnitude <= distanceThisFrame)
        {
            // Hit effect or logic when the bullet reaches the target
            HitTarget();
            return;
        }

        transform.Translate(dir.normalized * distanceThisFrame, Space.World);
    }

    private void HitTarget()
    {
        // Check if the target has the specified tag
        if (target.CompareTag(enemyTag))
        {
            // Handle enemy hit logic here

            Destroy(gameObject);
        }
        else
        {
            // If the target does not have the specified tag, just destroy the bullet
            Destroy(gameObject);
        }
    }
}
