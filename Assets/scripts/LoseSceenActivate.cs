using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseSceenActivate : MonoBehaviour
{
    public GameObject actualLoseScreen;

    public void ActivateLoseScreen()
    {
        actualLoseScreen.SetActive(true);
    }
}
