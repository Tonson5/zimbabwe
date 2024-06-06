using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerSpawner : MonoBehaviour
{
    public GameObject player;
    public int amountToSpawn;
    public GameObject spawnpoint;

    void Start()
    {
        
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 0; i < amountToSpawn; i++)
            {
                
            }
            
        }
    }
    private void OnMouseDown()
    {
        Instantiate(player, spawnpoint.transform.position, Quaternion.identity);
    }
}
