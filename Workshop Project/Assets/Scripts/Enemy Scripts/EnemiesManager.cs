using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq.Expressions;
using System.Security.Cryptography;
using UnityEngine;
using static UnityEngine.EventSystems.EventTrigger;

public class EnemiesManager : MonoBehaviour
{
    [SerializeField] GameObject redEnemy;
    [SerializeField] GameObject blueEnemy;
    [SerializeField] GameObject yellowEnemy;
    [SerializeField] Vector2 spawnArea;
    [SerializeField] float spawnTimer;
    [SerializeField] GameObject objective;
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

            Vector3 position = new Vector3(UnityEngine.Random.Range(-spawnArea.x, spawnArea.x), UnityEngine.Random.Range(-spawnArea.y, spawnArea.y), 0f);

            int randomNumberGenerator = UnityEngine.Random.Range(0, 100);
            if (randomNumberGenerator <= 33)
            {
                GameObject newEnemy = Instantiate(redEnemy);
                newEnemy.transform.position = position;
                newEnemy.GetComponent<Enemy>().SetTarget(objective);
            }
            if (randomNumberGenerator > 33 && randomNumberGenerator <= 67)
            {
                GameObject newEnemy = Instantiate(blueEnemy);
                newEnemy.transform.position = position;
                newEnemy.GetComponent<Enemy>().SetTarget(objective);
            }
            if (randomNumberGenerator > 67 && randomNumberGenerator < 100)
            {
                GameObject newEnemy = Instantiate(yellowEnemy);
                newEnemy.transform.position = position;
                newEnemy.GetComponent<Enemy>().SetTarget(objective);
            }
            Debug.Log("Enemy Spawned");
        }

}
