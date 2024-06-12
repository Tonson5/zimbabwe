using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerSpawner : MonoBehaviour
{
    public GameObject player;
    public int amountToSpawn;
    public GameObject spawnpoint;
    public float cost;
    public int identifier;
    public MeshRenderer myRend;

    void Start()
    {
        myRend = GetComponent<MeshRenderer>();
    }
    private void Update()
    {
        if (GameManager.cards <= identifier)
        {
            gameObject.SetActive(false);
        }
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
