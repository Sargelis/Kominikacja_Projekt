using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    public GameObject enemySpawner;
    public EnemyStats enemyStats;
    public float spawnInterval;
    float spawnCooldown;

    void Start()
    {
        spawnCooldown = spawnInterval;
    }
    void Update()
    {
        if(spawnInterval > 0)
        {
            spawnInterval -= Time.deltaTime;
            if (spawnInterval <= 0) 
            {
                SpawnEnemy();
                spawnInterval = spawnCooldown;
            }
        }
    }

    public void SpawnEnemy()
    {
        Instantiate(enemy, enemySpawner.transform.position, Quaternion.identity);
    }
}