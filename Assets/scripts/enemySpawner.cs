using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    public GameObject enemy;
    public int amountToSpawn;
    void Start()
    {
        InvokeRepeating("spawnEnemy", 0, 10);
        
    }

    void spawnEnemy()
    {
        amountToSpawn = GameManager.difficulty + 1;
        for (int i = 0; i < amountToSpawn; i++)
            {
            Instantiate(enemy, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        
    }
}
