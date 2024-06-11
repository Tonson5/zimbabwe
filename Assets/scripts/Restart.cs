using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public GameObject gameManager;
    public SceneAsset[] maps;
    void Start()
    {
        gameManager = GameObject.Find("GameManager");
        maps = gameManager.GetComponent<GameManager>().maps;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RestartGame()
    {
        Time.timeScale = 1;
        GameManager.difficulty = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void increaseDifficulty()
    {
        Time.timeScale = 1;
        GameManager.difficulty += 1;
        SceneManager.LoadScene(maps[Random.Range(0, maps.Length)].name);
    }
}
