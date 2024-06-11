using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class playerCourageCounter : MonoBehaviour
{
    public TextMeshProUGUI textMeshProUGUI;
    public GameObject winScreen;
    // Start is called before the first frame update
    void Start()
    {
        textMeshProUGUI = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        textMeshProUGUI.text = ("Courage: " + GameManager.courage + "/100");
    }
}
