using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletVelocityScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D Bullet;
    public float BulletSpeed = 20f;
    public string enemyTag = "Enemy";
    private GameObject enemy;
    private Transform target;

    public void Seek(Transform _target)
    {
        target = _target;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 dir = target.position - transform.position;
        float distanceThisFrame = BulletSpeed * Time.deltaTime;

        if (dir.magnitude <= distanceThisFrame)
        {
            //hit effect in here
            Destroy(gameObject);
        }

        transform.Translate(dir.normalized * distanceThisFrame, Space.World);
        //Bullet.velocity = transform.right * BulletSpeed;
    }

}
