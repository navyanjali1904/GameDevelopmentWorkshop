using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletVelocityScript : MonoBehaviour
{
    public Rigidbody2D Bullet;
    public float BulletSpeed = 20f;
    public string enemyTag = "Enemy";

    private Transform target;

    public void Seek(Transform _target, string _enemyTag)
    {
        target = _target;
        enemyTag = _enemyTag;
    }

    void Update()
    {
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

    void HitTarget()
    {
        // Check if the target has the specified tag
        if (target.CompareTag(enemyTag))
        {
            // Handle enemy hit logic here
            Destroy(target.gameObject); // Example: Destroy the enemy on collision

            // Destroy the bullet
            Destroy(gameObject);
        }
        else
        {
            // If the target does not have the specified tag, just destroy the bullet
            Destroy(gameObject);
        }
    }
}
