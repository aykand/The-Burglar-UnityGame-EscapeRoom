using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
    public void ExitGame()
    {
        Debug.Log("You Exit The Game");
        Application.Quit();
    }
}
