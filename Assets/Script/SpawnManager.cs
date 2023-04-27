using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemies;
    public GameObject powerup;
    private float zEnemySpawn = -7.0f;
    private float xSpawnRange = -5.0f;
    private float zPowerRange = -5.0f;
    private float ySpawn = .75f;

    private float powerupSpawnTime = 5.0f;
    private float enemySpawnTime = .5f;
    private float startDelay = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomEnemy", startDelay, enemySpawnTime);
        InvokeRepeating("SpawnPowerup", startDelay, powerupSpawnTime);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomEnemy()
    {
        float randomx = Random.Range(-xSpawnRange, xSpawnRange);
        int randomIndex = Random.Range(0, enemies.Length);
        Vector3 spawnPos = new Vector3(randomx, ySpawn, zEnemySpawn);

        Instantiate(enemies[randomIndex], spawnPos, enemies[randomIndex].gameObject.transform.rotation);
    }

    void SpawnPowerup()
    {
        float randomx = Random.Range(-xSpawnRange, xSpawnRange);
        float randomz = Random.Range(-zPowerRange, zPowerRange);
        Vector3 spawnPos = new Vector3(randomx, ySpawn, randomz);

        Instantiate(powerup);
    }
}
