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
            
            
        }
    }
    private void OnMouseDown()
    {
        Instantiate(player, spawnpoint.transform.position, Quaternion.identity);
    }
}
