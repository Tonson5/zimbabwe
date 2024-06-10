using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winScreen : MonoBehaviour
{
    public GameObject actualWinScreen;

    public void ActivateLoseScreen()
    {
        actualWinScreen.SetActive(true);
    }
}
