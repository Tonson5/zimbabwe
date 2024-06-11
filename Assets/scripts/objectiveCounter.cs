using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class objectiveCounter : MonoBehaviour
{
    public TextMeshProUGUI textMeshProUGUI;
    public GameObject[] objective;
    public int startObjectives;
    public GameObject winScreen;
    // Start is called before the first frame update
    void Start()
    {
        objective = GameObject.FindGameObjectsWithTag("objective");
        startObjectives = objective.Length;
        winScreen = GameObject.Find("win screen");
    }

    // Update is called once per frame
    void Update()
    {
        textMeshProUGUI.text = ("Objectives To Destroy: " + objective.Length + "/" + startObjectives);
        
        objective = GameObject.FindGameObjectsWithTag("objective");

        if (objective.Length == 0)
        {
            Time.timeScale = 0;
            winScreen.GetComponent<LoseSceenActivate>().ActivateLoseScreen();
        }
        else
        {
            Time.timeScale = 1;
        }
    }
}
