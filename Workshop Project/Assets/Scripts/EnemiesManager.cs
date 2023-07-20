using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq.Expressions;
using System.Security.Cryptography;
using UnityEngine;

public class EnemiesManager : MonoBehaviour
{
    [SerializeField] GameObject Enemy;
    [SerializeField] Vector2 spawnArea;
    [SerializeField] float spawnTimer;
    [SerializeField] Transform player;
    float timer;

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0f)
        {
            SpawnEnemy();
            timer = spawnTimer;
        }
    }

    void SpawnEnemy()
    {

        Vector3 position = new Vector3(
            UnityEngine.Random.Range(-spawnArea.x, spawnArea.x),
            UnityEngine.Random.Range(-spawnArea.y, spawnArea.y),
            0f
            );

        GameObject newEnemy = Instantiate(Enemy);
        newEnemy.transform.position = position;
        newEnemy.GetComponent<Enemy>().targetDestination = player;
    }
    
}
