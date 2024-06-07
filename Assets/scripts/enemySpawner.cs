using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    public GameObject enemy;
    void Start()
    {
        InvokeRepeating("spawnEnemy", 0, 10);
    }

    void spawnEnemy()
    {
        Instantiate(enemy,transform.position,Quaternion.identity);
        Destroy(gameObject);
    }
}
