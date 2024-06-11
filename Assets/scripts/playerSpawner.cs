using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerSpawner : MonoBehaviour
{
    public GameObject player;
    public int amountToSpawn;
    public GameObject spawnpoint;
    public float cost;

    void Start()
    {
        
    }
    private void OnMouseDown()
    {
        if(cost < GameManager.courage)
        {
            GameManager.courage -= cost;
            for (int i = 0; i < amountToSpawn; i++)
            {
                Instantiate(player, spawnpoint.transform.position, Quaternion.identity);
            }
            
        }
        
    }
}
