using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class EnemyWaveSpawner : MonoBehaviour
{

    public Transform enemy;
    public float timeBetweenWaves = 10f;
    public float countdown = 5f;
    public GameObject [] enemyPrefab;
    private int WaveIndex = 0;

    
    void Update()
    {
        if (countdown <= 0)
        {
            StartCoroutine(SpawnWaves());
            
            countdown = timeBetweenWaves;


        }
        countdown -= Time.deltaTime;
        
    }

     IEnumerator SpawnWaves()
    {
        WaveIndex++;
        for(int i = 0;  i < WaveIndex; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(0.5f);
        }
        
    }
    void SpawnEnemy()
    {
        int randomNumberGenerator = Random.Range(0, 100);
        if (randomNumberGenerator <=33)
        {
            Instantiate(enemyPrefab[0], enemy.position, enemy.rotation);
        }
        if (randomNumberGenerator > 33 && randomNumberGenerator <= 67)
        {
            Instantiate(enemyPrefab[1], enemy.position, enemy.rotation);
        }
        if (randomNumberGenerator > 67 && randomNumberGenerator < 100 )
        {
            Instantiate(enemyPrefab[2], enemy.position, enemy.rotation);
        }
        Debug.Log("Enemy Spawned");
    }
}
