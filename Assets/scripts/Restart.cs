using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public GameObject gameManager;
    void Start()
    {
        gameManager = GameObject.Find("GameManager");
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
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
