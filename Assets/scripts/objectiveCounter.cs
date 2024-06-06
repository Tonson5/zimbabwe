using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class objectiveCounter : MonoBehaviour
{
    public TextMeshProUGUI textMeshProUGUI;
    public GameObject[] objective;
    // Start is called before the first frame update
    void Start()
    {
        objective = GameObject.FindGameObjectsWithTag("objective");
    }

    // Update is called once per frame
    void Update()
    {
        textMeshProUGUI.text = ("Objectives To Destroy: " + objective.Length + "/4");
        
        objective = GameObject.FindGameObjectsWithTag("objective");
    }
}
