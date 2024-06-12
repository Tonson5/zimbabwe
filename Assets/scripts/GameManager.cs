using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int difficulty;
    public static float courage;
    public SceneAsset[] maps;
    public static int cards;
    // Start is called before the first frame update
    void Start()
    {
        difficulty += 1;
        cards += 1;
        courage = 100;
       
    }

    // Update is called once per frame
    void Update()
    {
        if(courage > 100)
        {
            courage = 100;
        }
    }
    void FixedUpdate()
    {
        courage += 0.05f;
    }
}
